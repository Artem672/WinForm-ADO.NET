using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CleanPanel_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }

        private void ChangeThickness_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Pencil_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = Pencil.SelectedIndex;
            var count = Pencil.Items.Count;

            for (int i = 0; i < count; i++) 
            {
                if( index != i)
                {
                    Pencil.SetItemChecked(i, false);
                }               
            }
            
            if (Pencil.Items[Pencil.SelectedIndex].ToString() == "Pencil\t")
            {
                ChangeThickness.ReadOnly = false;
                ChangeThickness.Increment = 1;
            }
            else
            {
                ChangeThickness.ReadOnly = true;
                ChangeThickness.Increment = 0;
            }
        }

        private Point p1, p2;
        List<Point> p1List = new();
        List<Point> p2List = new();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (var p = new Pen(Color.Blue, 4))
            {
                for (int x = 0; x < p1List.Count; x++)
                {
                    e.Graphics.DrawLine(p, p1List[x], p2List[x]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (p1.X == 0)
            {
                p1.X = e.X;
                p1.Y = e.Y;
            }
            else
            {
                p2.X = e.X;
                p2.Y = e.Y;

                p1List.Add(p1);
                p2List.Add(p2);

                Invalidate();
                p1.X = 0;
            }
        }
    }
}
