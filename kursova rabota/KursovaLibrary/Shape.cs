using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using kursova_rabota.Exceptions;


namespace kursova_rabota
{
    [Serializable]
    public abstract class Shape
    {
        private int _TrSide;
        public int TrSide 
        {
            get => _TrSide;
            set
            {
                if (value < 0)
                    throw new InvalidValueException("Invalid value");
                _TrSide = value;
            }
        }
        public Point p2 { get; set; }
        public Point p3 { get; set; }

        private int _Side;
        public int Side 
        {
            get => _Side;
            set
            {
                if (value < 0)
                    throw new InvalidValueException("Invalid value");
                _Side = value;
            }
        }
        private int _height;
        public int Height 
        {
            get => _height;
            set
            {
                if (value < 0)
                    throw new InvalidValueException("Invalid value");
                _height = value;
            }
            
        }

        private int _width;
        public int Width 
        {
            get => _width;
            set
            {
                if (value < 0)
                    throw new InvalidValueException("Invalid value");
                _width = value;
            }
        }

        private float _radius;
        public float Radius 
        {
            get => _radius;
            set
            {
                if (value < 0)
                    throw new InvalidValueException("Invalid value");
                _radius = value;
            }
        }
        public virtual string Tag {get;}
        public Point Location { get; set; }
        public Color Color { get; set; }
        public Color ColorFill { get; set; }
        public Color ColorBorder { get; set; }
        [NonSerialized]
        private bool _selected;
        public bool Selected

        {
            get => _selected;

            set => _selected = value;
        }

        public abstract double Area { get; }
        public abstract double Perimeter { get; }
        public abstract bool PointInShape(Point point);
        public abstract void Paint(Graphics graphics);
        public PointF[] TrianglePoints { get; set; }
    }
}
