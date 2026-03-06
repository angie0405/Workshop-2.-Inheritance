using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Models
{
    internal class Parallelogram : Rectangle
    {
        // Fields
        private double _h;
        // Properties
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
            return B * H;
        }
        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
        // Constructor
        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            ValidateH(h);
            H = h;
            Name = "Parallelogram";
        }
        // Validation helper
        private static void ValidateH(double h)
        {
            if (double.IsNaN(h) || double.IsInfinity(h))
                throw new ArgumentException("H must be a finite number.", nameof(h));
            if (h <= 0)
                throw new ArgumentOutOfRangeException(nameof(h), "H must be greater than 0.");
        }
    }
}
