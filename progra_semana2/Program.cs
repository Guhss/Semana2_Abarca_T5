using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progra_semana2
{
   
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Elige una figura:");
                Console.WriteLine("1. Rectangulo");
                Console.WriteLine("2. Cuadrado");
                Console.WriteLine("3. Circulo");
                Console.WriteLine("4. Triangulo");
                Console.WriteLine("5. Terminar");

                // Obtener la opción del usuario
                string opcion = Console.ReadLine();

                if (opcion == "5")
                {
                    break; // Terminar el programa si el usuario elige 5
                }

                float area = 0;

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingresa la base del rectángulo: ");
                        float baseRectangulo = float.Parse(Console.ReadLine());
                        Console.Write("Ingresa la altura del rectángulo: ");
                        float alturaRectangulo = float.Parse(Console.ReadLine());
                        Rectangulo rectangulo = new Rectangulo(baseRectangulo, alturaRectangulo);
                        area = rectangulo.CalcularArea();
                        break;
                    case "2":
                        Console.Write("Ingresa el lado del cuadrado: ");
                        float ladoCuadrado = float.Parse(Console.ReadLine());
                        Cuadrado cuadrado = new Cuadrado(ladoCuadrado);
                        area = cuadrado.CalcularArea();
                        break;
                    case "3":
                        Console.Write("Ingresa el radio del círculo: ");
                        float radioCirculo = float.Parse(Console.ReadLine());
                        Circulo circulo = new Circulo(radioCirculo);
                        area = circulo.CalcularArea();
                        break;
                    case "4":
                        Console.Write("Ingresa la base del triángulo: ");
                        float baseTriangulo = float.Parse(Console.ReadLine());
                        Console.Write("Ingresa la altura del triángulo: ");
                        float alturaTriangulo = float.Parse(Console.ReadLine());
                        Triangulo triangulo = new Triangulo(baseTriangulo, alturaTriangulo);
                        area = triangulo.CalcularArea();
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("El área es: " + area);
            }
        }
    }


}
