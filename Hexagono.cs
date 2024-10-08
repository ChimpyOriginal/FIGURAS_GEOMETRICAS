using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HERENCIA
{
    public class Hexagono : Poligono
    {
        public Hexagono(double lado, double apotema) : base("Hexágono", lado, apotema)
        {
            Console.WriteLine("El constructor de Hexágono ha sido invocadoo.");
        }

        ~Hexagono()
        {
            Console.WriteLine("El destructor de Hexágono ha sido invocadoo.");
        }

        public override double CalcularPerimetro()
        {
            return lado * 6;
        }
    }
}
