using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HERENCIA
{
    public class Cuadrado : FiguraGeometrica
    {
        private double lado;

        public Cuadrado(double lado) : base("Cuadrado")
        {
            this.lado = lado;
            Console.WriteLine("El constructor de Cuadrado ha sido invocadoo.");
        }

        ~Cuadrado()
        {
            Console.WriteLine("El destructor del Cuadrado ha sido invocadoo.");
        }

        public override double CalcularArea()
        {
            return lado * lado;
        }

        public override double CalcularPerimetro()
        {
            return lado * 4;
        }
    }

}
