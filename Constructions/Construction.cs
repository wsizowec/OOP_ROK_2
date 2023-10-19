using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Constructions
{
    class Construction
    {
        public Construction(double height, double width, int entrances,
            int humanCapacity, string buildMaterial)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humanCapacity;
            BuildMaterial = buildMaterial; 
        }
        public double Height { get; set; }
        public double Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public string BuildMaterial { get; set; }
    }       
}
