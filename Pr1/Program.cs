using System.Security.Cryptography.X509Certificates;

namespace Pr1
{
    internal class Program
    {
        public delegate bool Validator(string text);

        public static Validator GetValidator(int minLength)
        {
            return text => text.Length >= minLength;
        }
        static void Main(string[] args)
        {
            Validator loginValidator = GetValidator(3);
            Validator passwordValidator = GetValidator(8);

            Console.WriteLine("--- Перевiрка логiнiв (мiн. 3 символи) ---");
            string login1 = "ab";
            string login2 = "admin";
            Console.WriteLine($"'{login1}' -> {loginValidator(login1)}"); 
            Console.WriteLine($"'{login2}' -> {loginValidator(login2)}"); 

            Console.WriteLine("\n--- Перевiрка паролiв (мiн. 8 символiв) ---");
            string pass1 = "1234567";
            string pass2 = "SuperSecret8!";
            Console.WriteLine($"'{pass1}' -> {passwordValidator(pass1)}"); 
            Console.WriteLine($"'{pass2}' -> {passwordValidator(pass2)}");

            /*Task1 task1 = new Task1();
            task1.Example(); Console.WriteLine();*/

            /*Task2 task2 = new Task2();
            task2.Example(); Console.WriteLine();*/

            /*Task3 task3 = new Task3();
            task3.Example(); Console.WriteLine();*/

            /*Task4 task4 = new Task4();
            task4.Example(); Console.WriteLine();*/

            /*Logger logger = new Logger();

            logger.LogHandler = message => Console.WriteLine($"Звичайний лог: {message}");
            Console.WriteLine("Стандартний режим:");
            logger.Log("Програму запущено успішно.");
            logger.Log("Завантаження даних...");

            Console.WriteLine("\n--- Змінюємо налаштування логера ---");
            logger.LogHandler = message => Console.WriteLine($"УВАГА: {message.ToUpper()}");
            logger.Log("Зв'язок з сервером втрачено!");
            logger.Log("Спроба перепідключення...");*/
        }
    }
}
