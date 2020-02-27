using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryAppPractice1
{
    public class Employee
    {
        private int id;
        private string name, email;
        private double basic, medical, conveyance, increament = 0, totalCost = 0;

        public Employee()
        {
            basic = 0;
        }

        public Employee(int id, string name, string email, double basic, double medical, double conveyance) : this()
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.basic = basic;
            this.medical = medical;
            this.conveyance = conveyance;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public double Basic
        {
            get { return basic; }
            set { basic = value; }
        }

        public double Medical
        {
            get { return medical; }
            set { medical = value; }
        }

        public double Conveyance
        {
            get { return conveyance; }
            set { conveyance = value; }
        }

        public bool MedicalAmount(double medical)
        {
            this.medical = (medical * basic) / 100;
            return true;
        }

        public bool ConveyanceAmount(double conveyance)
        {
            this.conveyance = (conveyance * basic) / 100;
            return true;
        }

        public bool Increament(double increasedAmount)
        {
            increament = (increasedAmount * basic) / 100;
            return true;
        }

        public string GetInfo()
        {
            this.totalCost = basic + medical + conveyance + increament;
            string info = name + ", your have: " + totalCost + " tk.";
            return info;
        }
    }
}
