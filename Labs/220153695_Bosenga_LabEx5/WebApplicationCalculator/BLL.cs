using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationCalculator
{
    public class BLL
    {
        public BLL() { }

        public double add(double firstNum, double secNumber)
        {
            return firstNum + secNumber;
        }
        public double substract(double firstNum, double secNumber)
        {
            return firstNum - secNumber;
        }
        public double multiplication(double firstNum, double secNumber)
        {
            return firstNum * secNumber;
        }
        public double divide(double firstNum, double secNumber)
        {
            return firstNum / secNumber;
        }
        public double percentage(double firstNum, double secNumber)
        {
            return (firstNum / 100) * secNumber;
        }
        public double Calculation(string operators, double firstNum, double secNumber)
        {
            double result = 0;
            if(operators == "+")
            {
                result = add(firstNum, secNumber);
            }
            else if(operators == "-")
            {
                result = substract(firstNum, secNumber);
            }
            else if(operators=="*")
            {
                result = multiplication(firstNum, secNumber);
            }
            else if (operators == "/")
            {
                try
                {
                    result = divide(firstNum, secNumber);
                }
                catch(DivideByZeroException ex)
                {
                    result = Convert.ToDouble(ex.Message);
                }
            }
            if (operators == "%")
            {
                result = percentage(firstNum,secNumber);
            }
            return result;
        }

    }
}