using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_2_Concepts
{
    public class Trapeze : Triangle
    {
        private int _d;

        public Trapeze(string name, int a, int b, int c, int h, int d) : base(name, a, b, c, h)
        {
            _d = d;
        }

        public int D { get => _d; set => _d = ValidateD(value); }

        public override double GetArea()
        {
            return (B + D) * H / 2; // Fórmula del área del trapecio: ((Base mayor + Base menor) * Altura) / 2
        }

        public override double GetPerimeter()
        {
            return A + B + C + D; // Fórmula del perímetro
        }

        private int ValidateD(int d)
        {
            if (d <= 0)
            {
                throw new Exception($"The smaller base {d}, must be a positive value.");
            }
            return d;
        }
    }
}
