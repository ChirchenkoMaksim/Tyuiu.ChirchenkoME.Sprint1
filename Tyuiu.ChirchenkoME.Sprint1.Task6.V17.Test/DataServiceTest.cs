using Tyuiu.ChirchenkoME.Sprint1.Task6.V17.Lib;

namespace Tyuiu.ChirchenkoME.Sprint1.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidPalindromeWord()
        {
            DataService ds = new DataService();
            string value = "топот";
            bool wait = true;
            bool res = ds.CheckPalindrome(value);
            Assert.AreEqual(wait, res);            
        }
    }
}