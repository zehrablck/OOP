using Microsoft.VisualBasic;

namespace _01.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Zehra");
            Console.WriteLine("Computer Engineering");
            Console.WriteLine("2024");
            Console.WriteLine("--------------------------");
            Console.WriteLine(DateAndTime.Now);
            Console.WriteLine("--------------------------");
            Console.Write("Enter a degree(°C):");
            double degree=double.Parse(Console.ReadLine());
            double fahrenheit = degree * 9 / 5 + 32;
            Console.WriteLine($"Fahrenheit={fahrenheit:F2}");
        }
    }
}
