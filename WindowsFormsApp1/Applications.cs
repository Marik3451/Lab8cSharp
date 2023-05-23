using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Applications : Form
    {
        private bool sortDescending = false;

        private bool sortAscending = true;

        private static readonly string PATH_TO_StudentList_FILE = "StudentList.bin";

        private StudentList basic;

        private BindingList<Student> studentList;

        private BinaryFormatter binaryFormatter;

        public Applications()
        {
            binaryFormatter = new BinaryFormatter();
            basic = new StudentList();
            studentList = new BindingList<Student>(basic);
            InitializeComponent();
            lstStudent.DataSource = studentList;
        }
        private void btnFillStudent_Click(object sender, EventArgs e)
        {
            basic.FillStudent();
            studentList.ResetBindings();
        }
       
        private void lstStudent_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = e.ListItem.ToString();
        }

          private void btnAddStudent_Click_1(object sender, EventArgs e)
        {
            AddStudent student = new AddStudent(studentList);
            student.ShowDialog();
            studentList.ResetBindings();
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            try
            {
                basic.WriteToFile(binaryFormatter, PATH_TO_StudentList_FILE);
                MessageBox.Show("Файл успішно записано.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Виникла помилка при записі до файлу: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                basic.ReadFromFile(binaryFormatter, PATH_TO_StudentList_FILE);
                studentList.ResetBindings();
                MessageBox.Show("Файл успішно прочитано.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Виникла помилка при читанні з файлу: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            basic.Clear();
            studentList.ResetBindings();
        }
              
        private void btnCheckAverage_Click_1(object sender, EventArgs e)
        {
            foreach (var item in studentList)
            {
                if (item.FormEducation == "Платна" && item.Average >= 98)
                {
                    item.FormEducation = "За рахунок іменної стипендії";
                    studentList.ResetBindings();
                }
            }
        }
        private void btnSort_Click_1(object sender, EventArgs e)
        {
            if (sortAscending)
            {
                basic.Sort((o1, o2) => o1.Average.CompareTo(o2.Average));
            }
            else if (sortDescending)
            {
                basic.Sort((o1, o2) => o2.Average.CompareTo(o1.Average));
            }

            studentList.ResetBindings();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sortAscending = radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sortDescending = radioButton2.Checked;
        }

       
    }
}
