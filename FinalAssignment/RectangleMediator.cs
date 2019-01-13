using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAssignment
{

    /// <summary>
    /// a rectangle shape helper class that help to pass the 
    /// provided parameters to the form class
    /// </summary>
    class RectangleMediator : Shape
    {
        //variables declaration
        int a, b, c, d, gh,hg;
        string fj;


        /// <summary>
        /// implemented draw method from the shapes interface which helps draw the shape
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
