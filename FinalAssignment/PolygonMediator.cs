using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment
{
    class PolygonMediator : Shape
    {
        int a, b, c, d,e,f,g,h,i,j, gh, hg;
        string fj;

        public void draw(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j)
        {
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

            PolygonForm recform = new PolygonForm(a, b, c, d,e,f,g,h,i,j);
            recform.Show();

        }

        public void ifParam(int a, int b, int c, int d, int e,int f,int counterValue)
        {
            throw new NotImplementedException();
        }

        public void repeatParam(int a, string b, int c)
        {
            this.gh = a; //repeat value
            this.hg = c; //increase value
            this.fj = b; //operator

           PolygonForm recform = new PolygonForm(gh, fj, hg);
            recform.Show();
        }
    }
}
