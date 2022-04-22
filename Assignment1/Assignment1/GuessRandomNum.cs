using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public static class GuessRandomNum
    {
        public static void Guess()
        {
            int correctNumber = new Random().Next(3) + 1;  
            while (true)
            {   Console.WriteLine("Enter a number: ");
                int guessedNumber = int.Parse(Console.ReadLine());
                if (guessedNumber < 1 || guessedNumber > 3) 
                {
                    Console.WriteLine($"{guessedNumber} is outside the range"); 
                } 
                else if (guessedNumber < correctNumber)
                {
                    Console.WriteLine($"{guessedNumber} is low");
                } 
                else if (guessedNumber > correctNumber)
                {
                    Console.WriteLine($"{guessedNumber} is high");
                }
                else
                {
                    Console.WriteLine($"{guessedNumber} is correct");
                    break;
                }
            }
            
        }
    }
}
