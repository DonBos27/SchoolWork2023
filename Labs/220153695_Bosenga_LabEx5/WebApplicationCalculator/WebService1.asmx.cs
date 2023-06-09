using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;

namespace WebApplicationCalculator
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        BLL businessLogic = new BLL();
        DLL data = new DLL();

        [WebMethod(Description = "This method adds two numbers",EnableSession = true)]
        public double Add(double firstNum, double secNumber)
        {
            return businessLogic.add(firstNum,secNumber);
        }
        [WebMethod(Description = "This method determines the difference two numbers", EnableSession = true)]
        public double Substract(double firstNum, double secNumber)
        {
            return businessLogic.substract(firstNum,secNumber);
        }
        [WebMethod(Description = "This method determines the product between two numbers", EnableSession = true)]
        public double Multiply(double firstNum, double secNumber)
        {
            return businessLogic.multiplication(firstNum,secNumber);
        }
        [WebMethod(Description = "This method divides two numbers", EnableSession = true)]
        public double Divide(double firstNum, double secNumber)
        {
            return businessLogic.divide(firstNum, secNumber);
        }
        [WebMethod(Description = "This method displays the recent calculation from the DB", EnableSession = true)]
        public DataTable GetList()
        {
            DataTable mydata = new DataTable();
            mydata = data.DisplayData();
            mydata.TableName = "recentcalculator";
            return mydata;
        }
        [WebMethod(Description = "This method writes the recent calculation into the DB", EnableSession = true)]
        public void InsertData( string recentCalculator)
        {
            data.InsertToDataBase(recentCalculator);
        }
    }
}
