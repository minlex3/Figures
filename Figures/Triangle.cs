using System;

namespace Figures
{
    public class Triangle : IFigure
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public bool IsRightTriangle { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA < Utils.Constants.CalculationAccuracy)
                throw new ArgumentException("Wrong side A");
            if (sideB < Utils.Constants.CalculationAccuracy)
                throw new ArgumentException("Wrong side B");
            if (sideC < Utils.Constants.CalculationAccuracy)
                throw new ArgumentException("Wrong side C");

            double[] sides = { sideA, sideB, sideC };
            Utils.SortingArray(sides);
            if (sides[2] - sides[1] - sides[0] > Utils.Constants.CalculationAccuracy)
                throw new ArgumentException("Each side of the triangle must be greater than the sum of the other two!");
            
            SideA = sides[0];
            SideB = sides[1];
            SideC = sides[2];

            IsRightTriangle = Math.Abs(Math.Pow(sides[2], 2) - Math.Pow(sides[1], 2) - Math.Pow(sides[0], 2)) < Utils.Constants.CalculationAccuracy;
        }

        public double GetFigureArea()
        {
            double halfP = (SideA + SideB + SideC) / 2d;
            return Math.Sqrt(halfP * (halfP - SideA) * (halfP - SideB) * (halfP - SideC));
        }
    }
}
