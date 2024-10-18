using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BlagihIA.Sprint2.Task6.V14.Lib
{
    public class DataService : ISprint2Task6V14
    {
        public string FindDayName(int k, int d)
        {
            int z =  (( d + k - 1 - 1)  % 7 );

 
            switch(z)
            {
                case 0: d = 1; return "Понедельник"  ;
                case 1: return "Вторник";
                case 2: return "Среда";
                case 3: return "Четверг";
                case 4: return "Пятница";
                case 5: return "Суббота";
                case 6: return "Воскресенье";
                default:  return "Ошибка";
            }
        }
    }
}
