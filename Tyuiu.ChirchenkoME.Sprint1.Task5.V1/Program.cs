using System.Globalization;
using Tyuiu.ChirchenkoME.Sprint1.Task5.V1.Lib;

namespace Tyuiu.ChirchenkoME.Sprint1.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Чирченко М. Е. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                             *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #1                                                             *");
            Console.WriteLine("* Выполнил: Чирченко М. Е. | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                  *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y). *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double x1, y1, x2, y2;
        
            Console.WriteLine("Введите координаты первой точки:");
            x1 = ReadCoordinate("X1");
            y1 = ReadCoordinate("Y1");
        
            Console.WriteLine("Введите координаты второй точки:");
            x2 = ReadCoordinate("X2");
            y2 = ReadCoordinate("Y2");

            int result = ds.DistanceBetweenDots(x1, y1, x2, y2);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine($"Расстояние между точками: {result}");

            Console.ReadKey();
        }

        static double ReadCoordinate(string coordinateName)
        {
            double coordinate;
            bool isValidInput;

            do
            {
                Console.Write($"{coordinateName} = ");
                string input = Console.ReadLine();

                if (double.TryParse(input, NumberStyles.Any, CultureInfo.GetCultureInfo("ru-RU"), out coordinate) ||
                    double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out coordinate))
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

            return coordinate;
        }
    }
}