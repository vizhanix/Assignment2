﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment
{
    class TriangleMediator : Shape
    {
        int a, b, c, d,e,f;

        public void draw(int a, int b, int c, int d,int e,int f)
        {

            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;

            TriangleForm recform = new TriangleForm(a, b, c, d,e,f);
            recform.Show();

        }
    }
}
