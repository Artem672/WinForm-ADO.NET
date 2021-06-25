using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF1._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddOpacity_Click(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
        }

        private void MinOpacity_Click(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
        }
    }
}
