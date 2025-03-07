using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Taller_2_Concepts
{
    public class Circle : GeometricFigure
    {

        private int _r;

        public Circle(string name, int r) : base(name)
        {
            _r = r;
        }

        public int R { get => _r; set => _r = ValidateR(value); }

        public override double GetArea()
        {
            return Math.PI * R * R;// Fórmula del área: π * r^2
        }

        public override double GetPerimeter()   
        {
            return 2 * Math.PI * R;// Fórmula del perímetro: 2 * π * r
        }


        private int ValidateR(int r)

        {
            if (r <= 0)
            {
                throw new Exception($"The radius: {r}, must be a positive value.");
            }
            return r;
        }

    }
}
