using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Taller_2_Concepts
{
    public class Rhombus : Square
    {

        private double _d1;
        private double _d2;

        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            _d1 = d1;
            _d2 = d2;
        }

        public double D1 { get => _d1; set => _d1 = ValidateD1(value); }
        public double D2 { get => _d2; set => _d2 = ValidateD2(value); }

        public override double GetArea()
        {
            return (D1 * D2) / 2.0; // Fórmula del área de un rombo: (diagonal1 * diagonal2) / 2
        }

        public override double GetPerimeter()
        {
            return 4 * A; // El perímetro de un rombo es igual al lado * 4
        }
      
        private double ValidateD1(double d1)
        {
            if (d1 <= 0)
            {
                throw new Exception($"Diagonal 1: {d1}, must be a positive value.");
            }
            return d1;
        }

        private double ValidateD2(double d2)
        {
            if (d2 <= 0)
            {
                throw new ArgumentException($"Diagonal 2: {d2}, must be a positive value.");
            }
            return d2;
        }
    }
}