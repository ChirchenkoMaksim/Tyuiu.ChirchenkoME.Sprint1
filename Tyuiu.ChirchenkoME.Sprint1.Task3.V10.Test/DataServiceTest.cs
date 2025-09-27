using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ChirchenkoME.Sprint1.Task2.V10.Lib;

namespace Tyuiu.ChirchenkoME.Sprint1.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 23.6;
            string wait = "23.6 руб. — это 23 руб. 60 коп.";
            var res = ds.ConvertNumberToMoney(x);
            Assert.AreEqual(wait, res);
        }
    }
}