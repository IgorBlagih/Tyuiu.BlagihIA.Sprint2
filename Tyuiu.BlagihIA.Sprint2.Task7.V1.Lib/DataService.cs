using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BlagihIA.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (y == Math.Sqrt(Math.Pow(x, 2))))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
