using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class DataLayerClass
    {
        public static string sqlConnection = "server=localhost;uid=root;password='';database=labex";
        MySqlConnection connection = new MySqlConnection(sqlConnection);
        MySqlCommand command = new MySqlCommand();

        public void openAndClose()
        {
            if (ConnectionState.Open != connection.State)
            {
                connection.Open();
            }
            else
            {
                connection.Close();
            }
        }
        public void InsertIntoTable(string name, string surname, string gender, string email)
        {
            openAndClose();
            string sqlSyntax = $"insert into users(name,surname,gender,email) values('{name}','{surname}','{gender}', '{email}')";
            command = new MySqlCommand(sqlSyntax, connection);
            command.ExecuteNonQuery();
            openAndClose();
        }
        public DataTable DisplayInGrid()
        {
            string sqlSyntax2 = "select * from users";
            openAndClose();
            command = new MySqlCommand(sqlSyntax2, connection);

            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            sqlDataAdapter.Fill(table);
            return table;
        }
        public DataTable UpdateGrid(int id, string name, string surname, string gender, string email)
        {
            string sqlsyntaxupdate = $"update users set name = '{name}',surname = '{surname}',gender = '{gender}', email = '{email}' where ID = '{id}'";
            openAndClose();
            command = new MySqlCommand(sqlsyntaxupdate, connection);

            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            sqlDataAdapter.Fill(table);
            return table;
        }
        public void DeleteColumn(int id)
        {
            openAndClose();
            string sqlSyntaxDelete = $"delete from users where ID = '{id}'";
            command = new MySqlCommand(sqlSyntaxDelete, connection);
            command.ExecuteNonQuery();
            openAndClose();
        }
    }
}
