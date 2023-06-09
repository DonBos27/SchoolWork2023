using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Sales_Transactions_Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Initialize variables
        int price;
        float interest;
        float payment;
        string name;


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            name = txtBoxName.Text;

            // checking if both my textboxes are empty
            if (name == "" && string.IsNullOrEmpty(txtBoxPrice.Text))
            {
                MessageBox.Show("Please fill your forms");
                txtBoxPrice.Clear();
                txtBoxName.Clear();
            }
            // check if one of them is empty
            else if (name == "" || string.IsNullOrEmpty(txtBoxPrice.Text))
            {
                if(name == "")
                {
                    MessageBox.Show("Please enter your name");
                }
                else if (string.IsNullOrEmpty(txtBoxPrice.Text))
                {
                    MessageBox.Show("Please enter the price");
                }
                txtBoxPrice.Clear();
                txtBoxName.Clear();
            }
            // display every  calculations 
            else
            {
                listBoxDisplaying();
            }
        }
        // Doing my calculations 
        public void listBoxDisplaying()
        {
            name = txtBoxName.Text;
            price = Convert.ToInt32(txtBoxPrice.Text);
            listBox1.Items.Add($"Payment  \t New Balance");
            listBox1.Items.Add($"=======  \t ===========");
            interest = price + (price * 0.25f);
            // will display unyil it reach a range of 15-16
            for (int i = 1; interest > 16; i++)
            {
                if (i != 1)
                {
                    payment = (interest * 0.12f);
                }
                else
                {
                    payment = 0;
                }
                interest -= payment;
                listBox1.Items.Add($"R{payment:0.00}   \t \t R{interest:0.00}");
                btnCalculate.Enabled = false;
            }
            MessageBox.Show($"Welcome to the sales transactions data systems Mr/Mrs {name} \n Here is your paymment");
        }
        // clearing everything
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxName.Clear();
            txtBoxPrice.Clear();
            listBox1.Items.Clear();
            btnCalculate.Enabled = true;
        }
        // exit the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}