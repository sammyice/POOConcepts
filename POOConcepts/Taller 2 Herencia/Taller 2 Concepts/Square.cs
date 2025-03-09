using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_2_Concepts
{
    public class Square : GeometricFigure
    {

        private double _a;

        public Square(string name, double a) : base(name)
        {
            _a = a;
        }

        public double A { get => _a; set => _a = ValidateA(value); }

        public override double GetArea()
        {
            return A * A; // Fórmula del área de un cuadrado: lado^2
        }

        public override double GetPerimeter()
        {
            return 4 * A; // Fórmula del perímetro de un cuadrado: 4 * lado
        }

        private double ValidateA(double a)

        {
            if (a <= 0)
            {
                throw new Exception($"The side length {a}, must be a positive value.");
            }
            return a;
        }
    }
}
