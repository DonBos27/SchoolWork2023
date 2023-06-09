using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace UJStaffPortal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Class of the business logic layer 
        BLL obj = new BLL();

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //function that display the email address and the age of the staff member
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //check if the textbox is empty to ask the user to fill it before displaying address and age
                if (txtIdNumber.Text == "" || txtName.Text == "" || txtSurname.Text == "")
                {
                    MessageBox.Show("Please Fill Your Form");
                }
                else
                {
                    lblEmail.Text = obj.Email(txtName.Text, txtSurname.Text);
                    lblName.Text = obj.Age(txtIdNumber.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                clearEverything();
            }
        }
        //function that save the email and the age to the file 'staff.txt'
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                //check if the textbox is empty to ask the user to fill it before displaying address and age
                if (txtIdNumber.Text == "" || txtName.Text == "" || txtSurname.Text == "")
                {
                    MessageBox.Show("Please Fill Your Form");
                }
                else
                {
                    obj.WriteAll(txtName.Text, txtSurname.Text, txtIdNumber.Text);
                    clearEverything();
                    MessageBox.Show("Written To File ...");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                clearEverything();
            }
        }
        //function that read or display all our data of the file 'staff.txt' in the listBox
        private void btnRead_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var List = obj.ReadAllFile();
            foreach (var line in List)
            {
                listBox1.Items.Add(line);
            }
        }
        //function to clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearEverything();
        }
        //A void function to clear everything so that I can use it in my clear button and my save button
        public void clearEverything()
        {
            txtIdNumber.Clear();
            txtName.Clear();
            txtSurname.Clear();
            lblEmail.Text = "";
            lblName.Text = "";
            listBox1.Items.Clear();
        }
        // Function to exit the app 
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
