namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
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

            Console.WriteLine("Результаты действий:");
            Console.WriteLine("Поменять местами первое и последнее слова: " + string.Join(" ", words));
            Console.WriteLine("Склеить второе и третье слова: " + string.Join(" ", words));
            Console.WriteLine("Третье слово в обратном порядке: " + thirdWordReversed);
            Console.WriteLine("В первом слове вырезаны первые две буквы: " + firstWordModified);

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