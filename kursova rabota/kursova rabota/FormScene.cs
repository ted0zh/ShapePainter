using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using kursova_rabota;

namespace kursova_rabota
{
    public partial class FormScene : Form
    {
        private List<Shape> shapes = new List<Shape>();       

        public FormScene()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var s in shapes)
                s.Paint(e.Graphics);

           

            var centerPoint = new Point
            {
                X=Width/2,
                Y=Height/2
            };

            using(var pen =new Pen(Color.Black))
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                e.Graphics.DrawLine(pen, centerPoint.X, 0, centerPoint.X, Height);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                pen.Width = 2;
                e.Graphics.DrawEllipse(pen, centerPoint.X - 2, centerPoint.Y - 2, 4,4);
            }

        }
        private void SelectShapes(List<Shape> shapes)
        {
            foreach (var s in shapes)
                s.Selected = true;
            Invalidate();
        }

        private void FormScene_MouseDown(object sender, MouseEventArgs e)
        {
            Shape temp = null;
            if (e.Button == MouseButtons.Right)
                temp = new Rectangle()
                {              
                    Location = e.Location,
                    Width = 100,
                    Height=200
                };

         

            else if (e.Button == MouseButtons.Middle)

                temp = new Square()
                {
                    Location = e.Location,
                    Side=100

                };
            else
                for (int i = 0; i < shapes.Count(); i++)
                    shapes[i].Selected = false;
            for (int i = shapes.Count - 1; i >= 0; i--)
                if (shapes[i].PointInShape(e.Location))
                {
                    shapes[i].Selected = true;
                    toolStripStatusArea.Text = CalculateShapesArea().ToString();
                    toolStripStatusPerimeter.Text = CalculateShapesPerimeter().ToString();
                    break;
                }




            if (temp != null)
            {
                var random = new Random();
                temp.Location = e.Location;
                temp.ColorBorder = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                temp.ColorFill = Color.FromArgb(100, temp.ColorBorder);
                shapes.Add(temp);
            }
            Invalidate();
        }

        private double CalculateShapesArea()
        {
            var area = 0.0;
            for (int s = 0; s < shapes.Count(); s++)
                area += shapes[s].Area;

            return area;
        }

        private double CalculateShapesPerimeter()
        {
            var perimeter = 0.0;
            for (int s = 0; s < shapes.Count(); s++)
                perimeter += shapes[s].Perimeter;

            return perimeter;
        }
     
        private void FormScene_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.T) 
            {

                PointF[] coordinates = new PointF[3];

                coordinates[0].X = MousePosition.X;
                coordinates[0].Y = MousePosition.Y;

                coordinates[1].X = MousePosition.X + 60;
                coordinates[1].Y = MousePosition.Y + 60;

                coordinates[2].X = MousePosition.X - 60;
                coordinates[2].Y = MousePosition.Y + 60;

                Shape shape = new Triangle(coordinates)
                {
                    Location = MousePosition,
                };
                var random = new Random();
                shape.Location = MousePosition;
                shape.ColorBorder = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                shape.ColorFill = Color.FromArgb(100, shape.ColorBorder);
                shapes.Add(shape);

            }
            else if(e.KeyCode==Keys.C)
            {
                Shape shape = new Circle
                {
                    
                    Location = MousePosition,
                    Radius=100
                };
                var random = new Random();
                shape.Location = MousePosition;
                shape.ColorBorder = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                shape.ColorFill = Color.FromArgb(100, shape.ColorBorder);
                shapes.Add(shape);
            }
            
            else
            {
                for (int s = shapes.Count() - 1; s >= 0; s--)
                {
                    if (shapes[s].Selected)
                        shapes.RemoveAt(s);

                }
            }
            Invalidate();
        }

        private void FormScene_DoubleClick(object sender, EventArgs e)
        {
            foreach (var shape in shapes)
            {
                if (shape.Selected && shape.Tag == "rectangle")
                {
                    var fr = new FormEditRectangle();
                    fr.Rectangle = (Rectangle)shape;

                    fr.ShowDialog();
                    break;

                }
                else if (shape.Selected && shape.Tag == "square")
                {
                    var fs = new FormEditSquare();
                    fs.Square = (Square)shape;

                    fs.ShowDialog();
                    break;
                }
                else if (shape.Selected && shape.Tag == "triangle")
                {
                    var ft = new FormEditTriangle();
                    ft.Triangle = (Triangle)shape;

                    ft.ShowDialog();
                    break;
                }
                else if (shape.Selected && shape.Tag == "circle")
                {
                    var fc = new FormEditCircle();
                    fc.Circle = (Circle)shape;

                    fc.ShowDialog();
                    break;
                }
            }

            Invalidate();
        }
      
        private void FormScene_Load(object sender, EventArgs e)
        {
            if (!File.Exists("data"))
                return;
            IFormatter formatter = new BinaryFormatter();

            using (var fs = new FileStream("data", FileMode.Open))
                shapes = (List<Shape>)formatter.Deserialize(fs);
        }

        private void FormScene_FormClosing(object sender, FormClosingEventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();

            using (var fs = new FileStream("data", FileMode.Create))
                formatter.Serialize(fs, shapes);
        }

        
        private void leftToolStripMenuLeft_Click(object sender, EventArgs e)
        {
            var centerX = Width / 2;
            var LeftShapes = shapes.WhereContains(s => s.Location.X <= centerX);

            SelectShapes(LeftShapes);
        }

        private void rightToolStripMenuRight_Click(object sender, EventArgs e)
        {
            var centerX = Width / 2;
            var RightShapes = shapes.WhereContains(
                delegate (Shape s)
                {
                    return s.Location.X + s.Width > centerX;
                }
            );

            SelectShapes(RightShapes);
        }
    }
}
