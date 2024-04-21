namespace Lab11
{
    internal class Task1
    {
        public static void Tas1()
        {
            Console.WriteLine("Введіть шлях до файлу:");
            string filePath = Console.ReadLine();

            if (File.Exists(filePath))
            {
                string fileContents = File.ReadAllText(filePath);
                Console.WriteLine("Зміст файлу:");
                Console.WriteLine(fileContents);
            }
            else
            {
                Console.WriteLine("Помилка: Файл не існує.");
            }
        }
    }
}
