using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public static class Pyramid
    {
        public static void printPyramid(int totalLevel) 
        {
            for (int level = 1; level <= totalLevel; level++)
            {
                for (int i = 0; i < totalLevel - level; i++) 
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < level * 2 - 1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
