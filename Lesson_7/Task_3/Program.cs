namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an offer:");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            string firstWord = words[0];
            string lastWord = words[words.Length - 1];
            words[0] = lastWord;
            words[words.Length - 1] = firstWord;

            string secondWord = words[1];
            string thirdWord = words[2];
            words[1] = secondWord + thirdWord;

            string thirdWordReversed = ReverseString(words[2]);

            string firstWordModified = firstWord.Substring(2);

            Console.WriteLine("Results of actions:");
            Console.WriteLine("Swap first and last words: " + string.Join(" ", words));
            Console.WriteLine("Glue the second and third words: " + string.Join(" ", words));
            Console.WriteLine("Third word in reverse order: " + thirdWordReversed);
            Console.WriteLine("The first two letters of the first word are cut out: " + firstWordModified);

            Console.ReadLine();
        }

        static string ReverseString(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}