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

        public double Ancho { get { return ancho; } }
        public double Altura { get { return altura; } } 
        public Rectangulo(double ancho, double altura) : base("Rectángulo")
        {
            this.ancho = ancho;
            this.altura = altura;
        }

        // Método para el del cálculo de área
        public override double CalcularArea()
        {
            return ancho * altura;
        }

        // Método para el cálculo de perímetro
        public override double CalcularPerimetro()
        {
            return (ancho*2) + (altura*2);
        }
        ~Rectangulo()
        {
            Console.WriteLine("Destructor");
        }
    }
}
