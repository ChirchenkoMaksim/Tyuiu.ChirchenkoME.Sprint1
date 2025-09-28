using Tyuiu.ChirchenkoME.Sprint1.Task4.V15.Lib;

namespace Tyuiu.ChirchenkoME.Sprint1.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 2017.144;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);              
        }
    }
}