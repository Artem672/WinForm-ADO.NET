using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolStation
{
    public partial class Form2 : Form
    {
        private readonly Form1 _frm;
        public Form2(Form1 frm)
        {
           _frm = frm;
            InitializeComponent();
        }

        private void clearYes_Click(object sender, EventArgs e)
        {
            _frm.Enabled = true;
            _frm.MakeFieldsDefault();
            this.Close();           
        }

        private void clearNo_Click(object sender, EventArgs e)
        {           
            timer1.Start();         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _frm.Enabled = true;
            _frm.MakeFieldsDefault();
            this.Close();          
        }
    }
}
