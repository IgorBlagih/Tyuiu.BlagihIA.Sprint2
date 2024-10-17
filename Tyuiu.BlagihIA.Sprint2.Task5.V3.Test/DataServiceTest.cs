using Tyuiu.BlagihIA.Sprint2.Task5.V3.Lib;
namespace Tyuiu.BlagihIA.Sprint2.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFirstDayName()
        {
            DataService ds = new DataService();
            int x = 1;  
            string res = ds.FindDayName(x);
            string wait = "Понедельник";
            Assert.AreEqual(wait, res);
        }
    }
}