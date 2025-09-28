using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ChirchenkoME.Sprint1.Task4.V15.Lib
{
    public class DataService : ISprint1Task4V15
    {
        public double Calculate(double x, double y)
        {       
            double numerator = x + Math.Pow(y, 2);         
            double denominator = Math.Exp(2 - 4 * y);
            double result = numerator / denominator;
     
            return Math.Round(result, 3);
        }
    }
}