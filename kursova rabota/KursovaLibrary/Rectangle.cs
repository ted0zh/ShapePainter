using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace kursova_rabota
{
    [Serializable]
    public class Rectangle:Shape
    {   
        public override string Tag
        {
            get
            {
                return "rectangle";
            }
        }
        public override void Paint(Graphics graphics)
        {
            var colorborder = Selected
                ? Color.Red
                : Color;

          

            using (var brush = new SolidBrush(ColorFill))
                graphics.FillRectangle(brush, Location.X, Location.Y, Width, Height);


            using (var pen = new Pen(colorborder))
                graphics.DrawRectangle(pen, Location.X, Location.Y, Width, Height);
        }

        public override bool PointInShape(Point point)
        {
            return Location.X <= point.X && point.X <= Location.X + Width &&
                Location.Y <= point.Y && point.Y <= Location.Y + Height;

        }

       
        public override double Perimeter 
        {
            get
            {
                return 2*(Width + Height);
            }
        }

        public override double Area
        {
            get
            {
                return Width * Height;
            }
        }
    }
}

