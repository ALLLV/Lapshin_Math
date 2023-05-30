using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class Algebra
    {
        public static double[] SqrRootEquation(double a, double b, double c)
        {
            double x1;
            double x2;
            double D = Math.Pow(b, 2) - 4 * a * c;

            x1 = (-b + Math.Sqrt(D))/2 * a;
            x2 = (-b - Math.Sqrt(D)) / 2 * a;

            return new double[] { x1, x2 };
        }

        public static double LinearEquation(double a, double b)
        {
            return -(b / a);
        }

        public static double RowSum(double[] row)
        {
            return row.Sum();
        }

        public static double RowSum(List<double> row)
        {
            return row.Sum();
        }

        public static double RowMax(double[] row)
        {
            return row.Max();
        }

        public static double RowMax(List<double> row)
        {
            return row.Max();
        }

        public static double RowAvg(double[] row)
        {
            return row.Average();
        }

        public static double RowAvg(List<double> row)
        {
            return row.Average();
        }
    }
}
