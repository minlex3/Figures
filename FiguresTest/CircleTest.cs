using NUnit.Framework;
using Figures;
using System;

namespace FiguresTest
{
    public class CircleTest
    {
        [Test]
        public void NegativeRadiusTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(-1d));
        }

        [Test]
        public void LessMinimalRadiusTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(Utils.Constants.MinimalRadius - Utils.Constants.CalculationAccuracy));
        }

        [Test]
        public void GetAreaTest()
        {
            var radius = 5;
            double expectedValue = Math.PI * Math.Pow(radius, 2d);
            double actualValue = new Circle(radius).GetFigureArea();
            double actualDifference = Math.Abs(expectedValue - actualValue);

            Assert.AreEqual(expectedValue, actualValue);
            Assert.Less(actualDifference, Utils.Constants.CalculationAccuracy);
        }
    }
}
