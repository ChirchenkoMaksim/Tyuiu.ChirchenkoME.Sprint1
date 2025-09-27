using System;
using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.ChirchenkoME.Sprint1.Task2.V10.Lib;

namespace Tyuiu.ChirchenkoME.Sprint1.Task2.V10.Lib
{
    public class DataService : ISprint1Task2V10
    {
        public double ConvertMetreToInchs(int value)
        {
            throw new NotImplementedException();
        }

        public string ConvertNumberToMoney(double number)
        {
            int rubles = (int)number;
            int kopecks = (int)Math.Round((number - rubles) * 100);

            if (kopecks >= 100)
            {
                rubles += 1;
                kopecks -= 100;
            }

            return $"{number} руб. — это {rubles} руб. {kopecks:D2} коп.";
        }
    }
}