using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BlagihIA.Sprint2.Task1.V1.Lib
{
    public class DataService : ISprint2Task1V1
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a < b) | (c != d);
            res[1] = (b >= a) & (c == d);
            res[2] = (a != c - 554) || (b <= d);
            res[3] = (d <= a) && (c == b+1);
            res[4] = !(a == c);
            res[5] = (a != b) ^ (c + 1000 > d );
            return res;
        }
    }
}
