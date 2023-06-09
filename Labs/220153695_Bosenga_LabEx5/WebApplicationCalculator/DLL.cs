using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
using Mysqlx.Session;

namespace WebApplicationCalculator
{
    public class DLL
    {
        static string connectToDB = "server=localhost;uid=root;password='';database=calculator";
        MySqlConnection conn = new MySqlConnection(connectToDB);
        MySqlCommand cmd;

        public void openClose()
        {
            if(ConnectionState.Open != conn.State)
            {
                conn.Open();
            }
            else
            {
                conn.Close();
            }
        }
        public void InsertToDataBase(string recent)
        {
            string syntax = $"insert into recentcalculator values(default, '{recent}') ";
            openClose();
            cmd = new MySqlCommand(syntax, conn);
            cmd.ExecuteNonQuery();
            openClose();
        }
        public DataTable DisplayData()
        {
            string syntax = $"select * from recentcalculator";
            openClose();
            cmd = new MySqlCommand(syntax, conn);
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            openClose();
            return table;
            
        }
    }
}