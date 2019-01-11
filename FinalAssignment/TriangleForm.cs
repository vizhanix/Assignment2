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

        int a, b, c, d, ce, f, gh, hg;
        string fj;
        bool count = false;

        public TriangleForm(int a, int b, int c, int d, int e, int f)
        {
            InitializeComponent();
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.ce = e;
            this.f = f;
        }

        public TriangleForm(int a, string b, int c)
        {
            count = true;
            InitializeComponent();
            this.gh = a; //repeat value
            this.hg = c; //increase value
            this.fj = b; //operator
        }

        private void TriangleForm_Load(object sender, EventArgs e)
        {

        }

        private void TriangleForm_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = panel1.CreateGraphics();
            Brush red = new SolidBrush(Color.Red);
            Pen redPen = new Pen(red, 8);

            if (count == false)
            {
                Point[] points = { new Point(this.a, this.b), new Point(this.c, this.d), new Point(this.ce, this.f) };
                g.DrawPolygon(redPen, points);
            }

            else
            {
                this.a = 100;
                this.b = 60;
                this.c = 130;
                this.d = 90;
                this.ce = 140;
                this.f = 45;

                if (fj == "+")
                {
                    for (int i = 0; i < gh; i++)
                    {
                        Point[] points = { new Point(this.a, this.b), new Point(this.c, this.d), new Point(this.ce, this.f) };
                        g.DrawPolygon(redPen, points);

                        this.a += hg;
                        this.b += hg;
                        this.c += hg;
                        this.d += hg;
                        this.ce += hg;
                        this.f += hg;

                    }
                }

                else if (fj == "-")
                {
                    for (int i = gh; i > 0; i--)
                    {
                        Point[] points = { new Point(this.a, this.b), new Point(this.c, this.d), new Point(this.ce, this.f) };
                        g.DrawPolygon(redPen, points);

                        this.a -= hg;
                        this.b -= hg;
                        this.c -= hg;
                        this.d -= hg;
                        this.ce -= hg;
                        this.f -= hg;

                    }



                }

            }
        }
    }
}
