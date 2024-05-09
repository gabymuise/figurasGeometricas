using figurasGeometrica.interfaces;
using System;

namespace figurasGeometrica.models
{
    internal class Poligono : IFigura
    {
        private int lados;
        private decimal longitudLado;

        public Poligono(int lados, decimal longitudLado)
        {
            this.lados = lados;
            this.longitudLado = longitudLado;
        }

        public decimal CalcularPerimetro()
        {
            return lados * longitudLado;
        }

        public decimal CalcularArea()
        {
            double s = Convert.ToDouble(longitudLado); // Longitud de un lado
            double n = Convert.ToDouble(lados); // Número de lados
            double area = (n * Math.Pow(s, 2)) / (4 * Math.Tan(Math.PI / n));
            return Convert.ToDecimal(area);
        }
    }
}
