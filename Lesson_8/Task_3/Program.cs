using System.Text.RegularExpressions;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "данное предложение, содержит запятую. здесь - есть тире. тут ничего нет. в этом (как видите) скобки. тут снова ничего нет.";

            string[] sentences = GetSentencesWithPunctuation(text);

            if (sentences.Length > 0)
            {
                Console.WriteLine("Sentences containing punctuation marks:");
                foreach (string sentence in sentences)
                    Console.WriteLine(sentence);
            }
            else
                Console.WriteLine("There are no sentences in the text with the specified punctuation marks.");

            Console.ReadLine();
        }

        static string[] GetSentencesWithPunctuation(string text)
        {
            string[] sentences = Regex.Split(text, @"(?<=[.?!])");

            string[] sentencesWithPunctuation = Array.FindAll(sentences, sentence =>
                Regex.IsMatch(sentence, @"[,;:\-\(\)""']"));

            return sentencesWithPunctuation;
        }
    }
}