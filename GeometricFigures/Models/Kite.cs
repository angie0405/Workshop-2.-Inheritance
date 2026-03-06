using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Models
{
    internal class Kite : Rhombus
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
            return (D1 * D2) / 2;
        }

        public override Double GetPerimeter()
        {
            return 2 * (A + B);
        }

        // Constructor
        public Kite(string name, double a, double b, double d1, double d2) : base(name, a, d1, d2)
        {
            ValidateB(b);
            B = b;
            Name = "Kite";
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