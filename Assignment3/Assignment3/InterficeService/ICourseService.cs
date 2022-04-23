using Assignment3.PersonType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.InterficeService
{
    public interface ICourseService
    {
        public List<Student> GetEnrollmentList(Course course);
    }
}
