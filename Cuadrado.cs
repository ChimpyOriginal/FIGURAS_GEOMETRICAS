using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HERENCIA
{
    public class Cuadrado: FiguraGeometrica
    {
        private double lado;
        public double Lado { get { return lado; } }

        public Cuadrado(double lado) : base("Cuadrado")
        {
            this.lado = lado;
        }
        

        // Método para el del cálculo de área
        public override double CalcularArea()
        {
            return lado * lado;
        }

        // Método para el cálculo de perímetro
        public override double CalcularPerimetro()
        {
            return lado *  4;
        }
        ~Cuadrado()
        {
            Console.WriteLine("Destructor");
        }
    }

}
