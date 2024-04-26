using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using figurasGeometrica.interfaces;


namespace figurasGeometrica.models
{

    internal class Circulo : IFigura
    {
        private double Radio;
        public Circulo(double radio)
        {
            this.Radio = radio;
        }

        public decimal CalcularArea()
        {
            decimal a = (decimal)(Math.PI * Math.Pow(Radio, 2));
            return a;
        }

        public decimal CalcularPerimetro()
        {
            decimal p = (decimal)(2 * Math.PI * Radio);
            return p;
        }
    }


}
