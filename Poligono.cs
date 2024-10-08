using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HERENCIA
{
    public abstract class Poligono : FiguraGeometrica
    {
        protected double lado;
        protected double apotema;

        public double Lado { get { return lado; } }
        public double Apotema { get { return apotema; } }

        public Poligono(string nombre, double lado, double apotema) : base(nombre)
        {
            this.lado = lado;
            this.apotema = apotema;
            Console.WriteLine($"El constructor de Polígono ({nombre}) ha sido invocadooo.");
        }
        public override double CalcularArea()
        {
            double perimetro = CalcularPerimetro();
            return (perimetro * apotema) / 2;  
        }

        public abstract override double CalcularPerimetro();

        ~Poligono()
        {
            Console.WriteLine($"El destructor de Polígono ({Nombre}) ha sido invocadoo.");
        }
    }
}
