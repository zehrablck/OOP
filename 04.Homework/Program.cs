namespace _04.Homework
{
    internal class Program
    {
        static double Average(double[] t)
        {
            double sum = 0;
            foreach (double temp in t)
            {
                sum += temp;
            }
            return sum / (t.Length);
        }
        static void PrintHottestDay(double[] t)
        {
            int hottestDayIndex = 0;
            double maxTemp = t[0];

            for (int i = 1; i < t.Length; i++)
            {
                if (t[i] > maxTemp)
                {
                    maxTemp = t[i];
                    hottestDayIndex = i;
                }
            }
            Console.WriteLine($"Hottest Day: {hottestDayIndex + 1} with {maxTemp}°C");
        }
        static void PrintAboveAverage(double[] t, double avg)
        {
            Console.WriteLine("Above average:");
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] > avg)
                {
                    Console.WriteLine($"   Day {i + 1}: {t[i]}°C");
                }
            }
        }
        static void PrintLastThreeDays(double[] t)
        {
            Console.WriteLine("Last three days:");
            double[] lastThreeDays = t[^3..];
            foreach (double temp in lastThreeDays)
            {
                Console.WriteLine($"   {temp}°C");
            }
        }
        static void Main(string[] args)
        {
            double[] week = [14.2, 17.5, 19.0, 16.8, 21.3, 22.7, 18.4];
            double avg = Average(week);
            Console.WriteLine($"Average: {avg:F1}");

            Console.WriteLine("-------------------------------------");

            PrintHottestDay(week);

            Console.WriteLine("-------------------------------------");

            PrintAboveAverage(week, avg);

            Console.WriteLine("-------------------------------------");

            PrintLastThreeDays(week);

            Console.WriteLine("-------------------------------------");
        }
    }
}
