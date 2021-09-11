using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            picturePB.AllowDrop = true;
        }

        private void picturePB_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void picturePB_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if(data != null)
            {
                var fileName = data as string[];
                if(fileName.Length > 0)
                {
                    picturePB.Image = Image.FromFile(fileName[0]);
                }
            }
        }
    }
}
