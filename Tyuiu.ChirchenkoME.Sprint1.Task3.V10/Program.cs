using System.Globalization;
using Tyuiu.ChirchenkoME.Sprint1.Task3.V10.Lib;

namespace Tyuiu.ChirchenkoME.Sprint1.Task3.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Чирченко М. Е. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: операторы составного присвоения                                  *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #10                                                            *");
            Console.WriteLine("* Выполнил: Чирченко М. Е. | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* аписать программу, которая преобразует введенное с клавиатуры          *");
            Console.WriteLine("* дробное число в денежный формат.*                                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double number;
            bool isValidInput = false;

            do
            {
                Console.Write("Введите дробное число -> ");
                string input = Console.ReadLine();


                if (double.TryParse(input, NumberStyles.Any, CultureInfo.GetCultureInfo("ru-RU"), out number) ||
                    double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out number))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Ошибка! Введите корректное дробное число");
                    Console.WriteLine();
                }
            } while (!isValidInput);

            string res = ds.NumberToMoney(number);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}