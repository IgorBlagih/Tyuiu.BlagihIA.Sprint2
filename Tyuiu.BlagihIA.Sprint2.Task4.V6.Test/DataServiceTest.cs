using Tyuiu.BlagihIA.Sprint2.Task4.V6.Lib;
namespace Tyuiu.BlagihIA.Sprint2.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();    
            double x = 1;
            double y = 11;
            double res = ds.Calculate(x, y);
            double wait = 6;
            Assert.AreEqual(wait, res);

        }


        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 8;
            Assert.AreEqual(wait, res);
        }
    }
}