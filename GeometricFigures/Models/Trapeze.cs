namespace GeometricFigures.Models
{
    internal class Trapeze : Triangle
    {
        // Fields
        private double _d;

        // Properties
        public double D
        {
            get => _d;
            set
            {
                ValidateD(value);
                _d = value;
            }
        }

        // Methods
        public override double GetArea()
        {
            return ((B + D) * H) / 2;
        }

        public override double GetPerimeter()
        {
            return A + B + C + D;
        }

        // Constructor
        public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
        {
            ValidateD(d);

            D = d;

            Name = "Trapeze";
        }

        // Validation helper
        private static void ValidateD(double d)
        {
            if (double.IsNaN(d) || double.IsInfinity(d))
                throw new ArgumentException("D must be a finite number.", nameof(d));
            if (d <= 0)
                throw new ArgumentOutOfRangeException(nameof(d), "D must be greater than 0.");
        }
    }
}