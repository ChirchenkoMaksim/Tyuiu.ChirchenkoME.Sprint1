using System.Globalization;
using Tyuiu.ChirchenkoME.Sprint1.Task7.V12.Lib;

namespace Tyuiu.ChirchenkoME.Sprint1.Task7.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Чирченко М. Е. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту               *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #12                                                            *");
            Console.WriteLine("* Выполнил: Чирченко М. Е. | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по     *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем.                    *");
            Console.WriteLine("* Формула: z = ((x+1)/(x-1))^x + 18xy^2                                 *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                            *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double x, y;

            // Ввод X
            x = ReadNumber("X");

            // Ввод Y
            y = ReadNumber("Y");

            try
            {
                double result = ds.Calculate(x, y);

                Console.WriteLine("**************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
                Console.WriteLine("**************************************************************************");
                Console.WriteLine($"z = {result:F3}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("**************************************************************************");
                Console.WriteLine("* ОШИБКА:                                                                *");
                Console.WriteLine("**************************************************************************");
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        static double ReadNumber(string variableName)
        {
            double number;
            bool isValidInput;

            do
            {
                Console.Write($"Введите значение {variableName}: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, NumberStyles.Any, CultureInfo.GetCultureInfo("ru-RU"), out number) ||
                    double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out number))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Ошибка! Введите корректное число");
                    Console.WriteLine();
                    isValidInput = false;
                }
            } while (!isValidInput);

            return number;
        }
    }
}