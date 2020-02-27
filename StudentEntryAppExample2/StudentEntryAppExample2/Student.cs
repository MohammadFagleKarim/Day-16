using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEntryAppExample2
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
