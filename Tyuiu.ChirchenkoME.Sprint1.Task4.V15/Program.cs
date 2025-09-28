using System.Globalization;
using Tyuiu.ChirchenkoME.Sprint1.Task4.V15.Lib;

namespace Tyuiu.ChirchenkoME.Sprint1.Task4.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Чирченко М. Е. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Class Math                                                       *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #15                                                            *");
            Console.WriteLine("* Выполнил: Чирченко М. Е. | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,*");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.               *");
            Console.WriteLine("* Формула: ((x+y)^2) / (e^(x^2-4y))                                      *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double x, y;
            bool isValidInput = false;

         
            do
            {
                Console.Write("Введите значение X: ");
                string inputX = Console.ReadLine();

                if (double.TryParse(inputX, NumberStyles.Any, CultureInfo.GetCultureInfo("ru-RU"), out x) ||
                    double.TryParse(inputX, NumberStyles.Any, CultureInfo.InvariantCulture, out x))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Введите корректное число для X");
                    Console.WriteLine();
                }
            } while (!isValidInput);

            isValidInput = false;

    
            do
            {
                Console.Write("Введите значение Y: ");
                string inputY = Console.ReadLine();

                if (double.TryParse(inputY, NumberStyles.Any, CultureInfo.GetCultureInfo("ru-RU"), out y) ||
                    double.TryParse(inputY, NumberStyles.Any, CultureInfo.InvariantCulture, out y))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Введите корректное число для Y");
                    Console.WriteLine();
                }
            } while (!isValidInput);

            double result = ds.Calculate(x, y);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine($"Результат: {result:F3}");

            Console.ReadKey();
        }
    }
}