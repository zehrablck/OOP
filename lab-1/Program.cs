using System.Threading.Channels;

namespace lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question-1

            Console.Write("What is your name?");
            string name = Console.ReadLine();
            Console.Write("Which city are you from?");
            string city = Console.ReadLine();
            Console.Write("What is your department?");
            string department = Console.ReadLine();
            Console.Write("Which year?");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name:{name}");
            Console.WriteLine($"City:{city}");
            Console.WriteLine($"Department:{department}");
            Console.WriteLine($"Year:{year}");
            Console.WriteLine("C# is fun");
            Console.WriteLine($"Hello {name} from {city},welcome to C#");

            #endregion
            #region Question-2

            Console.Write("First Number:");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Second Number:");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {(num1 / num2):F2}");

            #endregion
            #region Question-3

            Console.Write("Enter student name:");
            string name1 = Console.ReadLine();
            Console.Write("Enter midterm score:");
            int midterm = int.Parse(Console.ReadLine());
            Console.Write("Enter final grade:");
            int fınal = int.Parse(Console.ReadLine());
            double average = (midterm * 0.4) + (fınal * 0.6);
            Console.WriteLine($"{name1},your average is {average:F2}");
            if (average >= 50)
            {
                Console.WriteLine("Result:Passed");
                if (fınal == 100)
                {
                    Console.WriteLine("Perfect Final!");
                }
            }
            else
            {
                Console.WriteLine("Result=Failed");
            }

            #endregion
            #region Question-4

            Console.Write("Enter a 3-digit number:");
            int number=int.Parse(Console.ReadLine());
            int hundreds = (number / 100);
            int tens= (number % 100)/10;
            int ones = (number % 10);
            Console.WriteLine($"Hundreds:{hundreds}");
            Console.WriteLine($"Tens:{tens}");
            Console.WriteLine($"Ones:{ones}");
            Console.WriteLine($"Sum of digits:{hundreds+tens+ones}");
            if(number%2==0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
            if(hundreds==ones)
            {
                Console.WriteLine("First and last digits are equal.");
            }
            else
            {
                Console.WriteLine("First and last digits are different.");
            }

            #endregion
        }
    }
}
