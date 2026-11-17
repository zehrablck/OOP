namespace _05._2.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course[] courses = new Course[5];

            courses[0] = new Course("CENG211", "Object Oriented Programming", 4);
            courses[1] = new Course("MATH201", "Linear Algebra", 5);
            courses[2] = new Course("EE243", "Circuit Analysis", 4);
            courses[3] = new Course("CENG205", "Data Structures", 6);
            courses[4] = new Course("CENG101", "Introduction to Programming", 3);

            Console.WriteLine("All Courses:");

            foreach (Course course in courses)
            {
                Console.WriteLine("-"+course.Info());
            }

            int totalCredits = 0;

            foreach (Course course in courses)
            {
                totalCredits += course.Credits;
            }

            Console.WriteLine();
            Console.WriteLine("Total Credits: " + totalCredits);

            string[] courseNames = new string[courses.Length];

            for (int i = 0; i < courses.Length; i++)
            {
                courseNames[i] = courses[i].Name;
            }

            Array.Sort(courseNames);

            Console.WriteLine();
            Console.WriteLine("Courses in Alphabetical Order:");

            foreach (string name in courseNames)
            {
                Console.WriteLine("-"+name);
            }
        }

        class Course
        {
            public string Code { get; init; }
            public string Name { get; set; }

            private int credits;

            public int Credits
            {
                get { return credits; }
                set
                {
                    if (value >= 1 && value <= 10)
                    {
                        credits = value;
                    }
                    else
                    {
                        credits = 1;
                    }
                }
            }

            public Course(string code, string name, int credits)
            {
                Code = code;
                Name = name;
                Credits = credits;
            }

            public string Info()
            {
                return Code + " " + Name + " (" + Credits + " cr)";
            }
        }

    }
}
