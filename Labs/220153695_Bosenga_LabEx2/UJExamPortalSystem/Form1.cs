using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UJExamPortalSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Compute Button to display the final mark
        private void btnCompute_Click(object sender, EventArgs e)
        {
            string studNum = txtStuNum.Text;
            int assignment = Convert.ToInt32(txtAssignment.Text);
            int test = Convert.ToInt32(txtTest.Text);
            int exam = Convert.ToInt32(txtExam.Text);
            StudentClass studentClass = new StudentClass(studNum, test, exam, assignment);
            calculationOfMark(studentClass.studentAssignmentMark, studentClass.studentTestMark, studentClass.studentExamMark);
            btnDisplay.Enabled = true;
            btnWrite.Enabled = true;
            btnCompute.Enabled = false;
        }
        //Function to calculate marks of student
        public string calculationOfMark(int stuMarkAss,int stuMarkTest, int stuMarkExam )
        {
            return txtFinal.Text = (((stuMarkAss * 20) / 100) + ((stuMarkTest * 30) / 100) + ((stuMarkExam * 50) / 100)).ToString();
        }
        //function to check if the student pass or fail based on their marks
        public string checkMark(string displayCheckMark)
        {
            if ((Convert.ToInt32(txtFinal.Text)) >= 50 && (Convert.ToInt32(txtFinal.Text)) <= 100)
            {
                displayCheckMark = "Pass";
            }
            else if((Convert.ToInt32(txtFinal.Text))<50 && (Convert.ToInt32(txtFinal.Text))>=0)
            {
                displayCheckMark = "Fail";
            }
            return displayCheckMark;
        }
        // Add button to add in the list 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string studNum = txtStuNum.Text;
            int assignment = Convert.ToInt32(txtExam.Text);
            int test = Convert.ToInt32(txtTest.Text);
            int exam = Convert.ToInt32(txtAssignment.Text);
            StudentClass studentClass = new StudentClass(studNum, test, exam, assignment);
            calculationOfMark(studentClass.studentAssignmentMark, studentClass.studentTestMark, studentClass.studentExamMark);
            checkMark(calculationOfMark(studentClass.studentAssignmentMark, studentClass.studentTestMark, studentClass.studentExamMark));
            MessageBox.Show("One record has been added to the list");
            btnDisplay.Enabled = true;

        }
        //Function that helps to add or write in the exam file 
        public void AddingFile()
        {
            string dataset = "./exam.txt";
            string studNum = txtStuNum.Text;
            int assignment = Convert.ToInt32(txtExam.Text);
            int test = Convert.ToInt32(txtTest.Text);
            int exam = Convert.ToInt32(txtAssignment.Text);
            StudentClass studentClass = new StudentClass(studNum, test, exam, assignment);
            string studentRecord = $"\n{studNum} \t \t {txtFinal.Text} \t \t {checkMark(calculationOfMark(studentClass.studentAssignmentMark, studentClass.studentTestMark, studentClass.studentExamMark))}";
            File.AppendAllText(dataset, studentRecord);
        }
        //button that will add in the file by calling the function AddingFile
        private void btnWrite_Click(object sender, EventArgs e)
        {
            MessageBox.Show("One record has been added to the file");
            AddingFile();
            btnWrite.Enabled = false;
            btnDisplay.Enabled = true;
            btnCompute.Enabled = true; 
        }
        //Button to display all my datas 
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string dataset = "./exam.txt";
            List<string> allMyDataSet = new List<string>();
            using (var reader = new StreamReader(dataset))
            {
                while (!reader.EndOfStream)
                {
                    string lines = reader.ReadLine();
                    allMyDataSet.Add(lines);
                    listBox1.Items.Add($"{lines}\n");
                }
            }

            btnDisplay.Enabled = false;
            btnWrite.Enabled = true;
            btnCompute.Enabled = true;

        }
        //clear button that will clear every textboxes and listbox
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtExam.Clear();
            txtAssignment.Clear();
            txtFinal.Clear();
            txtStuNum.Clear();
            txtTest.Clear();
            listBox1.Items.Clear();
            btnAdd.Enabled = true;
            btnCompute.Enabled = true;
            btnDisplay.Enabled = true;
            btnWrite.Enabled = true;
        }
        // exit button to close the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
