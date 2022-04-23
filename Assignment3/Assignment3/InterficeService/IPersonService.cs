using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.InterficeService
{
    public interface IPersonService
    {
        public int GetAge(Person person);
        public decimal GetSalary(Person person);

        public string GetAddress(Person person);
    }
}
