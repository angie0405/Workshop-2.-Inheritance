using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Models
{
    internal class Rhombus : Square
    {
        // Fields
        private double _d1;

        private double _d2;

        // Properties
        public double D1
        {
            get => _d1;
            set
            {
                ValidateD1(value);
                _d1 = value;
            }
        }

        public double D2
        {
            get => _d2;
            set
            {
                ValidateD2(value);
                _d2 = value;
            }
        }

        // Methods
        public override double GetArea()
        {
            return (D1 * D2) / 2;
        }

        public override double GetPerimeter()
        {
            return 4 * A;
        }

        // Constructor
        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            ValidateD1(d1);
            ValidateD2(d2);
            D1 = d1;
            D2 = d2;
            Name = "Rhombus";
        }

        // Validation helpers
        private static void ValidateD1(double d1)
        {
            if (double.IsNaN(d1) || double.IsInfinity(d1))
                throw new ArgumentException("D1 must be a finite number.", nameof(d1));
            if (d1 <= 0)
                throw new ArgumentOutOfRangeException(nameof(d1), "D1 must be greater than 0.");
        }

        private static void ValidateD2(double d2)
        {
            if (double.IsNaN(d2) || double.IsInfinity(d2))
                throw new ArgumentException("D2 must be a finite number.", nameof(d2));
            if (d2 <= 0)
                throw new ArgumentOutOfRangeException(nameof(d2), "D2 must be greater than 0.");
        }
    }
}