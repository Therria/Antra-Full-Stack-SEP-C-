using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Ball
    {
        int Size;
        Color Color;
        int ThrowTimes;

        public Ball(int size, Color color, int throwTimes = 0)
        {
            this.Size = size;
            this.Color = color;
            this.ThrowTimes = throwTimes;
        }

        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if (Size != 0)
            {
                ThrowTimes++;
            } 
            else
            {
                Console.WriteLine("Throw failed : The ball has been poped");
            }

        }

        public int Times()
        {
            return ThrowTimes;
        }

        public static void Main(string[] args)
        {
            Ball ballRed = new Ball(3, new Color(255, 0, 0));
            Ball ballGreen = new Ball(6, new Color(0, 255, 0));
            Ball ballBlue = new Ball(9, new Color(0, 0, 255));

            ballRed.Throw();
            Console.WriteLine($"The red ball has been thown {ballRed.Times()} times.");
            ;

            ballGreen.Throw();
            ballGreen.Throw();
            Console.WriteLine($"The green ball has been thown {ballGreen.Times()} times.");

            ballBlue.Throw();
            ballBlue.Throw();
            Console.WriteLine($"The blue ball has been thown {ballBlue.Times()} times.");
            ballBlue.Pop();
            //The blue ball has been poped, throw will cause "Throw failed" message
            ballBlue.Throw();
            Console.WriteLine($"The blue ball has been thown {ballBlue.Times()} times.");

        }
    }
}
