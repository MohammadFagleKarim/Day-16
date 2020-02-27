using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEntryAppExample2
{
    class Department
    {
        public Department(int maximumCapacity)
        {
            _maximumCapacity = maximumCapacity;
        }

        public Department(string code, string name, int maximumCapacity = 15) : this(maximumCapacity)
        {
            Code = code;
            Name = name;
        }

        public string Code { get; set; }
        public string Name { get; set; }

        private List<Student> _students;

        private int _maximumCapacity;

        public bool AddStudent(Student newStudent)
        {
            if (_students == null)
            {
                _students = new List<Student>();
            }

            if (HasCapacity())
            {
                _students.Add(newStudent);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool HasCapacity()
        {
            if (_students.Count < _maximumCapacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetInfo()
        {
            string message = "";
            message += $"Department -> Code: {Code} Name: {Name} {Environment.NewLine}";
            message += "Reg No \t\t Name \t\t Email" + Environment.NewLine;

            foreach(Student student in _students)
            {
                message += student.GetInfo() + Environment.NewLine;
            }

            return message;
        }
    }
}
