using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataLayerClass data = new DataLayerClass();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string gender = txtGender.Text;
            string email = txtEmail.Text;
            
            if(txtName.Text == "" || txtSurname.Text =="" || txtGender.Text==""||txtEmail.Text == "")
            {
                MessageBox.Show("Add field");
            }
            else
            {
                data.InsertIntoTable(name, surname, gender, email);
                MessageBox.Show("Your data has been added");

                DataTable dataTable = data.DisplayInGrid();
                datagrid.ItemsSource = dataTable.DefaultView;
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string gender = txtGender.Text;
            string email = txtEmail.Text;

            if (txtEmail.Text == "" || txtGender.Text == "" || txtName.Text == "" || txtSurname.Text == ""||txtId.Text == "")
            {
                MessageBox.Show("Add field");
            }
            else
            {
                data.UpdateGrid(Convert.ToInt32(txtId.Text), name, surname, gender, email);
                MessageBox.Show("Your data has been updated");
            }

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int ID = Convert.ToInt32(txtId.Text);
            data.DeleteColumn(ID);
            MessageBox.Show("Your data has been deleted");
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtGender.Text = string.Empty;
            txtName.Text = string.Empty;
            txtId.Text = string.Empty;
            txtSurname.Text = string.Empty;
            datagrid.ItemsSource = "";
        }
    }
}
