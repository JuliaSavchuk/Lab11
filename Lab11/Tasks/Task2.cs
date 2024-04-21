namespace Lab11
{
    internal class Task2
    {
        public static void Tass2()
        {

            int[] array;
            string filePath = "array.txt";

            Console.WriteLine("Введіть розмірність масиву:");
            int size = Convert.ToInt32(Console.ReadLine());
            array = new int[size];

            Console.WriteLine("Введіть елементи масиву:");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Елемент {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            SaveArrayToFile(array, filePath);

            int[] loadedArray = LoadArrayFromFile(filePath);

            Console.WriteLine("Масив успішно збережено та завантажено з файлу.");
            Console.WriteLine("Завантажений масив:");
            foreach (int num in loadedArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
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

        static int[] LoadArrayFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int[] loadedArray = new int[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                loadedArray[i] = Convert.ToInt32(lines[i]);
            }

            return loadedArray;
        }
    }
}
