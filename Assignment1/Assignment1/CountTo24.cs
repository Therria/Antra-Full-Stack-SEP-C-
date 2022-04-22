using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public static class CountTo24
    {
        public static void Count()
        {
            int max = 24;
            for (int step = 1; step <= 4; step++)
            {
                for (int i = 0; i <= max; i += step)
                {
                    Console.Write(i);
                    Console.Write(',');
                }
                Console.WriteLine();
            }
        }
    }
}
