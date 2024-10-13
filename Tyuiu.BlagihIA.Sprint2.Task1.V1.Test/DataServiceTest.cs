using Tyuiu.BlagihIA.Sprint2.Task1.V1.Lib;
namespace Tyuiu.BlagihIA.Sprint2.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds= new DataService();
            
            int a = 111;
            int b = 199;
            int c = 133;
            int d = 322;
            
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            
            bool[] wait = new bool[6] { true, false, true, false, true, false };
            
            CollectionAssert.AreEqual(wait, res);


        }
    }
}