using System;
using System.Collections.Generic;
using System.Text;

namespace MiAppCuadrado.Models
{
    public class Cuadrado
    {
        public double Area { get; set; }
        public double Perimetro { get; set; }
        private double Lado;

        public Cuadrado( double l) 
        {
            Lado = l;
       
            CalcularArea();
            CalcularPerimetro();
        
        }


        public void CalcularArea ()
        {
            Area = Lado * Lado;
        }
        public void CalcularPerimetro ()
        {
            Perimetro = 4 * Lado;
        }
        public override string ToString()
        {
            return $" Area: {Area} -  Perimetro: {Perimetro} ";
        }
    }
}
