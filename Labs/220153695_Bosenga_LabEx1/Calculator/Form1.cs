using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        // initialize my variables
        double resultValue = 0;
        string operators = "";
        bool performedOperators = false;
        public Form1()
        {
            InitializeComponent();
        }
        // capture all my numbers
        private void BtnNumbers(object sender, EventArgs e)
        {
            if(txtBox.Text == "0" || performedOperators)
            {
                txtBox.Clear();
            }
            performedOperators= false;
            Button btn = (Button)sender;
            txtBox.Text = txtBox.Text + btn.Text;
        }
        // capture all my operators
        private void BtnOperations(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (resultValue == 0)
            {
                operators = btn.Text;
                resultValue = Convert.ToDouble(txtBox.Text);
                lblResult.Text = $"{resultValue} {operators}";
                performedOperators = true;
            }
            else
            {
                btnCalculations.PerformClick();
                operators = btn.Text;
                lblResult.Text = $"{resultValue} {operators} ";
                performedOperators = true;
            }
        }
        // calculate with the equal sign
        private void BtnEqualSign(object sender, EventArgs e)
        {
            try
            {
                CalculationPerformed();
                resultValue = Convert.ToDouble(txtBox.Text);
                txtBox.Text = "";
            }
            catch 
            {
                MessageBox.Show("Click okay to clear");
                txtBox.Text = "";
                lblResult.Text = "";
                resultValue = 0;
            }

        }
        // performing my calculations
        public void CalculationPerformed()
        {
            lblResult.Text = lblResult.Text + txtBox.Text + " = ";
            if (operators == "+")
            {
                txtBox.Text = (resultValue + Convert.ToDouble(txtBox.Text)).ToString();
                lblResult.Text = lblResult.Text + txtBox.Text  ;
            }
            else if (operators == "-")
            {
                txtBox.Text = (resultValue - Convert.ToDouble(txtBox.Text)).ToString();
                lblResult.Text = lblResult.Text + txtBox.Text;
                   
            }
            else if (operators == "*")
            {
                txtBox.Text = (resultValue * Convert.ToDouble(txtBox.Text)).ToString();
                lblResult.Text = lblResult.Text + txtBox.Text;
            }
            else if (operators == "/")
            {
                try
                {
                    txtBox.Text = (resultValue / Convert.ToDouble(txtBox.Text)).ToString();
                    lblResult.Text = lblResult.Text + txtBox.Text;
                }
                catch(DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message, "Error Message");
                }
            }
        }
        // clearing everything
        private void BtnClear(object sender, EventArgs e)
        {
            txtBox.Text = "";
            lblResult.Text = "";
            resultValue = 0;
        }
    }
}