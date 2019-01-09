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
    public partial class TriangleForm : Form
    {

        int a, b, c, d,ce,f;

        public TriangleForm(int a, int b, int c, int d,int e,int f)
        {
            InitializeComponent();
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.ce = e;
            this.f=f;
        }

        private void TriangleForm_Load(object sender, EventArgs e)
        {

        }

        private void TriangleForm_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = panel1.CreateGraphics();
            Brush red = new SolidBrush(Color.Red);
            Pen redPen = new Pen(red, 8);

           // g.DrawRectangle(redPen, this.a, this.b, this.c, this.d);

            Point[] points = { new Point(this.a, this.b), new Point(this.c, this.d), new Point(this.ce, this.f) };
            g.DrawPolygon(redPen, points);
        }
    }
}
