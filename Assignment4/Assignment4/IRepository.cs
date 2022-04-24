using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public interface IRepository<T> /*where T : Entity, new()*/
    {
        public void Add(T item);
        public void Remove(T item);

        public void Save();

        public IEnumerable<T> GetAll();

        public T GetById(int id);
    }
}
