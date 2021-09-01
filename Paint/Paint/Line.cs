using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public class Line 
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public float Thickness { get; set; }
        public Color Color { get; set; }

        public void Draw(Graphics g)
        {
            g.DrawLine(new Pen(Color, Thickness), Start, End);
        }
    }
}
