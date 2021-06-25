using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            label1.Location = RandomPosition();
        }

        private Point RandomPosition()
        {
            Random random = new();
            int x = (random.Next(1, this.Width));
            int y = (random.Next(1, this.Height));

            if(x >= (this.Width / 2))
            {
                return new Point(x - label1.Width, y);
            }
            else
            {
                return new Point(x , y);
            }

            return new Point(0, 0);
        }
    }
}
