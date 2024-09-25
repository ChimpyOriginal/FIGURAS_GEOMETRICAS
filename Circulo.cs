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
        }


        // Método para el del cálculo de área
        public override double CalcularArea()
        {
            return (Math.PI * (radio * radio));
        }

        // Método para el cálculo de perímetro
        public override double CalcularPerimetro()
        {
            return (Math.PI * (radio * 2));
        }
        ~Circulo()
        {
            Console.WriteLine("Destructor");
        }
    }
}
