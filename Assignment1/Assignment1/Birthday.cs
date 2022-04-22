using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public static class Birthday
    {
        public static void CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            TimeSpan diff = today - birthDate;
            double ageInDays = diff.TotalDays;
            Console.WriteLine($"The age is {Math.Round(ageInDays)} days old");
            double daysToNextAnniversary = 10000 - ageInDays; 
            Console.WriteLine($"There are {Math.Round(daysToNextAnniversary)} days to the next 10000 days anniversary");
        }
    }
}
