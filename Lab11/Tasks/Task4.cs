namespace Lab11
{
    internal class Task4
    {
       public static void Tass4()
        {
            Random random = new Random();
            int[] numbers = new int[10000];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 1000);
            }
            int[] evenNumbers = Array.FindAll(numbers, num => num % 2 == 0);
            int[] oddNumbers = Array.FindAll(numbers, num => num % 2 != 0);

            SaveArrayToFile(evenNumbers, "even_numbers.txt");
            SaveArrayToFile(oddNumbers, "odd_numbers.txt");

            Console.WriteLine($"Загальна кількість чисел: {numbers.Length}");
            Console.WriteLine($"Кількість парних чисел: {evenNumbers.Length}");
            Console.WriteLine($"Кількість непарних чисел: {oddNumbers.Length}");
        }

        static void SaveArrayToFile(int[] array, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (int num in array)
                {
                    writer.WriteLine(num);
                }
            }
        }
    }
}
