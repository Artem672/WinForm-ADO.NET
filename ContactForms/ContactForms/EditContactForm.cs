using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactForms
{
    public partial class EditContactForm : Form
    {
        public Form1 contactForm { get; set; }
        public EditContactForm(Form1 f)
        {
            InitializeComponent();
            contactForm = f;
            nameTB.Text = contactForm.Person.Name;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            contactForm.Person.Name = nameTB.Text;
            contactForm.Person.Surname = surnameTB.Text;
            contactForm.Person.PhoneNumber = numberTB.Text;
            
            contactForm.Controls["nameTB"].Text = nameTB.Text;
            contactForm.Controls["surnameTB"].Text = surnameTB.Text;
            this.Close();            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        { 
            this.Close();
        }
    }
}
