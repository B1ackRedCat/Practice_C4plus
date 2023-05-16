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

            // Ввод данных с клавиатуры
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("Введите данные для студента №" + (i + 1));

                Console.Write("Фамилия и инициалы: ");
                students[i].name = Console.ReadLine();

                Console.Write("Номер группы: ");
                students[i].groupNumber = int.Parse(Console.ReadLine());

                students[i].grades = new int[5];
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("Оценка " + (j + 1) + ": ");
                    students[i].grades[j] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine();
            }

            Console.WriteLine("Студенты, имеющие оценки 4 и 5:");

            bool found = false;

            // Вывод фамилий и номеров групп для студентов с оценками 4 и 5
            foreach (STUDENT student in students)
            {
                bool hasHighGrades = CheckHighGrades(student.grades);
                if (hasHighGrades)
                {
                    Console.WriteLine("Фамилия и инициалы: " + student.name);
                    Console.WriteLine("Номер группы: " + student.groupNumber);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Студенты с оценками 4 и 5 отсутствуют.");
            }

            Console.ReadLine();
        }

        // Функция для проверки наличия оценок 4 и 5
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