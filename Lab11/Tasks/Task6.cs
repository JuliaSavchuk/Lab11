namespace Lab11
{
    internal class Task6
    {
        public static void Tass6()
        {
            Console.WriteLine("Введіть шлях до файлу:");
            string filePath = Console.ReadLine();

            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                int sentenceCount = CountSentences(fileContent);
                int uppercaseCount = CountUppercaseLetters(fileContent);
                int lowercaseCount = CountLowercaseLetters(fileContent);
                int vowelCount = CountVowels(fileContent);
                int consonantCount = CountConsonants(fileContent);
                int digitCount = CountDigits(fileContent);

                Console.WriteLine($"Кількість речень: {sentenceCount}");
                Console.WriteLine($"Кількість великих літер: {uppercaseCount}");
                Console.WriteLine($"Кількість маленьких літер: {lowercaseCount}");
                Console.WriteLine($"Кількість голосних літер: {vowelCount}");
                Console.WriteLine($"Кількість приголосних літер: {consonantCount}");
                Console.WriteLine($"Кількість цифр: {digitCount}");
            }
            else
            {
                Console.WriteLine("Помилка: Файл не існує.");
            }
        }

        static int CountSentences(string text)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (c == '.' || c == '?' || c == '!')
                {
                    count++;
                }
            }
            return count;
        }

        static int CountUppercaseLetters(string text)
        {

            int count = 0;
            foreach (char c in text)
            {
                if (char.IsUpper(c))
                {
                    count++;
                }
            }
            return count;
        }

        static int CountLowercaseLetters(string text)
        {

            int count = 0;
            foreach (char c in text)
            {
                if (char.IsLower(c))
                {
                    count++;
                }
            }
            return count;
        }

        static int CountVowels(string text)
        {

            int count = 0;
            string vowels = "aeiouAEIOU";
            foreach (char c in text)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }
            return count;
        }

        static int CountConsonants(string text)
        {

            int count = 0;
            string consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
            foreach (char c in text)
            {
                if (consonants.Contains(c))
                {
                    count++;
                }
            }
            return count;
        }

        static int CountDigits(string text)
        {

            int count = 0;
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
