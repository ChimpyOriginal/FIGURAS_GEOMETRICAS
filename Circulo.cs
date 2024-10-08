using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HERENCIA
{
    public class Circulo : FiguraGeometrica
    {
        private double radio;
        public double Radio { get { return radio; } }

        public Circulo(double radio) : base("Círculo")
        {
            this.radio = radio;
            Console.WriteLine("El constructor de Círculo ha sido invocadoo.");
        }

        ~Circulo()
        {
            Console.WriteLine("El destructor del Círculo ha sido invocadoo.");
        }

        public override double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }
}
