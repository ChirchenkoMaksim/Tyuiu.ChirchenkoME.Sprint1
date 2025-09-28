using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ChirchenkoME.Sprint1.Task7.V12.Lib
{
    public class DataService : ISprint1Task7V12
    {
        public double Calculate(double x, double y)
        {
    
            if (Math.Abs(x - 1) < double.Epsilon)
                throw new ArgumentException("(деление на ноль)");
          
            double firstPart = Math.Pow((x + 1) / (x - 1), x);      
            double secondPart = 18 * x * Math.Pow(y, 2);       
            double result = firstPart + secondPart;
            return Math.Round(result, 3);
        }
    }
}