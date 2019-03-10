using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConverterLibrary;

namespace Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Throws an exception as an empty string can't be converted to an int.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void integerParseExampleButton1_Click(object sender, EventArgs e)
        {
            string someStringValue = "";
            int result = int.Parse(someStringValue);
            Console.WriteLine(result);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string someStringValue = "";
            int result = 0;

            if (int.TryParse(someStringValue, out result))
            {
                MessageBox.Show($"'{someStringValue}' converted");
            }
            else
            {
                MessageBox.Show($"'{someStringValue}' not converted");
            }

            someStringValue = "12";

            if (int.TryParse(someStringValue, out result))
            {
                MessageBox.Show($"'{someStringValue}' converted, value * 2 is {result *2}");
            }
            else
            {
                MessageBox.Show($"'{someStringValue}' not converted");
            }
        }

        private void integerTryParseOutVarExamplesButton1_Click(object sender, EventArgs e)
        {
            string someStringValue = "";

            if (int.TryParse(someStringValue, out var result1))
            {
                MessageBox.Show($"'{someStringValue}' converted");
            }
            else
            {
                MessageBox.Show($"'{someStringValue}' not converted");
            }

            someStringValue = "12";

            if (int.TryParse(someStringValue, out var result2))
            {
                MessageBox.Show($"'{someStringValue}' converted, value * 2 is  {result2 * 2}");
            }
            else
            {
                MessageBox.Show($"'{someStringValue}' not converted");
            }
        }
        /// <summary>
        /// Common solution found on the web
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stringArrayToIntArrayVersion1Button_Click(object sender, EventArgs e)
        {
            string[] stringArray = { "2", "4", "6", "8" };
            int[] intArray = Array.ConvertAll(stringArray, int.Parse);

            MessageBox.Show(string.Join(",", intArray));
        }

        private void stringArrayToIntArrayVersion2ThrowsExceptionButton_Click(object sender, EventArgs e)
        {
            string[] stringArray = { "2", "4B", "6", "8" };
            int[] intArray = Array.ConvertAll(stringArray, int.Parse);

            MessageBox.Show(string.Join(",", intArray));
        }
        /// <summary>
        /// C# 7
        /// When a element can not be converted 0 is used in it's place
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stringArrayToIntArrayVersion2NoExceptionButBadButton_Click(object sender, EventArgs e)
        {
            string[] stringArray = { "2", "4B", "6", "8" };
            var intArray = Array.ConvertAll(stringArray, item =>  
                int.TryParse(item, out var intResult) ? intResult : 0);

            MessageBox.Show(string.Join(",", intArray));

        }

        private void assertAllElementsCanBeConvertedButton_Click(object sender, EventArgs e)
        {
            string[] stringArray = { "2", "4B", "6", "8" };
            if (stringArray.SelectMany(item => item.ToCharArray()).All(char.IsNumber))
            {
                var intArray = Array.ConvertAll(stringArray, item =>
                    int.TryParse(item, out var intResult) ? intResult : 0);

                MessageBox.Show(string.Join(",", intArray));
            }
            else
            {
                MessageBox.Show("One or more elements can not be converted");
            }
        }
        /// <summary>
        /// See which elements in the string array can not be converted to integers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void assertAllElementsCanBeConvertedGetOffendersButton_Click(object sender, EventArgs e)
        {
            string[] stringArray = { "2", "4B", "6", "8A" };
            if (stringArray.SelectMany(item => item.ToCharArray()).All(char.IsNumber))
            {
                var intArray = Array.ConvertAll(stringArray, item =>
                    int.TryParse(item, out var intResult) ? intResult : 0);

                MessageBox.Show(string.Join(",", intArray));
            }
            else
            {
                var msg = "One or more elements can not be converted because of the following element indexes\n";

                MessageBox.Show($"{msg}{string.Join(", ", stringArray.GetNonIntegerIndexes())}");
            }
        }

        private void assertBeforeConvertGetOffendersExtensionsButton1_Click(object sender, EventArgs e)
        {
            string[] stringArray = { "2", "4B", "6", "8A" };

            if (stringArray.AllInt())
            {
                MessageBox.Show(string.Join(",", stringArray.ToIntegerPreserveArray()));
            }
            else
            {
                var msg = "One or more elements can not be converted because of the following element indexes\n";

                MessageBox.Show($"{msg}{string.Join(", ", stringArray.GetNonIntegerIndexes())}");
                MessageBox.Show($"But these did convert '{string.Join(",", stringArray.ToIntegerArray())}'");
            }


            stringArray = new[] { "2", "4", "6", "8" };

            if (stringArray.AllInt())
            {
                MessageBox.Show(string.Join(",", stringArray.ToIntegerPreserveArray()));
            }
            else
            {
                var msg = "One or more elements can not be converted because of the following element indexes\n";

                MessageBox.Show($"{msg}{string.Join(", ", stringArray.GetNonIntegerIndexes())}");
            }



        }

    }
}
