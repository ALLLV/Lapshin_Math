using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMath;
using System;
using System.Linq;

namespace MathTest
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        public void Sin_PIdiv2_Is1()
        {
            double expecting = 1;
            double actual = Trigonometry.Sin(Math.PI / 2);

            Assert.AreEqual(expecting, actual);
        }
    }
}
