using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HERENCIA
{
    public class Rectangulo : FiguraGeometrica
    {
        private double ancho;
        private double altura;

        public Rectangulo(double ancho, double altura) : base("Rectángulo")
        {
            this.ancho = ancho;
            this.altura = altura;
            Console.WriteLine("El constructor de Rectángulo ha sido invocadoo.");
        }

        ~Rectangulo()
        {
            Console.WriteLine("El destructor de Rectángulo ha sido invocadoo.");
        }

        public override double CalcularArea()
        {
            return ancho * altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (ancho + altura);
        }
    }
}
