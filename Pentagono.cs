using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HERENCIA
{
    public class Pentagono : Poligono
    {
        public Pentagono(double lado, double apotema) : base("Pentágono", lado, apotema)
        {
            Console.WriteLine("El constructor de Pentágono ha sido invocadoo.");
        }

        ~Pentagono()
        {
            Console.WriteLine("El destructor de Pentágono ha sido invocadoo.");
        }

        public override double CalcularPerimetro()
        {
            return lado * 5;
        }
    }
}
