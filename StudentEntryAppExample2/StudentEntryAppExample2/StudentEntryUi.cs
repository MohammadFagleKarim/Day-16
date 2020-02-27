using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEntryAppExample2
{
    public partial class StudentEntryUi : Form
    {
        public StudentEntryUi()
        {
            InitializeComponent();
        }

        private Department _department;

        private void DepartmentSaveButton_Click(object sender, EventArgs e)
        {
            _department = new Department(4);

            _department.Code = codeTextBox.Text;
            _department.Name = departmentNameTextBox.Text;

            MessageBox.Show("Successfully saved.");
        }

        private void StudentSaveButton_Click(object sender, EventArgs e)
        {
             if(_department == null)
            {
                MessageBox.Show("Department is not created, please create department!");
            }

            Student student = new Student();

            student.Name = studentNameTextBox.Text;
            student.Email = emailTextBox.Text;
            student.RegistrationNo = regNoTextBox.Text;

            bool isAdded = _department.AddStudent(student);

            if (isAdded)
            {
                studentNameTextBox.Clear();
                emailTextBox.Clear();
                regNoTextBox.Clear();
            }

            else
            {
                MessageBox.Show("Student could not be added, maximum capacity exceeded!");
            }
        }

        private void ShowDetailsButton_Click(object sender, EventArgs e)
        {
            string message = _department.GetInfo();

            MessageBox.Show(message);
        }
    }
}
