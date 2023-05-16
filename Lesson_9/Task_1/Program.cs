namespace Task_1
{
    struct STUDENT
    {
        public string name;
        public int groupNumber;
        public int[] grades;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            const int numberOfStudents = 5;

            STUDENT[] students = new STUDENT[numberOfStudents];

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("Enter student details №" + (i + 1));

                Console.Write("Surname and initials: ");
                students[i].name = Console.ReadLine();

                Console.Write("Group number: ");
                students[i].groupNumber = int.Parse(Console.ReadLine());

                students[i].grades = new int[5];
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("Grade " + (j + 1) + ": ");
                    students[i].grades[j] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine();
            }

            Console.WriteLine("Students with grades 4 and 5:");

            bool found = false;

            foreach (STUDENT student in students)
            {
                bool hasHighGrades = CheckHighGrades(student.grades);
                if (hasHighGrades)
                {
                    Console.WriteLine("Surname and initials: " + student.name);
                    Console.WriteLine("Group number: " + student.groupNumber);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("There are no students with grades 4 and 5.");
            }

            Console.ReadLine();
        }

        static bool CheckHighGrades(int[] grades)
        {
            int count = 0;
            foreach (int grade in grades)
            {
                if (grade == 4 || grade == 5)
                {
                    count++;
                }
            }
            if (count == 5)
                return true;
            else
                return false;
        }
    }
}