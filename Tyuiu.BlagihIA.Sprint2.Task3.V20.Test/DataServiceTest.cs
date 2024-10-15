using Tyuiu.BlagihIA.Sprint2.Task3.V20.Lib;
namespace Tyuiu.BlagihIA.Sprint2.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x) ;
            double wait = 2;
            Assert.AreEqual(wait, res);
             
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(wait, res);
        }



        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();
            double x = -25;
            double res = ds.Calculate(x);
            double wait = -274.96;
            Assert.AreEqual(wait, res);
        }



        [TestMethod]
        public void ValidCalculate4()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 18;
            Assert.AreEqual(wait, res);
        }


    }
}