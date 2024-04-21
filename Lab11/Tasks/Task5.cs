namespace Lab11
{
    internal class Task5
    {
        public static void Tass5()
        {
            Console.WriteLine("Введіть шлях до файлу:");
            string filePath = Console.ReadLine();

            Console.WriteLine("Введіть слово для пошуку:");
            string searchWord = Console.ReadLine();

            SearchWord(filePath, searchWord);

            int wordCount = CountOccurrences(filePath, searchWord);
            Console.WriteLine($"Кількість входжень слова '{searchWord}': {wordCount}");

            string reversedWord = ReverseString(searchWord);
            int reversedWordCount = CountOccurrences(filePath, reversedWord);
            Console.WriteLine($"Кількість входжень слова '{reversedWord}' у зворотному напрямку: {reversedWordCount}");
        }

        static void SearchWord(string filePath, string searchWord)
        {
            string[] lines = File.ReadAllLines(filePath);
            bool wordFound = false;

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(searchWord))
                {
                    Console.WriteLine($"Слово '{searchWord}' знайдено на рядку {i + 1}.");
                    wordFound = true;
                }
            }

            if (!wordFound)
            {
                Console.WriteLine($"Слово '{searchWord}' не знайдено у файлі.");
            }
        }

        static int CountOccurrences(string filePath, string word)
        {
            string text = File.ReadAllText(filePath);
            int count = 0;
            int index = 0;

            while ((index = text.IndexOf(word, index)) != -1)
            {
                index += word.Length;
                count++;
            }

            return count;
        }

        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
