using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HERENCIA
{
    public abstract class FiguraGeometrica
    {
        private string nombre;
        public string Nombre { get { return nombre; } }

        public FiguraGeometrica(string nombre)
        {
            this.nombre = nombre;
            Console.WriteLine($"\nEl constructor de FiguraGeometrica ({nombre}) ha sido invocado :).");
        }

        ~FiguraGeometrica()
        {
            Console.WriteLine($"El destructor de FiguraGeometrica ({nombre}) ha sido invocadoo :(.");
        }

        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();

        public override string ToString()
        {
            return $"\nFigura: {Nombre} - Área: {CalcularArea():F1} u^2 - Perímetro: {CalcularPerimetro():F1} u\n";
        }
    }
}
