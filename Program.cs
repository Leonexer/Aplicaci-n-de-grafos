using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicación_de_grafos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grafo grafo = new Grafo();
            int opcion;

            do
            {
                Console.WriteLine("\n--- Menú ---");
                Console.WriteLine("1. Insertar vértice");
                Console.WriteLine("2. Insertar arista");
                Console.WriteLine("3. Mostrar lista de adyacencia");
                Console.WriteLine("4. Recorrido en DFS");
                Console.WriteLine("5. Recorrido en BFS");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el vértice a agregar: ");
                        if (int.TryParse(Console.ReadLine(), out int vertice))
                        {
                            grafo.InsertVertix(vertice);
                            Console.WriteLine("Vértice agregado.");
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida.");
                        }
                        break;

                    case 2:
                        Console.Write("Ingrese el vértice origen: ");
                        if (!int.TryParse(Console.ReadLine(), out int vertA)) break;
                        Console.Write("Ingrese el vértice destino: ");
                        if (!int.TryParse(Console.ReadLine(), out int vertB)) break;
                        Console.Write("Es dirigido? (1: Sí, 0: No): ");
                        bool isDirected = Console.ReadLine() == "1";
                        grafo.InsertEdge(vertA, vertB, isDirected);
                        Console.WriteLine("Arista agregada.");
                        break;

                    case 3:
                        grafo.MostrarListaAdy();
                        break;

                    case 4:
                        Console.Write("Ingrese el vértice de inicio para DFS: ");
                        if (int.TryParse(Console.ReadLine(), out int startDFS))
                        {
                            grafo.DFS(startDFS);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida.");
                        }
                        break;

                    case 5:
                        Console.Write("Ingrese el vértice de inicio para BFS: ");
                        if (int.TryParse(Console.ReadLine(), out int startBFS))
                        {
                            grafo.BFS(startBFS);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida.");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 6);
        }
    }
}
