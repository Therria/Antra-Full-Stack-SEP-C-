using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public static class Greeting
    {
        public static void GreetingWords(DateTime time)
        {
            /*
             6am - 12pm : morning
             12pm - 6pm : afternoon
             6pm - 10pm : evening
             10pm - 6am : night
             */
            int hour = time.Hour;
            if (hour >= 6 && hour < 12)
            {
                Console.WriteLine("Good Morning");
            }
            if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Good Afternoon");
            }
            if (hour >= 18 && hour < 22)
            {
                Console.WriteLine("Good Evening");
            }
            if (hour >= 22 || hour < 6)
            {
                Console.WriteLine("Good Night");
            }
        }
    }
}
