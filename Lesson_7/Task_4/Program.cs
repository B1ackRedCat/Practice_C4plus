namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first name, last name and middle name (separated by a space):");
            string[] nameParts = Console.ReadLine().Split(' ');

            if (nameParts.Length < 3)
            {
                Console.WriteLine("Error: you must enter the first name, last name and middle name!");
                Console.ReadLine();
                return;
            }

            string firstName = nameParts[0];
            string lastName = nameParts[1];
            string middleName = nameParts[2];

            string fullName = lastName + firstName + middleName;

            int personalCode = CalculatePersonalCode(fullName);

            Console.WriteLine("Personality code: " + personalCode);

            Console.ReadLine();
        }

        static int CalculatePersonalCode(string fullName)
        {
            int sum = 0;

            foreach (char c in fullName)
            {
                if (char.IsLetter(c))
                {
                    int letterValue = char.ToUpper(c) - 'А' + 1; 
                    sum += letterValue;
                }
            }

            while (sum >= 10)
            {
                int newSum = 0;
                while (sum > 0)
                {
                    newSum += sum % 10;
                    sum /= 10;
                }
                sum = newSum;
            }

            return sum;
        }
    }
}