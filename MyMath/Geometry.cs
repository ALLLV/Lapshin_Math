using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class Geometry
    {
        public static double TriangleArea(double tbase, double height)
        {
            return 0.5 * tbase * height;
        }
        public static double SqrTriangleArea(double a, double b)
        {
            return 0.5 * a * b;
        }
        public static double RectangleArea(double a, double b)
        {
            return a * b;
        }
        public static double CircleArea(double rad)
        {
            return Math.Pow(rad, 2) * Math.PI;
        }

        public static double TrapqzoidArea(double a, double b, double height)
        {
            return 0.5 * (a + b) * height;
        }
    }
}
