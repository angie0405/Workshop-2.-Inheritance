using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Models
{
    internal class Circle : GeometricFigures
    {
        // Properties
        private double radius;

        // constructor
        public Circle(double radius) :
        base("Circle")
        {
            this.radius = radius;
        }
        //methods
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
