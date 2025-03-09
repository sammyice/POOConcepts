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
        return $"{Name, -15}=>  Area.....:   {GetArea(),10:F5}   Perimeter:   {GetPerimeter(),10:F5}";
    }

    }