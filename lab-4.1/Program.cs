namespace lab_4
{
    internal class Program
    {
        static double CalculateAverage(int[] grades)
        {
            double total = 0;
            foreach(int grade in grades)
            {
                total += grade;
            }
            double average = total / grades.Length;
            return average;
        }
        static int FindMaximum(int[] grades)
        {
            int max = grades[0];
            for(int i=1;i<grades.Length;i++)
            {
                if(grades[i] > max)
                {
                    max= grades[i];
                }
            }
            return max;
        }
        static int FindMinimum(int[] grades)
        {
            int min = grades[0];
            for (int i = 1; i < grades.Length; i++)
            {
                if (grades[i] < min)
                {
                    min = grades[i];
                }
            }
            return min;

        }
        static void Main(string[] args)
        {
            int[] grades = { 75, 90, 45, 60, 85, 30, 95, 70 };
            for (int i=0;i<grades.Length;i++)
            {
                Console.WriteLine($"Student {i+1}: {grades[i]}");
            }

            Console.WriteLine("----------------------------");

            Console.WriteLine($"Average Grade: {CalculateAverage(grades)}");
            Console.WriteLine($"Highest Grade: {FindMaximum(grades)}");
            Console.WriteLine($"Lowest Grade: {FindMinimum(grades)}");

            Console.WriteLine("----------------------------");
        }
    }
}
