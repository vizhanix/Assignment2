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
    public partial class PolygonForm : Form
    {
        int a, b, c, d,e,f,g,h,i,j, gh, hg;
        string fj;
        bool count = false;
        string counterExist = "no";

        public PolygonForm(int a,int b,int c,int d,int e,int f,int g,int h,int i,int j)
        {
            InitializeComponent();
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
            this.g = g;
            this.h = h;
            this.i = i;
            this.j = j;
        }

        public PolygonForm(int a, string b, int c)
        {
            count = true;
            InitializeComponent();
            this.gh = a; //repeat value
            this.hg = c; //increase value
            this.fj = b; //operator
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Brush red = new SolidBrush(Color.Red);
            Pen redPen = new Pen(red, 8);

            if (count == false)
            {
                Point[] points = { new Point(this.a, this.b), new Point(this.c, this.d), new Point(this.e, this.f) ,new Point(this.g,this.h),new Point(this.i,this.j),new Point(350,200),new Point(250,250)};
                g.DrawPolygon(redPen, points);
            }

            else
            {
                this.a = 50;
                this.b = 50;
                this.c = 100;
                this.d = 30;
                this.e = 200;
                this.f = 10;
                this.g = 250;
                this.h = 50;
                this.i = 300;
                this.j = 100;

                if (fj == "+")
                {
                    for (int i = 0; i < gh; i++)
                    {
                        //g.DrawRectangle(redPen, this.a, this.b, this.c, this.d);

                        Point[] points = { new Point(this.a, this.b), new Point(this.c, this.d), new Point(this.e, this.f), new Point(this.g, this.h), new Point(this.i, this.j), new Point(350, 200), new Point(250, 250) };
                        g.DrawPolygon(redPen, points);

                        this.a += hg;
                        this.b += hg;
                        this.c += hg;
                        this.d += hg;
                        this.e += hg;
                        this.f += hg;
                        this.g += hg;
                        this.h += hg;
                        this.i += hg;
                        this.j += hg;

                    }
                }

                else if (fj == "-")
                {
                    for (int i = gh; i > 0; i--)
                    {
                        g.DrawRectangle(redPen, this.a, this.b, this.c, this.d);

                        this.a -= 20;
                        this.b -= 20;
                        this.c -= hg;
                        this.d -= hg;

                    }
                }



            }

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void PolygonForm_Load(object sender, EventArgs e)
        {

        }
    }
}
