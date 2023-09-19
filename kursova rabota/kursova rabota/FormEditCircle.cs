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
    public partial class FormEditCircle : Form
    {
        protected Circle circle;
        public Circle Circle
        {
            get
            {
                return circle;
            }
            set
            {
                circle = value;
                textBoxRadius.Text = circle.Radius.ToString();
                buttonColor.BackColor = circle.ColorFill;
            }
        }

        public FormEditCircle()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                Circle.Radius = int.Parse(textBoxRadius.Text);
                Circle.ColorFill = buttonColor.BackColor;
            }
            catch
            {
                MessageBox.Show("Invalid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if(cd.ShowDialog()==DialogResult.OK)
            {
                buttonColor.BackColor = cd.Color;
            }
        }
    }
}
