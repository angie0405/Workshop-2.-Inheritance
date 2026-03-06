using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Models
{
    internal class Circle : GeometricFigure
    {
        // Fields
        private double _r;

        // Properties
        public double R
        {
            get => _r;
            set
            {
                ValidateR(value);
                _r = value;
            }
        }

        // Constructor
        public Circle(double r) : base("Circle")
        {
            ValidateR(r);
            _r = r;
        }

        // Methods
        public override double GetArea()
        {
            return Math.PI * _r * _r;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * _r;
        }

        // Validation helper
        private static void ValidateR(double r)
        {
            if (double.IsNaN(r) || double.IsInfinity(r))
                throw new ArgumentException("R must be a finite number.", nameof(r));

            if (r <= 0)
                throw new ArgumentOutOfRangeException(nameof(r), "R must be greater than 0.");
        }
    }
}
