using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF1._2
{
    public partial class ChangedName : Form
    {
        public ChangedName()
        {
            InitializeComponent();
        }

        private void ChangedName_Load(object sender, EventArgs e)
        {

        }

        static int FirstButtonClick = 0;
        static int SecondButtonClick = 0;

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            FirstButtonClick++;
            label2.Text = $"Button was clicked : {FirstButtonClick} times!";
            label2.Refresh();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void SecondButton_Click_1(object sender, EventArgs e)
        {
            SecondButtonClick++;
            label3.Text = $"Button was clicked : {SecondButtonClick} times!";
            label3.Refresh();
        }
    }
}
