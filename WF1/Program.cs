using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowForm();

            Console.ReadLine();
        }
        #region First-Second

        
        static int ClickedTime = 0;

        private static void ShowForm()
        {
            int fWidth, fHeight, bWidth, bHeight;
            string fColor;

            Console.Write("Enter form width -> ");
            fWidth = int.Parse(Console.ReadLine());
            Console.Write("\nEnter form height -> ");
            fHeight = int.Parse(Console.ReadLine());
            Console.Write("\nEnter button width -> ");
            bWidth = int.Parse(Console.ReadLine());
            Console.Write("\nEnter button height -> ");
            bHeight = int.Parse(Console.ReadLine());
            Console.Write("\nEnter form background color -> ");
            fColor = Console.ReadLine();

            var form = new Form();
            form.Width = fWidth;
            form.Height = fHeight;
            form.BackColor = Color.FromName(fColor);

            var button = new Button();
            button.Width = bWidth;
            button.Height = bHeight;
            button.Location = new Point(form.ClientSize.Width / 2 - button.Width / 2, form.ClientSize.Height / 2 - button.Height / 2);
            button.Text = "Press me";
            button.Click += Button_Click;

            form.Controls.Add(button);
            form.ShowDialog();

        }

        private static void Button_Click(object sender, EventArgs e)
        {
            ClickedTime++;

            var obj = (sender as Button);
            var random = new Random();
            Color c;

            c = Color.FromArgb((int)(0xFF000000 + (random.Next(0xFFFFFF) & 0x7F7F7F)));
            obj.Parent.Text = $"Button was clicked {ClickedTime} times!";
            obj.BackColor = c;
        }

        #endregion
    }
}
