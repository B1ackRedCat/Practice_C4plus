namespace Task_4
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Photographer photographer = new Photographer("Ivan Ivanov");

            Subscriber1 subscriber1 = new Subscriber1("Petr");
            Subscriber2 subscriber2 = new Subscriber2("Sergey");
            photographer.Pub(true);
            if (true)
            {
                photographer.Attach(subscriber1);
                photographer.Attach(subscriber2);
            }
            else
            {
                photographer.Detach(subscriber1);
                photographer.Detach(subscriber2);
            }
        }
    }
}