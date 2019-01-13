using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment
{

    /// <summary>
    /// a mediator class for the polygon shape that 
    /// calls the polygon form class to draw the shape in 
    /// a panel in another form
    /// </summary>
    class PolygonMediator : Shape
    {
        //variables declaration
        int a, b, c, d,e,f,g,h,i,j, gh, hg;
        string fj;


        /// <summary>
        /// implemented draw method form the interface shape
        /// that takes in the parameters to draw a polygon
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <param name="f"></param>
        /// <param name="g"></param>
        /// <param name="h"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
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


        //a method that checks the if statement in codeeditor with the command IF
        public void ifParam(int a, int b, int c, int d, int e,int f,int counterValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// method that helps print the particular shape to repeat
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
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
