using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAssignment
{
    public partial class CircleForm : Form
    {

        int a, b, c, d;

        public CircleForm(int a, int b, int c, int d)
        {
            InitializeComponent();
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Brush red = new SolidBrush(Color.Red);
            Pen redPen = new Pen(red, 8);

            g.DrawEllipse(redPen, this.a, this.b, this.c, this.d);
        }
    }
}
