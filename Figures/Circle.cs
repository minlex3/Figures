using System;

namespace Figures
{
    public class Circle : IFigure
    {
        public const double MinimalRadius = Utils.Constants.MinimalRadius;

        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius < MinimalRadius)
            {
                throw new ArgumentException("Wrong radius!");
            }
            Radius = radius;
        }

        public double GetFigureArea()
        {
            return Math.PI * Math.Pow(Radius, 2d);
        }
    }
}
