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
    public partial class RectangleForm : Form
    {

        int a,b,c,d;

        public RectangleForm(int a, int b, int c, int d)
        {
            InitializeComponent();
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            MessageBox.Show(this.a + " " + this.b + " " + this.c + " " + this.d + "New Values");

            Graphics g = panel1.CreateGraphics();
            Brush red = new SolidBrush(Color.Red);
            Pen redPen = new Pen(red, 8);

           // g.DrawLine(redPen, this.a, this.b, this.c, this.d);
            g.DrawRectangle(redPen, this.a, this.b, this.c, this.d);
        }

       

        private void RectangleForm_Load(object sender, EventArgs e)
        {

        }

    }
}
