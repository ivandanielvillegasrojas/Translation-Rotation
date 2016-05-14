using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traslacion_rotacion_OpenGL
{
    public static class FactoryMatrix
    {
        public static decimal[,] getIdentity()
        {
            decimal[,] matrix = new decimal[4, 4];
            matrix[0, 0] = 1;
            matrix[0, 1] = 0;
            matrix[0, 2] = 0;
            matrix[0, 3] = 0;
            matrix[1, 0] = 0;
            matrix[1, 1] = 1;
            matrix[1, 2] = 0;
            matrix[1, 3] = 0;
            matrix[2, 0] = 0;
            matrix[2, 1] = 0;
            matrix[2, 2] = 1;
            matrix[2, 3] = 0;
            matrix[3, 0] = 0;
            matrix[3, 1] = 0;
            matrix[3, 2] = 0;
            matrix[3, 3] = 1;

            return matrix;
        }

        public static decimal[,] getReflexion(bool x, bool y, bool z)
        {
            decimal[,] matrix = getIdentity();

            if (x)
                matrix[0, 0] = -1;
            if (y)
                matrix[1, 1] = -1;
            if (z)
                matrix[2, 2] = -1;

            return matrix;
        }

        public static decimal[,] getTrans(decimal tx, decimal ty, decimal tz)
        {
            decimal[,] matrix = getIdentity();

            matrix[0, 3] = tx;
            matrix[1, 3] = ty;
            matrix[2, 3] = tz;

            return matrix;
        }

        public static decimal[,] getScale(decimal sx, decimal sy, decimal sz)
        {
            decimal[,] matrix = getIdentity();

            matrix[0, 0] = sx;
            matrix[1, 1] = sy;
            matrix[2, 2] = sz;

            return matrix;
        }

        public static decimal[,] getRotX(decimal tita)
        {
            decimal[,] matrix = getIdentity();
            Double cosx = Math.Cos(Decimal.ToDouble(tita));
            Double sinx = Math.Sin(Decimal.ToDouble(tita));

            matrix[1, 1] = new Decimal(cosx);
            matrix[1, 2] = new Decimal(-sinx);
            matrix[2, 1] = new Decimal(sinx);
            matrix[2, 2] = new Decimal(cosx);

            return matrix;
        }

        public static decimal[,] getRotY(decimal tita)
        {
            decimal[,] matrix = getIdentity();
            Double cosx = Math.Cos(Decimal.ToDouble(tita));
            Double sinx = Math.Sin(Decimal.ToDouble(tita));

            matrix[0, 0] = new Decimal(cosx);
            matrix[0, 2] = new Decimal(sinx);
            matrix[2, 0] = new Decimal(-sinx);
            matrix[2, 2] = new Decimal(cosx);

            return matrix;
        }

        public static decimal[,] getRotZ(decimal tita)
        {
            decimal[,] matrix = getIdentity();
            Double cosx = Math.Cos(Decimal.ToDouble(tita));
            Double sinx = Math.Sin(Decimal.ToDouble(tita));

            matrix[0, 0] = new Decimal(cosx);
            matrix[0, 1] = new Decimal(-sinx);
            matrix[1, 0] = new Decimal(sinx);
            matrix[1, 1] = new Decimal(cosx);

            return matrix;
        }


        public static decimal[,] xMxM(decimal[,] m2, decimal[,] m1)
        {
            int il = m1.GetLength(0);
            int jl = m1.GetLength(0);
            int kl = m1.GetLength(0);
            decimal[,] matrix = new decimal[4, 4];

            for (int i = 0; i < il; i++)
            {
                for (int j = 0; j < jl; j++)
                {
                    for (int k = 0; k < kl; k++)
                    {
                        matrix[i, k] += (m2[i, j] * m1[j, k]);
                    }
                }
            }
            return matrix;
        }

        public static decimal[] xVxM(decimal[,] m, decimal[] v)
        {
            int il = m.GetLength(0);
            int jl = m.GetLength(0);
            decimal[] vector = new decimal[4];

            for (int i = 0; i < il; i++)
            {
                vector[i] = 0;
                for (int j = 0; j < jl; j++)
                {
                    vector[i] += (m[i, j] * v[j]);
                }
            }
            return vector;
        }
    }
}