using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentWiseStudentEntryExample3
{
    class Student
    {
        public string RegistrationNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string GetInfo()
        {
            return $"{RegistrationNo} \t\t {Name} \t\t {Email}";
        }
    }
}
