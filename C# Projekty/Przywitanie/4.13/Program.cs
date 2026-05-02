using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "To jest przykładowy tekst. to Tekst ten jest przykładem tekstu, który ma powtarzające się słowa.";
            AnalyzeText(text);
            Console.ReadKey();
        }

        static void AnalyzeText(string text)
        {
            // Usunięcie znaków interpunkcyjnych i zamiana na małe litery
            char[] delimiters = new char[] { ' ', '.', ','};
            string[] words = text.ToLower().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            // Zliczanie wystąpień słów
            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            // Wyświetlenie wyników
            Console.WriteLine("Wielokrotne występowanie słów w tekście:");
            foreach (var item in wordCount)
            {
                if (item.Value > 1)
                {
                    Console.WriteLine($"Słowo: '{item.Key}' - Wystąpienia: {item.Value}");
                }
            }
        }
    }
}
