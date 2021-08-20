using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactForms
{
    public partial class Form1 : Form
    {
        Person person;
        internal Person Person 
        {
            get
            {
                return person;
            }
            set
            {
                person = value;     
            }
        }

        public EditContactForm editForm;
        public Form1()
        {
            InitializeComponent();
            Person = new Person();
        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {
            this.person.Name = nameTB.Text;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editForm = new EditContactForm(this);
            editForm.Show();
        }

        private void numberButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Person.PhoneNumber);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "txt files (*.txt)|*.txt|RTF files (*.rtf)|*.rtf";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string ContactInfo = Person.Name + ' ' + Person.Surname + ' ' + Person.PhoneNumber;
                File.WriteAllText(saveFile.FileName, ContactInfo);
            }
        }
    }
}
