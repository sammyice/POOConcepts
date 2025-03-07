using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_2_Concepts
{
    public class Rectangle : Square
    {
        private int _b;

        public Rectangle(string name, int a, int b) : base(name, a)
        {
            _b = b;
        }

        public int B { get => _b; set => _b = ValidateB(value); }

        public override double GetArea()
        {
            return A * B; // Fórmula del área de rectangulo: Base * Altura
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B); // Fórmula del perímetro: 2 * (base + altura)
        }

        private int ValidateB(int b)

        {
            if (b <= 0)
            {
                throw new Exception($"The base {b}, must be a positive value.");
            }
            return b;
        }
    }
}
