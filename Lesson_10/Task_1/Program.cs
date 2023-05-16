namespace Task_1
{
    interface Ix
    {
        void IxF0(double parameter);
        void IxF1();
    }

    interface Iy
    {
        void F0(double parameter);
        void F1();
    }

    interface Iz
    {
        void F0(double parameter);
        void F1();
    }

    class TestClass : Ix, Iy, Iz
    {
        private double w;

        public TestClass(double w)
        {
            this.w = w;
        }

        // Неявная реализация интерфейсов Ix и Iy
        public void IxF0(double parameter)
        {
            Console.WriteLine($"IxF0: {Math.Cos(w)}");
        }

        public void IxF1()
        {
            Console.WriteLine($"IxF1: {Math.Cos(w)}");
        }

        public void F0(double parameter)
        {
            Console.WriteLine($"F0: {Math.Exp(w)}");
        }

        public void F1()
        {
            Console.WriteLine($"F1: {Math.Exp(w)}");
        }

        // Явная реализация интерфейса Iz
        void Iz.F0(double parameter)
        {
            Console.WriteLine($"F0 (Iz): {1 / Math.Exp(w)}");
        }

        void Iz.F1()
        {
            Console.WriteLine($"F1 (Iz): {1 / Math.Exp(w)}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double w = 2.0;

            TestClass test = new TestClass(w);

            // Вызов методов с явным приведением к типу интерфейса
            ((Ix)test).IxF0(w);
            ((Iy)test).F0(w);
            ((Iz)test).F0(w);

            Console.WriteLine();

            // Вызов методов для объекта посредством интерфейсной ссылки
            Ix ix = test;
            ix.IxF1();

            Iy iy = test;
            iy.F1();

            Iz iz = test;
            iz.F1();

            Console.ReadLine();
        }
    }
}