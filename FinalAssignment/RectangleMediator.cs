using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAssignment
{
    class RectangleMediator : Shape
    {
        
        int a, b, c, d, gh,hg;
        string fj;

        public void draw(int a, int b, int c, int d,int e,int f, int g, int h, int i, int j)
        {

            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
           
            // MessageBox.Show(this.a + " " + this.b + " " + this.c + " " + this.d + "On Mediator");

            RectangleForm recform = new RectangleForm(a, b, c, d);
            recform.Show();

        }

        public void ifParam(int a, int b, int c, int d,int e,int f, int counterValue)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            RectangleForm recform = new RectangleForm(a, b, c, d,counterValue);
            recform.Show();
        }

        public void repeatParam(int a, string b, int c)
        {
            this.gh = a; //repeat value
            this.hg = c; //increase value
            this.fj = b; //operator

            RectangleForm recform = new RectangleForm(gh,fj,hg);
            recform.Show();

        }
    }
}
