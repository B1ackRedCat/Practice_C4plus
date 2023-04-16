namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Jon", 30);
            Employee employee = new Employee("Bane", 35, 10);
            Workman workman = new Workman("Ann", 20, "Office");
            Engineer engineer = new Engineer("Yan", 25, "Computer security");
            Console.WriteLine(person);
            Console.WriteLine(employee);
            Console.WriteLine(workman);
            Console.WriteLine(engineer);
        }
    }
}