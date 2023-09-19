using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace kursova_rabota
{
    [Serializable]
    public class Square:Shape
    {
        public override string Tag
        {
            get
            {
                return "square";
            }
        }
        public override void Paint(Graphics graphics)
        {
            var colorborder = Selected
                ? Color.Red
                : Color;

          

            using (var brush = new SolidBrush(ColorFill))
                graphics.FillRectangle(brush, Location.X, Location.Y, Side, Side);


            using (var pen = new Pen(colorborder))
                graphics.DrawRectangle(pen, Location.X, Location.Y, Side, Side);
        }

        public override bool PointInShape(Point point)
        {
            return Location.X <= point.X && point.X <= Location.X + Side &&
                Location.Y <= point.Y && point.Y <= Location.Y + Side;

        }


        public override double Perimeter
        {
            get
            {
                return 4 * Side;
            }
        }

        public override double Area
        {
            get
            {
                return Side * Side;
            }
        }
    }
}

