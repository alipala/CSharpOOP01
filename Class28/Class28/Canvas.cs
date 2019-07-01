using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class28
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
