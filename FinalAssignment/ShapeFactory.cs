using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAssignment
{
    class ShapeFactory
    {
        public Shape GetShape(string shapeType)
        {
            if ((shapeType.Equals("rectangle", StringComparison.InvariantCultureIgnoreCase)) == true)
            {
               return new RectangleMediator();
            }

            return null;
        }
    }
}
