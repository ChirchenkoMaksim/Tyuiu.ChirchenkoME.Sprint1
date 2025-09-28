using System;
using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.ChirchenkoME.Sprint1.Task2.V7.Lib;
namespace Tyuiu.ChirchenkoME.Sprint1.Task2.V7.Lib
{
    public class DataService : ISprint1Task2V7
    {
        public double CalculateSquareCircle(int value)
        {
            double radius = value;
            double area = Math.PI * radius * radius;
            return Math.Round(area, 3);
        }
    }
}