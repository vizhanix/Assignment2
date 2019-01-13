using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAssignment
{

    /// <summary>
    /// a shapefactory class which returns the mediator class object 
    /// </summary>
    class ShapeFactory
    {
        public Shape GetShape(string shapeType)
        {
            if ((shapeType.Equals("rectangle", StringComparison.InvariantCultureIgnoreCase)) == true)
            {
               return new RectangleMediator();
            }

            if ((shapeType.Equals("circle", StringComparison.InvariantCultureIgnoreCase)) == true)
            {
                return new CircleMediator();
            }

            if ((shapeType.Equals("triangle", StringComparison.InvariantCultureIgnoreCase)) == true)
            {
                return new TriangleMediator();
            }

            if ((shapeType.Equals("polygon", StringComparison.InvariantCultureIgnoreCase)) == true)
            {
                return new PolygonMediator();
            }

            return null;
        }
    }
}
