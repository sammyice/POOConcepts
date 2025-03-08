using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_2_Concepts
{
    public class Triangle : Rectangle
    {
        private int _c;
        private int _h;

        public Triangle(string name, int a, int b, int c, int h) : base(name, a, b)
        {
            _c = c;
            _h = h;
        }

        public int C { get => _c; set => _c = ValidateC(value); }
        public int H { get => _h; set => _h = ValidateH(value); }

        public override double GetArea()
        {
            return (B * H) / 2; // Fórmula del área de un triángulo: (base * altura) / 2
        }

        public override double GetPerimeter()
        {
            return A + B + C;  // El perímetro del triángulo es la suma de sus lados
        }

        private int ValidateC(int c)
        {
            if (c <= 0)
            {
                throw new Exception($"The third side {c}, must be a positive value.");
            }
            return c;
        }

        private int ValidateH(int h)
        {
            if (h <= 0)
            {
                throw new Exception($"The height {h}, must be a positive value.");
            }
            return h;
        }
    }
}
