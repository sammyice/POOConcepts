using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_2_Concepts
{
    public class Parallelogram : Rectangle
    {
        private double _h;

        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            _h = h;
        }

        public double H { get => _h; set => _h = ValidateH(value); }

        public override double GetArea()
        {
            return B * H; // Fórmula del área del paralelogramo: base * altura
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B); // Fórmula del perímetro: 2 * (base + lado)
        }

        private double ValidateH(double h)
        {
            if (h <= 0)
            {
                throw new Exception($"The height {h}, must be a positive value.");
            }
            return h;

        }

    }
}