namespace Task_3
{
    delegate void StringOperation(string str);

    internal class Program
    {
        static void Main(string[] args)
        {
            StringOperation operationDelegate = null;
            operationDelegate += RemoveSpaces;
            operationDelegate += ConvertToLowercase;
            operationDelegate += PrintLength;

            string text = "Hello, World!";
            operationDelegate(text);
        }

        static void RemoveSpaces(string str)
        {
            string result = str.Replace(" ", string.Empty);
            Console.WriteLine("String after removing spaces: " + result);
        }

        static void ConvertToLowercase(string str)
        {
            string result = str.ToLower();
            Console.WriteLine("String in lowercase: " + result);
        }

        static void PrintLength(string str)
        {
            int length = str.Length;
            Console.WriteLine("String length: " + length);
        }
    }
}