using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLibrary
{
    public static class ConvertExtensions
    {
        // converts the source object variable value to the desired result type 
        public static T ChangeType<T>(this object value)
        {
            return (T)ChangeType(value, typeof(T));
        }


        // converts the source value, and if null returns the specified default value
        public static T ChangeType<T>(this object value, T whenNull)
        {
            return (value == null || value is DBNull) ? whenNull : (T)ChangeType(value, typeof(T));
        }

        public static object ChangeType(this object value, Type convertToType)
        {
            if (convertToType == null)
            {
                throw new ArgumentNullException("convertToType");
            }

            // return null if the value is null or DBNull
            if (value == null || value is DBNull)
            {
                return null;
            }

            // non-nullable types, which are not supported by Convert.ChangeType(),
            // unwrap the types to determine the underlying time
            if (convertToType.IsGenericType && convertToType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                convertToType = Nullable.GetUnderlyingType(convertToType);
            }

            // deal with conversion to enum types when input is a string
            if (convertToType.IsEnum && value is string)
            {
                return Enum.Parse(convertToType, value as string);
            }

            // deal with conversion to enum types when input is a integral primitive
            if (value != null && convertToType.IsEnum && value.GetType().IsPrimitive && !(value is bool) && !(value is char) && !(value is float) && !(value is double))
            {
                return Enum.ToObject(convertToType, value);
            }

            // use Convert.ChangeType() to do all other conversions
            return Convert.ChangeType(value, convertToType, CultureInfo.InvariantCulture);
        }
    }
}
