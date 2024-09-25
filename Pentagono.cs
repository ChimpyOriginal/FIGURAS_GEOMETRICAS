﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HERENCIA
{
    public class Pentagono : FiguraGeometrica
    {
        private double lado;
        private double apotema;

        public double Lado { get { return lado; } }
        public double Apotema { get { return apotema; } }
        public Pentagono(double lado, double apotema) : base("Pentágono")
        {
            this.lado = lado;
            this.apotema = apotema;
        }

        // Método para el del cálculo de área
        public override double CalcularArea()
        {
            double perimetro = CalcularPerimetro();
            return (perimetro * apotema) / 2;
        }

        // Método para el cálculo de perímetro
        public override double CalcularPerimetro()
        {
            return lado * 5;
        }
        ~Pentagono()
        {
            Console.WriteLine("Destructor");
        }
    }
}
