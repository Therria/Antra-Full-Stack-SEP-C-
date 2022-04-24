using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class MyList<T>
    {
        public List<T> List { get; set; }

        public MyList()
        {
            List = new List<T>();
        }


        public void Add(T element)
        {           
            List.Add(element);
        }

        public T Remove (int index)
        {
            if (index >= List.Count)
            {
                return default(T);
            }
            T element = List[index];
            List.RemoveAt(index);
            return element;
        }

        public bool Contains(T element)
        {
            if (List.Count == 0)
            {
                return false;
            }

            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public void Clear()
        {
            List.Clear();
        }

        public void InsertAt(T element, int index)
        {
            if (index >= List.Count)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            List.Insert(index, element);
        }

        public void DeleteAt(int index)
        {
            if (index >= List.Count)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            List.RemoveAt(index);
        }

        public T Find(int index)
        {
            if (index >= List.Count)
            {
                return default(T);
            }
            return List[index];
        }

        public int Count()
        {
            return List.Count;
        }



    }
}
