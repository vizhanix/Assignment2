using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment
{
    class CircleMediator : Shape
    {
        int a, b, c, d ,gh,hg;
        string fj;

        public void draw(int a, int b, int c, int d,int e,int f)
        {

            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;

            // MessageBox.Show(this.a + " " + this.b + " " + this.c + " " + this.d + "On Mediator");

            CircleForm recform = new CircleForm(a, b, c, d);
            recform.Show();

        }

        public void repeatParam(int a, string b, int c)
        {
            this.gh = a; //repeat value
            this.hg = c; //increase value
            this.fj = b; //operator

            CircleForm recform = new CircleForm(gh, fj, hg);
            recform.Show();
        }
    }
}
