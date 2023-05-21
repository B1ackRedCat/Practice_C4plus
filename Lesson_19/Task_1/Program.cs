namespace Task_1
{
    internal class Program
    {
        public static string ProcessString(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '#')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(c); 
                }
            }
            return new string(stack.Reverse().ToArray());
        }

        static void Main(string[] args)
        {
            string s = "ho#w di##d i# fuc#k up";
            Console.WriteLine($"Sentence: {s} ");
            string result = ProcessString(s);
            Console.WriteLine($"Conversion result: {result}");
        }
    }
}