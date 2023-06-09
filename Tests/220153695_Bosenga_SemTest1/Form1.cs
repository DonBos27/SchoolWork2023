using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _220153695_Bosenga_SemTest1
{
    public partial class Form1 : Form
    {
        //initialize all my datas with specific datatype (one from my class and another one is a the built in integer
        private Data[] display;
        private Data[] filterData;
        private int currentIndex;
        private Data [] com;
        private Data[] gov;
        private Data[] edu;
        private Data[] ru;
        private Data[] uk;
        private Data[] jp;
        //DataManager dataManager = new DataManager();
        public Form1()
        {

            InitializeComponent();
            // call my data manager class
            DataManager dataManager = new DataManager();
            display = dataManager.readFromFile();
            filterData = display;
            //initialize each domain name variable for my class data manager
            com = dataManager.determineDomain("com");
            gov = dataManager.determineDomain("gov");
            edu = dataManager.determineDomain("edu");
            ru = dataManager.determineDomain("ru");
            jp = dataManager.determineDomain("jp");
            uk = dataManager.determineDomain("uk");
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //create a function that will load according to the index 0 
        public void loading (int index)
        {
            Data mem = filterData[index];
            txtNumber.Text = mem.Number.ToString();
            txtName.Text = mem.Name;
            txtSurname.Text = mem.Surname;
            txtEmail.Text = mem.Email;
            txtAddress.Text = mem.IPAddress;
            //if gender is male it will check at male 
            if (mem.Gender == "Male")
            {
                RadioMale.Checked = true;
            }
            else
            {
                RadioMale.Checked = false;
                RadioFemale.Checked = true;
            }
        }
        //My button to load and display in the textbox
        private void BtnLoad_Click(object sender, EventArgs e)
        {

            currentIndex= 0;
            filterData= display;
            loading(currentIndex);

        }
        // button to go to the next row
        private void BtnForward_Click(object sender, EventArgs e)
        {

            if(currentIndex < filterData.Length - 1)
            {
                currentIndex++;
                loading(currentIndex);
            }

        }
        //button for the previous row
        private void BtnBackward_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                loading(currentIndex);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            radioCheck();
        }
        //function that check all of my radios
        public void radioCheck()
        {
            int i= 0;
            if (radioCom.Checked)
            {
                foreach (var item in com)
                {
                    listBox1.Items.Add($"{item.Number}\t {item.Name} \t {item.Surname} \t {item.Email} \t {item.Gender} \t {item.IPAddress}");
                }
            }
            else if (radioGov.Checked)
            {
                foreach (var item in gov)
                {
                    listBox1.Items.Add($"{item.Number}\t {item.Name} \t {item.Surname} \t {item.Email} \t {item.Gender} \t {item.IPAddress}");
                }
            }
            else if (radioEdu.Checked)
            {
                foreach (var item in edu)
                {

                    listBox1.Items.Add($"{item.Number}\t {item.Name} \t {item.Surname} \t {item.Email} \t {item.Gender} \t {item.IPAddress}");
                }
            }
            else if (radioRu.Checked)
            {
                foreach (var item in ru)
                {

                    listBox1.Items.Add($"{item.Number}\t {item.Name} \t {item.Surname} \t {item.Email} \t {item.Gender} \t {item.IPAddress}");
                }
            }
            else if (radioUk.Checked)
            {
                foreach (var item in uk)
                {

                    listBox1.Items.Add($"{item.Number}\t {item.Name} \t {item.Surname} \t {item.Email} \t {item.Gender} \t {item.IPAddress}");
                }
            }
            else if (radioJp.Checked)
            {
                foreach (var item in jp)
                {

                    listBox1.Items.Add($"{item.Number}\t {item.Name} \t {item.Surname} \t {item.Email} \t {item.Gender} \t {item.IPAddress}");
                }
            }
        }

        private void radioGov_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            radioCheck();
        }

        private void radioEdu_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            radioCheck();
        }

        private void radioRu_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            radioCheck();
        }

        private void radioUk_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            radioCheck();
        }

        private void radioJp_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            radioCheck();
        }
    }
}
