using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_2_Concepts;

    public abstract class GeometricFigure
    {
        public GeometricFigure(string name) 
        {
        Name = name;   
        }

    public string Name { get; set; }


   
    public abstract double GetArea();

    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"Figure: {Name}, Area: {GetArea():F2}, Perimeter: {GetPerimeter():F2}";
    }

    }