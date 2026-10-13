namespace _03.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Grade statistics program

            int count = 0;
            int sum = 0;
            Console.Write("Enter a grade(-1 to stop):");
            int grade = int.Parse(Console.ReadLine());
            int highest = grade;
            int lowest = grade;
            while (grade != -1)
            {
                count++;
                sum += grade;
                if(grade>highest)
                {
                  highest= grade;
                }
                if(grade<lowest)
                {
                  lowest= grade;
                }
 
                Console.Write("Enter a grade(-1 to stop):");
                grade = int.Parse(Console.ReadLine());
            }
           if(count==0)
            {
                highest = 0; 
                lowest = 0;
            }
            Console.WriteLine("-------------------------------------");
            if (count > 0)
            {
                Console.WriteLine($"Count:{count}");
                Console.WriteLine($"Sum:{sum}");
                Console.WriteLine($"Average:{((double)sum / count):F2}");
                Console.WriteLine($"Highest:{highest}");
                Console.WriteLine($"Lowest:{lowest}");
            }
            else
            {
                Console.WriteLine("Grade not entered.");
            }


            #endregion

            #region Multiplication table

            Console.Write("Enter a number(1-10):");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }

            #endregion
        }
    }
}
