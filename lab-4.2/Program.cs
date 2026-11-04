namespace lab_4._2
{
    internal class Program
    {
        static double CalculateAverage(int grade1,int grade2)
        {
            int total = grade1 + grade2;
            double average = total / 2.0;
            return average;
        }
        static double CalculateAverage(int grade1, int grade2,int grade3)
        {
            int total = grade1 + grade2+grade3;
            double average = total / 3.0;
            return average;
        }
        static double CalculateAverage(int[] grades)
        {
            double total = 0;
            foreach (int grade in grades)
            {
                total += grade;
            }
            double average = total / grades.Length;
            return average;
        }
        static int CalculateTotal(params int[] grades)
        {
            int total = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                total += grades[i];
            }
            return total;
        }
        static void Main(string[] args)
        {
            int[] grades = { 75, 90, 45, 60, 85, 30, 95, 70 };

            Console.WriteLine(CalculateAverage(70,90));
            Console.WriteLine(CalculateAverage(60,75,90));
            Console.WriteLine(CalculateAverage(grades));

            Console.WriteLine("-----------------------------");

            Console.WriteLine(CalculateTotal(10,20));
            Console.WriteLine(CalculateTotal(10,20,30));
            Console.WriteLine(CalculateTotal(grades));
            Console.WriteLine(CalculateTotal());

            Console.Write("-----------------------------");
        }
    }
}
