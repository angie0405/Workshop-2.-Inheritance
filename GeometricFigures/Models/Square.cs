using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Models
{
    internal class Square : GeometricFigure
    {
        // Fields
        private double _a;

        // Properties
        public double A
        {
            get => _a;
            set
            {
                ValidateA(value);
                _a = value;
            }
        }

        // Methods
        public override double GetArea()
        {
            return _a * _a;
        }

        public override double GetPerimeter()
        {
            return 4 * _a;
        }

        // Constructor
        public Square(double a) : base("Square")
        {
            ValidateA(a);
            _a = a;
        }

        // Validation helper
        private static void ValidateA(double a)
        {
            if (double.IsNaN(a) || double.IsInfinity(a))
                throw new ArgumentException("A must be a finite number.", nameof(a));

            if (a <= 0)
                throw new ArgumentOutOfRangeException(nameof(a), "A must be greater than 0.");
        }
    }
}
