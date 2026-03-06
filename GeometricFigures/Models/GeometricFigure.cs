using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Models
{
    public abstract class GeometricFigure
    {
        public string Name { get; protected set; }

        protected GeometricFigure(string name)
        {
            Name = name;
        }

        public abstract double GetArea();

        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"¨{Name,-15} => Area.....:{GetArea(),15:N5}     Perimeter:{GetPerimeter(),15:N5}";
        }
    }
}