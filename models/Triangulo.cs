using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using figurasGeometrica.interfaces;

namespace figurasGeometrica.models
{
    internal class Triangulo : IFigura
    {
        private decimal Lado1;
        private decimal Lado2;
        private decimal Lado3;
        public Triangulo(decimal Lado, decimal lado2, decimal lado3)
        {
            this.Lado1 = Lado;
            this.Lado2 = lado2;
            this.Lado3 = lado3;
        }


        public decimal CalcularAltura()
        {
            if (Lado1 == Lado2 && Lado3 == Lado1)
            {
                decimal h = (decimal)(Math.Sqrt(3) / 2) * Lado3;
                return h;
            }
            else
            {
                Console.WriteLine("Solo calcula triangulos equilatero");
            }
            return 0;
        }

        public decimal CalcularPerimetro()
        {
            if (Lado1 == Lado2 && Lado3 == Lado1)
            {
                return Lado1 * 3;
            }
            else
            {
                Console.WriteLine("Solo calcula triangulos equilatero");
            }
            return 0;

        }

        public decimal CalcularArea()
        {
            
            decimal s = (Lado1 + Lado2 + Lado3) / 2;

            
            decimal area = (decimal)Math.Sqrt((double)(s * (s - Lado1) * (s - Lado2) * (s - Lado3)));

            return area;
        }

    }

}
