using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Models
{
    internal class Rectangle : Square
    {
        // Fields
        private double _b;
        // Properties
        public double B
        {
            get => _b;
            set
            {
                ValidateB(value);
                _b = value;
            }
        }
        // Methods
        public override double GetArea()
        {
            return A * B;
        }
        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
        // Constructor
        public Rectangle(string name, double a, double b) : base(name, a)
        {
            ValidateB(b);
            B = b;
            Name = "Rectangle";
        }
        // Validation helper
        private static void ValidateB(double b)
        {
            if (double.IsNaN(b) || double.IsInfinity(b))
                throw new ArgumentException("B must be a finite number.", nameof(b));
            if (b <= 0)
                throw new ArgumentOutOfRangeException(nameof(b), "B must be greater than 0.");
        }
    }
}
