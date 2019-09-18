using System;
using System.Globalization;
using System.Text;


namespace CurrencyFormatConverter
{
    class Program
    {
        static void Main()
        {
            Double userInput1, userInput2, userInput3, userInput4;
            Console.OutputEncoding = Encoding.UTF8;

            // Takes in 4 numbers from the user.
            Console.WriteLine("Please enter 4 numbers:");

            Console.Write("Number 1: ");
            userInput1 = Double.Parse(Console.ReadLine());

            Console.Write("Number 2: ");
            userInput2 = Double.Parse(Console.ReadLine());

            Console.Write("Number 3: ");
            userInput3 = Double.Parse(Console.ReadLine());

            Console.Write("Number 4: ");
            userInput4 = Double.Parse(Console.ReadLine());

            // Calculates the average of the 4 numbers and displays the average.
            Double result = (userInput1 + userInput2 + userInput3 + userInput4) / 4;
            Console.WriteLine("The average is: " + result);

            // Determines the largest number inputed
            if (userInput1 > userInput2 && userInput1 > userInput3 && userInput1 > userInput4)
            {
                Console.WriteLine("The largest number is: " + userInput1);
            }
            else if (userInput2 > userInput1 && userInput2 > userInput3 && userInput2 > userInput4)
            {
                Console.WriteLine("The largest number is: " + userInput2);
            }
            else if (userInput3 > userInput1 && userInput3 > userInput2 && userInput3 > userInput4)
            {
                Console.WriteLine("The largest number is: " + userInput3);
            }
            else
            {
                Console.WriteLine("The largest number is: " + userInput4);
            }

            // Determines the smallest number inputed
            if (userInput1 < userInput2 && userInput1 < userInput3 && userInput1 < userInput4)
            {
                Console.WriteLine("The smallest number is: " + userInput1);
            }
            else if (userInput2 < userInput1 && userInput2 < userInput3 && userInput2 < userInput4)
            {
                Console.WriteLine("The smallest number is: " + userInput2);
            }
            else if (userInput3 < userInput1 && userInput3 < userInput2 && userInput3 < userInput4)
            {
                Console.WriteLine("The smallest number is: " + userInput3);
            }
            else
            {
                Console.WriteLine("The smallest number is: " + userInput4);
            }

            Double totalAmount = (userInput1 + userInput2 + userInput3 + userInput4);

            string dollars = string.Format(CultureInfo.GetCultureInfo("en-US"), "{0:C}", totalAmount);
            Console.WriteLine("US: " + dollars);
            string swedish = string.Format(CultureInfo.GetCultureInfo("sv-SE"), "{0:C}", totalAmount);
            Console.WriteLine("Swedish: " + swedish);
            string japanese = string.Format(CultureInfo.GetCultureInfo("ja-JP"), "{0:C}", totalAmount);
            Console.WriteLine("Japanese: " + japanese);
            string thai = string.Format(CultureInfo.GetCultureInfo("th-TH"), "{0:C}", totalAmount);
            Console.WriteLine("Thai: " + thai, Console.OutputEncoding);


        }
    }
}



