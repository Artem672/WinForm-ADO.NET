using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        private Point startPosition;
        private Point currentPosition;
        bool drawing;
        List<Rectangle> rectangles = new List<Rectangle>();
        List<Line> lines = new List<Line>();
        private Rectangle GetRectangle()
        {
            return new Rectangle(Math.Min(startPosition.X, currentPosition.X),
                                 Math.Min(startPosition.Y, currentPosition.Y),
                                 Math.Abs(startPosition.X - currentPosition.X),
                                 Math.Abs(startPosition.Y - currentPosition.Y));
        }
        public Form1()
        {
            InitializeComponent();
            InitColors();
            drawListBox.SetItemChecked(0, true);
        }
        private void InitColors()
        {
            ArrayList ColorList = new ArrayList();
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static |
                                  BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (var item in propInfoList)
            {
                colorComboBox.Items.Add(item.Name);
            }
            colorComboBox.SelectedIndex = 0;
        }
        private void paintPanel_MouseDown(object sender, MouseEventArgs e)
        {
            startPosition = currentPosition = e.Location;
            drawing = true;
        }

        private void paintPanel_MouseMove(object sender, MouseEventArgs e)
        {
            currentPosition = e.Location;
            if (drawing)
            {
                paintPanel.Invalidate();
            }
        }

        private void paintPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                drawing = false;
                if (drawListBox.SelectedIndex == 0 || drawListBox.SelectedIndex == -1)
                {
                    var line = new Line()
                    {
                        Start = startPosition,
                        End = currentPosition,
                        Thickness = (float)changeThicknessNUD.Value,
                        Color = Color.FromName(colorComboBox.Items[colorComboBox.SelectedIndex].ToString())
                    };
                    lines.Add(line);
                    paintPanel.Invalidate();
                }
                else
                {
                    var rectangle = GetRectangle();
                    if (rectangle.Width > 0 && rectangle.Height > 0)
                    {
                        rectangles.Add(rectangle);
                        paintPanel.Invalidate();
                    }
                }
            }
        }

        private void paintPanel_Paint(object sender, PaintEventArgs e)
        {
            if (rectangles.Count > 0)
            {              
                e.Graphics.DrawRectangles(new Pen(Color.FromName(colorComboBox.Items[colorComboBox.SelectedIndex].ToString())), rectangles.ToArray());
            }
            if (lines.Count > 0)
            {
                lines.ForEach(l => l.Draw(e.Graphics));
            }
            if (drawListBox.SelectedIndex == 0)
            {
                if (drawing)
                {
                    e.Graphics.DrawLine(Pens.Red, startPosition, currentPosition);
                }
            }
            else
            {
                if (drawing)
                {
                    e.Graphics.DrawRectangle(Pens.Red, GetRectangle());
                }
            }
        }

        private void cleanPanelButton_Click(object sender, EventArgs e)
        {
            rectangles.Clear();
            paintPanel.Refresh();
        }

        private void drawListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = drawListBox.SelectedIndex;
            var count = drawListBox.Items.Count;

            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    drawListBox.SetItemChecked(i, false);
                }
            }

            if (drawListBox.Items[index].ToString() == "Pencil")
            {
                changeThicknessNUD.ReadOnly = false;
                changeThicknessNUD.Increment = 1;
            }
            else
            {
                changeThicknessNUD.ReadOnly = true;
                changeThicknessNUD.Increment = 0;
            }
        }
    }
}
