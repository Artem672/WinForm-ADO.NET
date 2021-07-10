using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AdoNetConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public SqlConnection ManageSQLConnection()
        {
            string connectionString = @"Data Source="
                                      + AddressText.Text
                                      + ";Initial Catalog=master;"
                                      + "Integrated Security=false; User Id="
                                      + LoginText.Text
                                      + "; Password="
                                      + PasswordText.Text;
            SqlConnection connection = new(connectionString);
            return connection;
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ManageSQLConnection())
            {
                try
                {
                    connection.Open();

                    if (connection.State == ConnectionState.Open)
                    {
                        DbForm dbForm = new(AddressText.Text,LoginText.Text,PasswordText.Text);
                        dbForm.Show();
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
