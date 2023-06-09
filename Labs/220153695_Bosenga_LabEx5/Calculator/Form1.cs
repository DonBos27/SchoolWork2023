using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApplicationCalculator;
using System.Web.Services;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double resultValue = 0;
        string operators = "";
        bool performedOperators = false;
        BLL businessLayer = new BLL();
        WebService1 web = new WebService1();

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void BtnNumbers(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || performedOperators)
            {
                textBox.Clear();
            }
            performedOperators = false;
            Button btn = (Button)sender;
            if(btn.Text == ",")
            {
                if (!textBox.Text.Contains(","))
                {
                    textBox.Text += btn.Text;
                }
            }
            else
            {
                textBox.Text += btn.Text;
            }
            btnClear.Text = "C";

        }

        private void BtnOperators(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (resultValue == 0)
            {
                operators = btn.Text;
                resultValue = Convert.ToDouble(textBox.Text);
                lblResult.Text = $"{resultValue} {operators}";
                performedOperators = true;
            }
            else
            {
                btnEqual.PerformClick();
                operators = btn.Text;
                lblResult.Text = $" ";
                performedOperators = true;
            }
        }

        private void BtnEqualSign(object sender, EventArgs e)
        {
            try
            {
                if(textBox.Text == "0" || performedOperators)
                {
                    MessageBox.Show("Cannot perform the operation");
                }
                else
                {
                    double result = businessLayer.Calculation(operators, resultValue, Convert.ToDouble(textBox.Text));
                    lblResult.Text = lblResult.Text + " " + textBox.Text + " = " + result.ToString();
                    web.InsertData(lblResult.Text);

                    MessageBox.Show("Added into the database");
                    textBox.Text = "0";
                    lblResult.Text = string.Empty;
                    resultValue = 0;
                    btnClear.Text = "AC";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLoadDB_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = web.GetList();
                dataGridView1.DataSource = dataTable;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            lblResult.Text = string.Empty;
            resultValue = 0;
            btnClear.Text = "AC";
        }

    }
}
