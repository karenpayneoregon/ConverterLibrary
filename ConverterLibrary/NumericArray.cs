﻿using System;
using System.Linq;

namespace ConverterLibrary
{
    public static class NumericArray
    {
        #region int convert methods
        /// <summary>
        /// Determine if all values can represent an int
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static bool AllInt(this string[] sender) => 
            sender.SelectMany(item => item.ToCharArray()).All(char.IsNumber);

        /// <summary>
        /// Convert values in array to int array discards non int values in array.
        /// </summary>
        /// <param name="sender">string array</param>
        /// <returns>All valid elements that are int discarding non int values</returns>
        public static int[] ToIntegerArray(this string[] sender)
        {

            var intArray = Array
                .ConvertAll(sender,
                    (input) => new
                    {
                        IsInteger = int.TryParse(input, out var integerValue),
                        Value = integerValue
                    })
                .Where(result => result.IsInteger)
                .Select(result => result.Value)
                .ToArray();

            return intArray;

        }
        /// <summary>
        /// Convert all values in array to int array where non int values will be set to the default value.
        /// </summary>
        /// <param name="sender">string array</param>
        /// <returns>All elements in array as int</returns>
        public static int[] ToIntegerPreserveArray(this string[] sender)
        {

            var intArray = Array.ConvertAll(sender, (input) =>
            {
                int.TryParse(input, out var integerValue);
                return integerValue;
            });

            return intArray;

        }

        #endregion

        #region double convert methods
        /// <summary>
        /// Determine if all string elements can represent double
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static bool AllDouble(this string[] sender) =>
            sender.All(item => double.TryParse(item, out var test));


        /// <summary>
        /// Convert values in array to double array discards non double values in array.
        /// </summary>
        /// <param name="sender">string array</param>
        /// <returns>All valid elements that are double discarding non double values</returns>
        public static double[] ToDoubleArray(this string[] sender)
        {

            var doubleArray = Array
                .ConvertAll(sender,
                    (input) => new
                    {
                        IsDouble = double.TryParse(input, out var doubleValue),
                        Value = doubleValue
                    })
                .Where(result => result.IsDouble)
                .Select(result => result.Value)
                .ToArray();

            return doubleArray;

        }

        /// <summary>
        /// Convert all values in array to double array where non double values will be set to the default value.
        /// </summary>
        /// <param name="sender">string array</param>
        /// <returns>All elements in array as double</returns>
        public static double[] ToDoublePreserveArray(this string[] sender)
        {

            var doubleArray = Array.ConvertAll(sender, (input) =>
            {
                double.TryParse(input, out var doubleValue);
                return doubleValue;
            });

            return doubleArray;

        }

        #endregion

        #region decimal convert methods
        /// <summary>
        /// Determine if all string elements can represent decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static bool AllDecimal(this string[] sender) =>
            sender.All(item => decimal.TryParse(item, out var test));


        /// <summary>
        /// Convert values in array to decimal array discards non decimal values in array.
        /// </summary>
        /// <param name="sender">string array</param>
        /// <returns>All valid elements that are decimal discarding non decimal values</returns>
        public static decimal[] ToDecimalArray(this string[] sender)
        {

            var decimalArray = Array
                .ConvertAll(sender,
                    (input) => new
                    {
                        IsDecimal = decimal.TryParse(input, out var decimalValue),
                        Value = decimalValue
                    })
                .Where(result => result.IsDecimal)
                .Select(result => result.Value)
                .ToArray();

            return decimalArray;

        }
        /// <summary>
        /// Convert all values in array to decimal array where non decimal values will be set to the default value.
        /// </summary>
        /// <param name="sender">string array</param>
        /// <returns>All elements in array as decimal</returns>
        public static decimal[] ToDecimalPreserveArray(this string[] sender)
        {

            var decimalArray = Array.ConvertAll(sender, (input) =>
            {
                decimal.TryParse(input, out var decimalValue);
                return decimalValue;
            });

            return decimalArray;

        }

        #endregion

        #region float convert methods
        /// <summary>
        /// Determine if all string elements can represent float
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static bool AllFloat(this string[] sender) =>
            sender.All(item => float.TryParse(item, out var test));

        /// <summary>
        /// Convert values in array to float array discards non float values in array.
        /// </summary>
        /// <param name="sender">string array</param>
        /// <returns>All valid elements that are float discarding non float values</returns>
        public static float[] ToFloatArray(this string[] sender)
        {

            var floatArray = Array
                .ConvertAll(sender,
                    (input) => new
                    {
                        IsFloat = float.TryParse(input, out var floatValue),
                        Value = floatValue
                    })
                .Where(result => result.IsFloat)
                .Select(result => result.Value)
                .ToArray();

            return floatArray;

        }
        /// <summary>
        /// Convert all values in array to float array where non float values will be set to the default value.
        /// </summary>
        /// <param name="sender">string array</param>
        /// <returns>All elements in array as float</returns>
        public static float[] ToFloatPreserveArray(this string[] sender)
        {

            var floatArray = Array.ConvertAll(sender, (input) =>
            {
                float.TryParse(input, out var floatValue);
                return floatValue;
            });

            return floatArray;

        }

        #endregion

        #region short convert methods
        /// <summary>
        /// Determine if all string elements can represent decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static bool AllShort(this string[] sender) =>
            sender.All(item => short.TryParse(item, out var test));

        /// <summary>
        /// Convert values in array to short array discards non short values in array.
        /// </summary>
        /// <param name="sender">string array</param>
        /// <returns>All valid elements that are short discarding non short values</returns>
        public static short[] ToShortArray(this string[] sender)
        {

            var shortArray = Array
                .ConvertAll(sender,
                    (input) => new
                    {
                        IsShort = short.TryParse(input, out var shortValue),
                        Value = shortValue
                    })
                .Where(result => result.IsShort)
                .Select(result => result.Value)
                .ToArray();

            return shortArray;

        }
        /// <summary>
        /// Convert all values in array to short array where non short values will be set to the default value.
        /// </summary>
        /// <param name="sender">string array</param>
        /// <returns>All elements in array as short</returns>
        public static float[] ToShortPreserveArray(this string[] sender)
        {

            var shortArray = Array.ConvertAll(sender, (input) =>
            {
                float.TryParse(input, out var shortValue);
                return shortValue;
            });

            return shortArray;

        }

        #endregion

    }
}