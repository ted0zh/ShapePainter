using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova_rabota
{
    public partial class FormEditTriangle : Form
    {
        protected Triangle triangle;
        public Triangle Triangle
        {
            get
            {
                return triangle;
            }
            set
            {
                triangle = value;
                textBoxTrSide.Text = triangle.TrSide.ToString();
                buttonColor.BackColor = triangle.ColorFill;
            }
        }
        public FormEditTriangle()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                Triangle.TrSide = int.Parse(textBoxTrSide.Text);
                Triangle.ColorFill = buttonColor.BackColor;
            }
            catch
            {
                MessageBox.Show("Invalid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                buttonColor.BackColor = cd.Color;
            }
        }
    }
}
