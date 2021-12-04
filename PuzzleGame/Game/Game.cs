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
    public partial class Game : Form
    {
        Bitmap[] CutImage(Bitmap bmp, int w, int h)
        {
            int nX = 6, nY = 4;
            int n = nX * nY;
            Bitmap[] arr = new Bitmap[n];
            for (int i = 0; i < nY; i++)
                for (int j = 0; j < nX; j++)
                    arr[j + i * nX] = new Bitmap(bmp.Clone(new Rectangle(j * w, i * h, w, h), bmp.PixelFormat));
            return arr;
        }
        Form1 parent;
        static Random rnd = new Random();
        Bitmap[] bmm = null;
        public Game(Form1 form)
        {
            InitializeComponent();
            foreach (var item in this.Controls)
                (item as PictureBox).AllowDrop = true;
            parent = form;
            Bitmap bm = new Bitmap(form.Img);
            bmm = CutImage(bm, form.Img.Size.Width / 6, form.Img.Size.Height / 4);

            int[] numbers = new int[24];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = -1;
            for (int i = 0, j; i < this.Controls.Count - 1; i++)
            {
                do
                {
                    j = rnd.Next(0, 24);
                } while (numbers.Contains(j));
                numbers[i] = j;
                (this.Controls[j] as PictureBox).Image = bmm[i];
            }
        }
        private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            bool isWin = true;
            object bm = e.Data.GetData(DataFormats.Bitmap);
            foreach (var item in this.Controls)
                if ((item as PictureBox).Image == (Bitmap)bm)
                    (item as PictureBox).Image = (sender as PictureBox).Image;
            (sender as PictureBox).Image = (Bitmap)bm;
            for (int i = 0; i < this.Controls.Count - 1; i++)
                if ((this.Controls[i] as PictureBox).Image != bmm[i])
                    isWin = false;
            if (isWin)
            {
                parent.Label.Text = "You Win!";
                parent.Label.Location = new Point(214, 9);
                pictureBox25.Image = parent.Img;
                pictureBox25.BringToFront();
                timer1.Start();
            }
        }
        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as PictureBox).DoDragDrop((sender as PictureBox).Image, DragDropEffects.Move);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
