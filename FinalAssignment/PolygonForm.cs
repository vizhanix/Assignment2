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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Brush red = new SolidBrush(Color.Red);
            Pen redPen = new Pen(red, 8);

            if (count == false)
            {
                Point[] points = { new Point(this.a, this.b), new Point(this.c, this.d), new Point(this.e, this.f) ,new Point(this.g,this.h),new Point(this.i,this.j)};
                g.DrawPolygon(redPen, points);
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
