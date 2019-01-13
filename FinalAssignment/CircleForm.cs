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
    /// class the is used for the display of circle shape
    /// </summary>
    public partial class CircleForm : Form
    {
        //variable declaration
        int a, b, c, d, gh, hg, counter;
        string fj;
        bool count = false;
        string counterExist = "no";

        /// <summary>
        /// constructor with 5 parameters
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        public CircleForm(int a, int b, int c, int d)
        {
            InitializeComponent();
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }


        /// <summary>
        /// constructor with 3 paramters
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public CircleForm(int a, string b, int c)
        {
            count = true;
            InitializeComponent();
            this.gh = a; //repeat value
            this.hg = c; //increase value
            this.fj = b; //operator
        }


        /// <summary>
        /// constructor with 5 parameters
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="counterValue"></param>
        public CircleForm(int a, int b, int c, int d, int counterValue)
        {

            InitializeComponent();
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.counter = counterValue;
            counterExist = "yes";
        }

        /// <summary>
        /// method that paints the shape with the given parameters to the
        /// constructors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Brush red = new SolidBrush(Color.Red);
            Pen redPen = new Pen(red, 8);

            if (counterExist == "yes")
            {
                g.DrawEllipse(redPen, this.a, this.b, this.c, this.d);

                g.DrawEllipse(redPen, this.a, this.b, this.c + counter, this.d + counter);
            }

            if (count == false)
            {
                //DrawEllipse method that draws the shape in panel in the 
                //current form
                g.DrawEllipse(redPen, this.a, this.b, this.c, this.d);
            }

            else
            {
                this.a = 100;
                this.b = 150;
                this.c = 60;
                this.d = 60;

                //checking if the operator sign is + or -
                if (fj == "+")
                {
                    for (int i = 0; i < gh; i++)
                    {
                        g.DrawEllipse(redPen, this.a, this.b, this.c, this.d);

                        this.a += 20;
                        this.b += 20;
                        this.c += hg;
                        this.d += hg;

                    }
                }

                //checking if the operator sign is + or -
                else if (fj == "-")
                {
                    for (int i = gh; i > 0; i--)
                    {
                        g.DrawEllipse(redPen, this.a, this.b, this.c, this.d);

                        this.a -= 20;
                        this.b -= 20;
                        this.c -= hg;
                        this.d -= hg;

                    }
                }
            }

        }
    }
}
