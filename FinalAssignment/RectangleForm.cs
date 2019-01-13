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
    /// class that helps print the rectangle shape
    /// </summary>
    public partial class RectangleForm : Form
    {
        //variables declaration
        int a,b,c,d,gh,hg,counter;
        string fj;
        bool count = false;
        string counterExist = "no";

        /// <summary>
        /// constructor with 4 parameters to draw a regular rectangle according
        /// to the parameters provided
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        public RectangleForm(int a, int b, int c, int d)
        {
            InitializeComponent();
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        /// <summary>
        /// constructor with 5 parameters
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="counterValue"></param>
        public RectangleForm(int a, int b, int c, int d,int counterValue)
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
        /// constructors with the parameters that has the values
        /// which has the info about the repeatition of the shape
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public RectangleForm(int a, string b, int c)
        {
            count = true;
            InitializeComponent();
            this.gh = a; //repeat value
            this.hg = c; //increase value
            this.fj = b; //operator
        }
        


        /// <summary>
        /// the paint method which paints the rectangle shape
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Paint(object sender, PaintEventArgs e)
        {           

            Graphics g = panel1.CreateGraphics();
            Brush red = new SolidBrush(Color.Red);
            Pen redPen = new Pen(red, 8);

            if(counterExist == "yes")
            {
                g.DrawRectangle(redPen, this.a, this.b, this.c, this.d);

                g.DrawRectangle(redPen, this.a, this.b, this.c + counter, this.d + counter);
            }

            if (count == false) {
         
                g.DrawRectangle(redPen, this.a, this.b, this.c, this.d);
            }

            else
            {
                this.a = 100;
                this.b = 150;
                this.c = 60;
                this.d = 60;

                if(fj == "+")
                {
                    for (int i = 0; i < gh; i++)
                    {
                        g.DrawRectangle(redPen, this.a, this.b, this.c, this.d);

                        this.a += 20;
                        this.b += 20;
                        this.c += hg;
                        this.d += hg;

                    }
                }

                else if (fj == "-")
                {
                    for (int i = gh; i > 0; i--)
                    {
                        g.DrawRectangle(redPen, this.a, this.b, this.c, this.d);

                        this.a -= 20;
                        this.b -= 20;
                        this.c -= hg;
                        this.d -= hg;

                    }
                }

              
 
            }         
            
        }

       

        private void RectangleForm_Load(object sender, EventArgs e)
        {

        }

    }
}
