using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HERENCIA
{
    internal class Menu
    {
        List<Opcion> opciones;

        public Menu()
        {
            opciones = new List<Opcion>()
            {
                new Opcion("Cuadrado.",CuadradoAP),
                new Opcion("Rectángulo.",RectanguloAP),
                new Opcion("Círculo.", CirculoAP),
                new Opcion("Pentágono.", PentagonoAP),
                new Opcion("Hexágono.",HexagonoAP),
                new Opcion("Salir.",()=>Environment.Exit(0))

            };
            while (true)
            {
                MostrarMenu();
                ElegirOpcion();
            }
        }

        public void MostrarMenu()
        {
            Console.WriteLine("LISTA DE FIGURAS:\n");
            for (int i = 0; i < opciones.Count; i++)
            {
                Console.WriteLine((i + 1) + "." + opciones[i].Message);
            }
        }
        public void ElegirOpcion()
        {
            Console.Write("Selecciona la figura de la que desees sacar el área y el perímetro: ");
            int numOpcion = Convert.ToInt32(Console.ReadLine());
            numOpcion--;
            Console.Clear();
            if (numOpcion < opciones.Count)
            {
                opciones[numOpcion].Action.Invoke();
            }
            else
            {
                Console.WriteLine("Opción no válida. Por favor, elige una registra en el menú.");
                Continuar();
            }
            Console.Clear();
        }
        static void Continuar()
        {
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadLine();
        }

        static void CuadradoAP()
        {
            Console.WriteLine("Ingrese la medida del lado del cuadrado:");
            double lado = double.Parse(Console.ReadLine());
            Cuadrado cuadrado = new Cuadrado(lado);
            Console.WriteLine(cuadrado);
            Continuar();
        }
        static void RectanguloAP()
        {
            Console.WriteLine("Ingrese la medida del ancho del rectángulo:");
            double ancho = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la medida del alto del rectángulo:");
            double alto = double.Parse(Console.ReadLine());
            Rectangulo rectangulo = new Rectangulo(ancho, alto);
            Console.WriteLine(rectangulo);
            Continuar();
        }
        static void CirculoAP()
        {
            Console.WriteLine("Ingrese la medida del radio del círculo:");
            double radio = double.Parse(Console.ReadLine());
            Circulo circulo = new Circulo(radio);
            Console.WriteLine(circulo);
            Continuar();
        }
        static void PentagonoAP()
        {
            Console.WriteLine("Ingrese la medida de un lado del pentágono:");
            double lado = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la medida d la apotema del pentágono:");
            double apotema = double.Parse(Console.ReadLine());
            Pentagono pentagono = new Pentagono(lado, apotema);
            Console.WriteLine(pentagono);
            Continuar();
        }
        static void HexagonoAP()
        {
            Console.WriteLine("Ingrese la medida de un lado del hexágono:");
            double lado = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la medida de la apotema del hexágono:");
            double apotema = double.Parse(Console.ReadLine());
            Hexagono hexagono = new Hexagono(lado, apotema);
            Console.WriteLine(hexagono);
            Continuar();
        }
    }
}

