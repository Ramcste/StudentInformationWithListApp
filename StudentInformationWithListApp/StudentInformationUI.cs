using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace StudentInformationWithListApp
{
    public partial class StudentInformationUI : Form
    {
        public StudentInformationUI()
        {
            InitializeComponent();
        }

        List< Student> studentList=new List<Student>(); 
        private void clearStudentInformationButton_Click(object sender, EventArgs e)
        {
            studentList.Clear();
            MessageBox.Show("All information has been cleared");
        }

        private void showStudentInformationButton_Click(object sender, EventArgs e)
        {
            string studentinfo = "Reg No.\tName\n";
            foreach (var student in studentList)
            {
                studentinfo += student.regNo + "\t" + student.firstName + " " + student.lastName+"\n";
            }

            MessageBox.Show(studentinfo);
        }

        private void saveStudentInformationButton_Click(object sender, EventArgs e)
        {

            Student aStudent = new Student();

            aStudent.regNo = regNoTextBox.Text;

            aStudent.firstName = firstNameTextBox.Text;

            aStudent.lastName = lastNameTextBox.Text;

         

            if (studentList.Count < 3)
            {
                studentList.Add(aStudent);
                MessageBox.Show("Saved");

                regNoTextBox.Clear();
                firstNameTextBox.Clear();
                lastNameTextBox.Clear();
                


            }
            else
            {
                MessageBox.Show("You are not allowed to save more than three student information at a time.");
                regNoTextBox.Clear();
                firstNameTextBox.Clear();
                lastNameTextBox.Clear();
                
            }
            


            

        }
    }
}
