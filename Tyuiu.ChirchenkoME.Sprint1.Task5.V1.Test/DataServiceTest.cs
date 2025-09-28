using Tyuiu.ChirchenkoME.Sprint1.Task5.V1.Lib;

namespace Tyuiu.ChirchenkoME.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDistanceBetweenDots()
        {
            DataService ds = new DataService();
            double x1 = 1;
            double y1 = 1;
            double x2 = 4;
            double y2 = 5;
            int wait = 5; 
            int res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Assert.AreEqual(wait, res);
        }
    }
}