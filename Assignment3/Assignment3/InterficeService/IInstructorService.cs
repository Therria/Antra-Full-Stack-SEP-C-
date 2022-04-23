using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.InterficeService
{
    public interface IInstructorService : IPersonService
    {
        public decimal BonusSalaryCalculation(Instructor instructor); 
    }
}
