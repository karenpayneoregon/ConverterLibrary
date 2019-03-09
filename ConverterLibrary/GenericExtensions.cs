using System;
using System.ComponentModel;

namespace ConverterLibrary
{
    public static class GenericExtensions
    {
        /// <summary>
        /// Generic 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <returns></returns>
        public static T Convert<T>(this string input)
        {
            try
            {
                var converter = TypeDescriptor.GetConverter(typeof(T));
                if (converter != null)
                {
                    return (T)converter.ConvertFromString(input);
                }
                return default(T);
            }
            catch (NotSupportedException)
            {
                return default(T);
            }
        }
        public static bool Is<T>(this string input)
        {
            var type = typeof(T);
            var temp = default(T);

            var method = type.GetMethod("TryParse",new[]
                {
                    typeof (string),Type.GetType(string.Format("{0}&", type.FullName))
                });

            return (bool)method.Invoke(null, new object[] { input, temp });
        }
    }
}
