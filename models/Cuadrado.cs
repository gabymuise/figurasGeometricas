
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using figurasGeometrica.interfaces;

namespace figurasGeometrica.models
{
    internal class Cuadrado : IFigura
    {
        private decimal Lado;

        public Cuadrado(decimal Lado)
        {
            this.Lado = Lado;
        }
        public  decimal CalcularArea()
        {
            decimal a = Lado * Lado;

            return a;
        }

        public decimal CalcularPerimetro()
        {
            decimal p = Lado * 4;

            return p;
        }
    }
}
