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
        }
        public override string ToString()
        {
            return $"Figura: {Nombre} - Área: {CalcularArea():F1} u^2 - Perímetro: {CalcularPerimetro():F1} u\n";
        }
        
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }
}
