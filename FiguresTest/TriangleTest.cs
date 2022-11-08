using NUnit.Framework;
using Figures;
using System;

namespace FiguresTest
{
    public class TriangleTest
    {
        [Test]
        public void NegativeParameterTriangleTest()
        {
            Assert.Catch<ArgumentException>(() => new Triangle(-1d, 5d, 3d));
            Assert.Catch<ArgumentException>(() => new Triangle(1d, -5d, 3d));
            Assert.Catch<ArgumentException>(() => new Triangle(1d, 5d, -3d));
            Assert.Catch<ArgumentException>(() => new Triangle(1d, 0d, 3d));
        }

        [Test]
        public void WrongSidesTriangleTest()
        {
            Assert.Catch<ArgumentException>(() => new Triangle(2d, 2d, 10d));
        }

        [Test]
        public void GetAreaTest()
        {
            var triangle = new Triangle(3d, 4d, 5d);
            double area = triangle.GetFigureArea();
            double expectedArea = 6d;

            Assert.AreEqual(expectedArea, area);
        }

        [Test]
        public void RightTriangleTest()
        {
            var triangle = new Triangle(3d, 4d, 5d);

            Assert.AreEqual(true, triangle.IsRightTriangle);
        }

        [Test]
        public void NotRightTriangleTest()
        {
            var triangle = new Triangle(2d, 2d, 2d);

            Assert.AreEqual(false, triangle.IsRightTriangle);
        }
    }
}
