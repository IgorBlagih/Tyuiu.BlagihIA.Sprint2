using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BlagihIA.Sprint2.Task6.V14.Lib
{
    public class DataService : ISprint2Task6V14
    {
        public string FindDayName(int k, int d)
        {
            int z =( k -1)  % 7;
            d = 1;
            switch(z)
            {
                case 0: d = 1; return "понедельник"  ;
                case 1: return "вторник";
                case 2: return "среда";
                case 3: return "четверг";
                case 4: return "пятница";
                case 5: return "суббота";
                case 6: return "воскресенье";
                default:  throw new ArgumentException($"Неделя должна быть от 1 до 7. Значениe {d}");
            }
        }
    }
}
