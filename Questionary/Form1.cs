using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClassWork
{
    public partial class Form1 : Form
    {
        private Person person = new();
        public Form1()
        {
            InitializeComponent();
            CountryComboBox.SelectedIndex = 0;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var obj = sender as DateTimePicker;
            int Time = (DateTime.Now.Year - obj.Value.Year);
            textBox1.Text = Time.ToString();
        }

        private void MaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var obj = sender as RadioButton;
            if (obj.Checked && obj.Name == "MaleRadioButton")
            {
                PersonPicture.Image = Image.FromFile(@"..\..\man.png");
            }
            else if (obj.Checked && obj.Name == "FemaleRadioButton")
            {
                PersonPicture.Image = Image.FromFile(@"..\..\woman.png");
            }
        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            PersonInfo();
            var json = JsonConvert.SerializeObject(person, Formatting.Indented);
            File.Create("PersonInfo.json").Close();
            File.WriteAllText("PersonInfo.json", json);
        }
        private void PersonInfo()
        {
            person.Name = NameTextBox.Text;
            person.SurName = SurNameTextBox.Text;
            person.BirthDate = dateTimePicker1.Value;
            person.Age = Convert.ToInt32(textBox1.Text);
            person.Country = CountryComboBox.Items[CountryComboBox.SelectedIndex].ToString();
            if (MaleRadioButton.Checked)
            {
                person.Sex = MaleRadioButton.Text;
            }
            else if (FemaleRadioButton.Checked)
            {
                person.Sex = FemaleRadioButton.Text;
            }
            person.Hobby = GetHobbiesInfo();
        }
        private List<string> GetHobbiesInfo()
        {
            List<string> Info = new();

            if (gamesCB.Checked)
            {
                Info.Add(gamesCB.Text);
            }
            if (readCB.Checked)
            {
                Info.Add(readCB.Text);
            }
            if (footballCB.Checked)
            {
                Info.Add(footballCB.Text);
            }
            if (anotherCB.Checked)
            {
                Info.Add(anotherTB.Text);
            }

            return Info;
        }

        private void anotherCB_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                anotherTB.Enabled = true;
            }
            else
            {
                anotherTB.Enabled = false;
            }
        }

        private void ReadFile_Click(object sender, EventArgs e)
        {
            if (File.Exists("PersonInfo.json"))
            {
                var json = File.ReadAllText("PersonInfo.json");
                person = JsonConvert.DeserializeObject<Person>(json);

                NameTextBox.Text = person.Name;
                SurNameTextBox.Text = person.SurName;
                dateTimePicker1.Value = person.BirthDate;
                textBox1.Text = person.Age.ToString();
                CountryComboBox.SelectedIndex = CountryComboBox.Items.IndexOf(person.Country);

                if (person.Sex == MaleRadioButton.Text)
                {
                    MaleRadioButton.Checked = true;
                }
                else if (person.Sex == FemaleRadioButton.Text)
                {
                    FemaleRadioButton.Checked = true;
                }

                if (person.Hobby.Count != 0)
                {
                    foreach (string name in person.Hobby)
                    {
                        if (name == gamesCB.Text)
                        {
                            gamesCB.Checked = true;
                            continue;
                        }
                        else if (name == readCB.Text)
                        {
                            readCB.Checked = true;
                            continue;
                        }
                        else if (name == footballCB.Text)
                        {
                            footballCB.Checked = true;
                            continue;
                        }
                        else
                        {
                            anotherCB.Checked = true;
                            anotherTB.Text = name;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("File does not exist!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-DOHINU4M\SQLEXPRESS;Initial Catalog=QuestionaryDB;Integrated Security=True";
            using(SqlConnection connection = new(connectionString))
            {
                try
                {
                    connection.Open();
                    if(connection.State == System.Data.ConnectionState.Open)
                    {
                        PersonInfo();

                        string PersonHobbies = "";
                        foreach(var hobbies in person.Hobby)
                        {
                            PersonHobbies += hobbies + " | ";
                        }
                        string queryText = $"INSERT INTO UserInfo([UserName],[UserSurName],[Age],[BirthDate],[Country],[Sex],[Hobby]) VALUES('{person.Name}','{person.SurName}','{person.Age}','{person.BirthDate}','{person.Country}','{person.Sex}','{PersonHobbies}')";                      
                        SqlCommand sqlCommand = new SqlCommand(queryText, connection);
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Process ended!");
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
