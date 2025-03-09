using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_2_Concepts
{
    public class Kite : Rhombus
    {
        private double _b;

        public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
        {
            _b = b;
        }


        public double B { get => _b; set => _b = ValidateB(value); }

        public override double GetArea()
        {
            return (D1 * D2) / 2; // Utiliza las diagonales para calcular el área (heredadas de Rhombus)
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B);  // Perímetro basado en lados y valores adicionale
        }

        private double ValidateB(double b)

        {
            if (b <= 0)
            {
                throw new Exception($"The value for {b}, must be a positive value.");
            }
            return b;
        }
    }
}
