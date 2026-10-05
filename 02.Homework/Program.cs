using System.Runtime.InteropServices.Marshalling;

namespace _02.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Celcius-Kelvin-Fahrenheit

            Console.Write("Enter a Celsius value:");
            double celcius=double.Parse(Console.ReadLine());
            double kelvin = celcius + 273.15;
            double fahrenheit = (celcius * 9 / 5) + 32;
            Console.WriteLine($"Kelvin:{kelvin:F2}");
            Console.WriteLine($"Fahrenheit:{fahrenheit:F2}");

            #endregion
            #region Average

            Console.Write("Enter the grade-1:");
            int grade1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the grade-2:");
            int grade2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the grade-3:");
            int grade3 = int.Parse(Console.ReadLine());
            int sum = grade1 + grade2 + grade3;
            double average = sum / 3.0;
            Console.WriteLine($"Sum:{sum}");
            Console.WriteLine($"Average={average:F2}");
            if (average >= 60)
            {
                Console.WriteLine("Average is 60 or greater than 60");
            }
            else
            {
                Console.WriteLine("Average is less than 60");
            }

            #endregion
            #region 3-Digit

            Console.Write("Enter a 3-digit number:");
            int num = int.Parse(Console.ReadLine());
            int hundreds = num / 100;
            int tens = (num % 100) / 10;
            int ones = num % 10;
            Console.WriteLine(hundreds + "-" + tens + "-" + ones);

            #endregion
        }
    }
}
