using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public  class Trigonometry
    {
        public static double Sin(double angle)
        {
            return Math.Sin(angle);
        }
        public static double Cos(double angle)
        {
            return Math.Cos(angle);
        }
        public static double Tan(double angle)
        {
            return Math.Tan(angle);
        }
        public static double Ctg(double angle)
        {
            return 1 / Math.Tan(angle);
        }
        public static double ArcSin(double x)
        {
            return Math.Asin(x);
        }
    }
}
