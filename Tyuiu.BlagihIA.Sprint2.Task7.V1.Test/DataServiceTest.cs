using Tyuiu.BlagihIA.Sprint2.Task7.V1.Lib;
namespace Tyuiu.BlagihIA.Sprint2.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0.3;
            double y = 0.3;

            bool res  = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}