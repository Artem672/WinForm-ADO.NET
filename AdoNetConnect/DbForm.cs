using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetConnect
{
    public partial class DbForm : Form
    {
        public DbForm(string Address, string Login, string Password)
        {
            InitializeComponent();
            this.Address = Address;
            this.Login = Login;
            this.Password = Password;
        }
        public SqlConnection ManageSQLConnection()
        {
            string connectionString = @"Data Source="
                                      + Address
                                      + ";Initial Catalog=master;"
                                      + "Integrated Security=false; User Id="
                                      + Login
                                      + "; Password="
                                      + Password;
            SqlConnection connection = new(connectionString);
            return connection;
        }
        public string Address { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        private void dbbox_Click(object sender, EventArgs e)
        {
            
            using ( SqlConnection connection = ManageSQLConnection())
            {
                try
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        var command = new SqlCommand();
                        command.CommandText = "select * from sys.databases";
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;

                        SqlDataReader reader = command.ExecuteReader();

                        while(reader.Read())
                        {
                            string name = (string)reader["name"];
                            dbbox.Items.Add(name);
                        }
                    }
                }
                catch(SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


        }

        private void ShowTables_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ManageSQLConnection())
            {
                try
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.ChangeDatabase(dbbox.Items[dbbox.SelectedIndex].ToString());
                        var command = new SqlCommand();
                        command.CommandText = "SELECT * FROM sys.objects WHERE type in (N'U')";
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        ListBox tablelist = new();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string name = (string)reader["name"];
                            tablelist.Items.Add(name);
                        }

                        Form tableForm = new Form();
                        tablelist.Height = tableForm.Height;
                        tablelist.Width = tableForm.Width;
                        tableForm.Controls.Add(tablelist);
                        tableForm.Show();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
