using Tyuiu.BlagihIA.Sprint2.Task6.V14.Lib;
namespace Tyuiu.BlagihIA.Sprint2.Task6.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки  работы в С#                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                              *");
            Console.WriteLine("* Выполнил: Благих Игорь Александрович | ИИПб-24-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано целое число k (1 <= k <= 365). Определить, каким днем недели       *");
            Console.WriteLine("* (понедельником,вторником,…, субботой или воскресеньем) является k-й день*");
            Console.WriteLine("* не високосного года, в котором 1 января d-й день недели (если 1 января  *");
            Console.WriteLine("* — понедельник, то d = 1 , если вторник — d=2,…, если воскресенье—d=7).  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите день в году: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = 1;
            string res;
            if ((x < 1) || (x > 365))
            {
                res = "Неверно введен день";
            }
            else
            {
                res = "Это " + ds.FindDayName(x, y);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
        }
    }
}
