using Tyuiu.BlagihIA.Sprint2.Task6.V14.Lib;
namespace Tyuiu.BlagihIA.Sprint2.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();
            int k = 1;
            int d = 1;
            string res = ds.FindDayName(k,d);
            string wait = "Понедельник";
            Assert.AreEqual(wait, res);
        }
    }
}