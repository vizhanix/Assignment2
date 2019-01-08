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

        int a, b, c, d;

        public void draw(int a, int b, int c, int d)
        {

            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            MessageBox.Show(this.a + " " + this.b + " " + this.c + " " + this.d + "On Mediator");

            RectangleForm recform = new RectangleForm(a, b, c, d);
            recform.Show();

        }
    }
}
