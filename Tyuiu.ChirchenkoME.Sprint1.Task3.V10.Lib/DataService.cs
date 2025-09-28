using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ChirchenkoME.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {

            double rounded = Math.Round(number, 2);
            int rubles = (int)rounded;
            int kopecks = (int)Math.Round((rounded - rubles) * 100);


            if (kopecks >= 100)
            {
                rubles += 1;
                kopecks = 0;
            }

            return $"{number.ToString(CultureInfo.InvariantCulture)} руб. — это {rubles} руб. {kopecks:D2} коп.";            
        }
    }
}