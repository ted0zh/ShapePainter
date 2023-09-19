using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace kursova_rabota
{
    [Serializable]
    public class Triangle : Shape
    {
        public override string Tag
        {
            get
            {
                return "triangle";
            }
        }
        public Triangle(PointF[] trainglePoints)
        {
            TrianglePoints = trainglePoints;
        }
        public override void Paint(Graphics graphics)
        {
            var colorOfBorder = Selected
               ? Color.Red
               : Color;

            using (Brush brush = new SolidBrush(ColorFill))
            {
                graphics.FillPolygon(brush, TrianglePoints);
            }
            using (Pen pen = new Pen(colorOfBorder))
            {
                graphics.DrawPolygon(pen, TrianglePoints);
            }
        }

        public override bool PointInShape(Point point)
        {
            return Location.X - 50 <= point.X && point.X - 50 <= Location.X &&
                   Location.Y <= point.Y && point.Y <= Location.Y + 50;
        }

        public override double Perimeter
        {
            get
            {
                return 3 * TrSide;
            }
        }
        public override double Area
        {

            get
            {
                return Math.Sqrt(3) / 4 * (TrSide * TrSide);
            }
        }
    }
}
