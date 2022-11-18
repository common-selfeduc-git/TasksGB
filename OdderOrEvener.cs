using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksGB
{
    internal class OdderOrEvener
    {
        public void Solve()
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0) { Console.WriteLine($"{a} является чётным."); }
            else { Console.WriteLine($"{a} не является чётным."); }
        }
    }
}
