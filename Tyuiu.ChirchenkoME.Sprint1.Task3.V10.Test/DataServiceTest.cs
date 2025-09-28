using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ChirchenkoME.Sprint1.Task3.V10.Lib;

    namespace Tyuiu.ChirchenkoME.Sprint1.Task3.V10.Test
    { 
        [TestClass]
        public class DataServiceTest
        {
            [TestMethod]
            public void ValidConvertToMoneyFormat()
            {
                DataService ds = new DataService();

                double number1 = 23.6;
                string wait1 = "23.6 руб. — это 23 руб. 60 коп.";
                string res1 = ds.NumberToMoney(number1);
                Assert.AreEqual(wait1, res1);
            }
        }
    }
