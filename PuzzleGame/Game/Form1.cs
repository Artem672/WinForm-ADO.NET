using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Image Img { get; set; }
        public Label Label
        {
            get
            {
                return label1;
            }
        }
        public Form1()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Png|*.png|Jpg|*.jpg|Ico|*.ico";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Img = Image.FromFile(openFileDialog1.FileName);
                Game gm = new Game(this);
                this.Hide();
                if (gm.ShowDialog() == DialogResult.Cancel)
                    this.Show();
            }
        }
    }
}
