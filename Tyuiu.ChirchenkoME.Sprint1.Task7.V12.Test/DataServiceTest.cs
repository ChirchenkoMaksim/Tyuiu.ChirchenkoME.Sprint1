using Tyuiu.ChirchenkoME.Sprint1.Task7.V12.Lib;

namespace Tyuiu.ChirchenkoME.Sprint1.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateTest1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double wait = 45.000; 
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);             
        }
    }
}