using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class GenericRepository<T> : IRepository<Entity>
    {
        List<Entity> _entities;

        public GenericRepository()
        {
            _entities = new List<Entity>();
        }

        public void Add(Entity item)
        {
            _entities.Add(item);
        }

        public IEnumerable<Entity> GetAll()
        {
            return _entities;
        }

        public Entity GetById(int id)
        {
            foreach (Entity e in _entities)
            {
                if (e.Id == id)
                {
                    return e;
                }   
            }
            return null;
        }

        public void Remove(Entity item)
        {
            _entities.Remove(item);
        }

        public void Save() // no idea what "save" means, so just print the list
        {
            foreach (Entity e in _entities)
            {
                Console.WriteLine(e.Id);
            }
        }
    }
}
