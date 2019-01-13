using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment
{

    /// <summary>
    /// class that expends the shape interface which is a medium that calls another reference to show the graphics
    /// </summary>
    class CircleMediator : Shape
    {
        //variables declaration
        int a, b, c, d ,gh,hg;
        string fj;


        /// <summary>
        /// method with 10 parameters when a simple draw
        /// command is passed in the text editor
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

            CircleForm recform = new CircleForm(a, b, c, d);
            recform.Show();

        }


        /// <summary>
        /// method with 7 parameters that is used when the if command is executed in the 
        /// text editor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <param name="f"></param>
        /// <param name="counterValue"></param>
        public void ifParam(int a, int b, int c, int d,int e,int f, int counterValue)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            CircleForm recform = new CircleForm(a, b, c, d, counterValue);
            recform.Show();
        }

        /// <summary>
        /// method with 3 parameters that is used when the repeat command 
        /// is typed in the texteditor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
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
