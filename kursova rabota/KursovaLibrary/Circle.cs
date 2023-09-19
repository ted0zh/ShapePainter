using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace kursova_rabota
{
    [Serializable]
    public class Circle : Shape
    { 
        public override string Tag
        {
            get
            {
                return "circle";
            }
        }
        public override void Paint(Graphics graphics)
        {
            var colorBorder = Selected
                   ? Color.Red
                   : Color;

            using (var brush = new SolidBrush(ColorFill))
                graphics.FillEllipse(brush, Location.X, Location.Y, 2 * Radius, 2 * Radius);

            using (var pen = new Pen(colorBorder))
                graphics.DrawEllipse(pen, Location.X, Location.Y, 2 * Radius, 2 * Radius);
        }

        public override bool PointInShape(Point point)
        {
            return
             Location.X <= point.X && point.X <= Location.X + Radius &&
             Location.Y <= point.Y && point.Y <= Location.Y + Radius;
        }

        public override double Area
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }

        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * Radius;
            }
        }


    }
}
