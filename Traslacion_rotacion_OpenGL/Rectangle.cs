using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Traslacion_rotacion_OpenGL
{
    class Rectangle
    {
        public Color color;
        public List<decimal[]> points = new List<decimal[]>();
        public decimal[,] matrix=FactoryMatrix.getIdentity();

        public Rectangle()
        {
            points.Add(new decimal[4]);
            points.Add(new decimal[4]);
            points.Add(new decimal[4]);
            points.Add(new decimal[4]);

            points[0][3] = 1;
            points[1][3] = 1;
            points[2][3] = 1;
            points[3][3] = 1;
        }
    }
}

