using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ChirchenkoME.Sprint1.Task2.V7.Lib;

namespace Tyuiu.ChirchenkoME.Sprint1.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int radius = 25;
            var res = ds.CalculateSquareCircle(radius);
            Assert.AreEqual(1962.5, res);
        }
    }
}