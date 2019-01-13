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

    /// <summary>
    /// form class that is used to draw the triangle shape in the panel
    /// </summary>
    public partial class TriangleForm : Form
    {
        //variables declaration  field
        int a, b, c, d, ce, f, gh, hg,counter;
        string fj;
        bool count = false;
        string counterExist = "no";

        /// <summary>
        /// constructor that takes the passed values inorder to draw the required shape
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <param name="f"></param>
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

        /// <summary>
        /// constructor that takes the passed values inorder to draw the required shape
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public TriangleForm(int a, string b, int c)
        {
            count = true;
            InitializeComponent();
            this.gh = a; //repeat value
            this.hg = c; //increase value
            this.fj = b; //operator
        }

        /// <summary>
        /// constructor that takes the passed values inorder to draw the required shape
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <param name="f"></param>
        /// <param name="counterValue"></param>
        public TriangleForm(int a, int b, int c, int d, int e,int f,int counterValue)
        {

            InitializeComponent();
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.ce = e;
            this.f = f;
            this.counter = counterValue;
            counterExist = "yes";
        }

        private void TriangleForm_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// method that draws the triangle shape with the values in the parameter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TriangleForm_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = panel1.CreateGraphics();
            Brush red = new SolidBrush(Color.Red);
            Pen redPen = new Pen(red, 8);

            if (counterExist == "yes")
            {

                Point[] points = { new Point(this.a, this.b), new Point(this.c, this.d), new Point(this.ce, this.f) };
                g.DrawPolygon(redPen, points);

                Point[] points1 = { new Point(this.a + counter, this.b + counter), new Point(this.c + counter, this.d + counter), new Point(this.ce + counter, this.f + counter) };
                g.DrawPolygon(redPen, points1);

            }

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
