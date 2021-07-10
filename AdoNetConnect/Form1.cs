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
        #region a
        /*
        using (SqlConnection connection = new(connectionString))
        {               

            try
            {
                connection.Open();
                if(connection.State == ConnectionState.Open)
                {
                    var command = new SqlCommand();
                    command.CommandText = "select * from sys.databases";
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;

                    SqlDataReader reader = command.ExecuteReader();

                    ListBox dbbox = new();
                    ListBox tablebox = new();
                    TextBox dbtext = new();
                    Button dbbutton = new();
                    dbbox.Location = new Point(40, 250);
                    tablebox.Location = new Point(600, 250);
                    dbtext.Location = new Point(260, 250);
                    dbbutton.Location = new Point(260, 260 + dbtext.Height);
                    tablebox.Width = 200;
                    tablebox.Height = 200;
                    dbbox.Width = 200;
                    dbbox.Height = 200;                        
                    dbtext.Width = 150;
                    dbbutton.Width = 150;
                    dbbutton.Height = dbtext.Height;
                    dbbutton.Text = "Show tables";
                    this.Controls.Add(dbbox);
                    this.Controls.Add(dbtext);
                    this.Controls.Add(dbbutton);
                    this.Controls.Add(tablebox);
                    while (reader.Read())
                    {
                        string name = (string)reader["name"];

                        dbbox.Items.Add(name);
                    }




                    if(dbbox.Items.Count == 0)
                    {
                        MessageBox.Show("Some text", "Some title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }                  
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    */
        #endregion
    }

}
