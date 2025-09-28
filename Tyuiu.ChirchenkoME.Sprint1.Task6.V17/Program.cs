using Tyuiu.ChirchenkoME.Sprint1.Task6.V17.Lib;

namespace Tyuiu.ChirchenkoME.Sprint1.Task6.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Чирченко М. Е. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Работа со строками класса String                                 *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #17                                                            *");
            Console.WriteLine("* Выполнил: Чирченко М. Е. | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что строка   *");
            Console.WriteLine("* является перевертышем.                                                 *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.Write("Введите текст для проверки: ");
            string inputText = Console.ReadLine();

            bool result = ds.CheckPalindrome(inputText);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            if (result)
                Console.WriteLine("Строка является перевертышем");
            else
                Console.WriteLine("Строка НЕ является перевертышем");

            Console.ReadKey();
        }
    }
}