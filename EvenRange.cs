using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksGB
{
    internal class EvenRange
    {
        public void Print(int a)
        {
            int i = 2;
            while (i <= a)
            {
                if (i % 5 == 0) Console.WriteLine();
                Console.Write($"| \t{i} | ");
                i = i + 2;
            }
            Console.WriteLine();
        }
    }
}
