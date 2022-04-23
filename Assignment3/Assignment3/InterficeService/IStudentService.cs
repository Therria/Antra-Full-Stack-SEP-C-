using Assignment3.PersonType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.InterficeService
{
    public interface IStudentService : IPersonService
    {
        public List<String> GetGrades(Student student); 
        public double CalclateGPA(Student student);
    }
}
