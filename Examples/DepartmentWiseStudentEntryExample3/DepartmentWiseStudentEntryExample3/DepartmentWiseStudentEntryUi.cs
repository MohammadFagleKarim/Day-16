using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentWiseStudentEntryExample3
{
    public partial class DepartmentWiseStudentEntryUi : Form
    {
        public DepartmentWiseStudentEntryUi()
        {
            InitializeComponent();
        }

        private List<Department> _departments;

        private void DepartmentSaveButton_Click(object sender, EventArgs e)
        {
            Department _department = new Department(4);

            _department.Code = codeTextBox.Text;
            _department.Name = departmentNameTextBox.Text;

            if(_departments == null)
            {
                _departments = new List<Department>();
            }

            _departments.Add(_department);

            MessageBox.Show("Successfully saved.");
        }

        private void LoadDepartmentComboBox()
        {
            deprartmentComboBox.DataSource = null;
            deprartmentComboBox.DataSource = _departments;
            deprartmentComboBox.DisplayMember = "Name";
            deprartmentComboBox.ValueMember = "Code";

            department2ComboBox.DataSource = null;
            department2ComboBox.DataSource = _departments;
            department2ComboBox.DisplayMember = "Name";
            department2ComboBox.ValueMember = "Code";
        }
        
        private void StudentSaveButton_Click(object sender, EventArgs e)
        {
            if (_department == null)
            {
                MessageBox.Show("Department is not created, please create department!");
            }

            Student student = new Student();

            student.Name = studentNameTextBox.Text;
            student.Email = emailTextBox.Text;
            student.RegistrationNo = regNoTextBox.Text;

            bool isAdded = _department.AddStudent(student);

            if(isAdded)
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

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string message = _department.GetInfo();

            MessageBox.Show(message);
        }
    }
}