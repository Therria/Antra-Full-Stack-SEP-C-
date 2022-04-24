using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class MyStack<T>
    {
        public Stack<T> Stack { get; set; }
        public T Test { get; set; } 

        public MyStack()
        {
            Stack = new Stack<T>();
        }

        public int Count()
        {
            return Stack.Count;
        }

        public T Pop()
        {
            if (Stack.Count == 0)
            {
                return default(T);
            }
            return Stack.Pop();
        }

        public void Push(T element)
        {
            Stack.Push(element);
        }
    }
}
