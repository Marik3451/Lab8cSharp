using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class AddStudent : Form
    {
        private BindingList<Student> studentList;
        public AddStudent(BindingList<Student> studentList)
        {
            this.studentList = studentList;
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string group = txtGroup.Text;
                string formEducation = txtFormEducation.Text;
                double average;

                if (double.TryParse(txtAverage.Text, out average))
                {
                    if (average >= 0 && average <= 100)
                    {
                        Student student = new Student(name, group, formEducation, average);
                        studentList.Add(student);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid average. Please enter a valid number between 0 and 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid average. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
