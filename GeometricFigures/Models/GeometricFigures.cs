using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Models
{
    public abstract class GeometricFigures
    {
        public string Name { get; protected set; }

        protected GeometricFigures(string name)
        {
            Name = name;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"¨{Name} => Area.....:{GetArea():F5}     Perimeter:{GetPerimeter():F5}";
        }

    }
}
























