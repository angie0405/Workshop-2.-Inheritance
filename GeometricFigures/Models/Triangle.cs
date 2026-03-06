using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Models
{
    internal class Triangle : Rectangle
    {
        // Fields
        private double _c;

        private double _h;

        // Properties
        public double C
        {
            get => _c;
            set
            {
                ValidateC(value);
                _c = value;
            }
        }

        public double H
        {
            get => _h;
            set
            {
                ValidateH(value);
                _h = value;
            }
        }

        // Methods
        public override double GetArea()
        {
            return (B * H) / 2;
        }

        public override double GetPerimeter()
        {
            return A + B + C;
        }

        // Constructor
        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            ValidateC(c);
            ValidateH(h);
            C = c;
            H = h;
            Name = "Triangle";
        }

        // Validation helper
        private static void ValidateC(double c)
        {
            if (double.IsNaN(c) || double.IsInfinity(c))
                throw new ArgumentException("C must be a finite number.", nameof(c));
            if (c <= 0)
                throw new ArgumentOutOfRangeException(nameof(c), "C must be greater than 0.");
        }

        private static void ValidateH(double h)
        {
            if (double.IsNaN(h) || double.IsInfinity(h))
                throw new ArgumentException("H must be a finite number.", nameof(h));
            if (h <= 0)
                throw new ArgumentOutOfRangeException(nameof(h), "H must be greater than 0.");
        }
    }
}