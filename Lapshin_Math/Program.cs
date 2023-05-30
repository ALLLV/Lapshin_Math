using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMath;

namespace Lapshin_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] a = Algebra.SqrRootEquation(-1, 4, 4);
            foreach (var item in a)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        } 
    }
}
