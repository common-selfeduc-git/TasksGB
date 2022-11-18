using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksGB
{
    public class Comparator
    {        
        public void Compare(int value1, int value2)
        {
            if (value1 > value2)
            {
                Console.WriteLine($"{value1} больше {value2}");
            } else
            {
                Console.WriteLine($"{value2} больше {value1}");
            } 
        }
        public void Compare(int value1, int value2, int value3)
        {
            int max = 0;
            if (value1 > value2) { max = value1; } else { max = value2; }
            if (max < value3) { max = value3; }
            Console.WriteLine(max);
        }
    }
}
