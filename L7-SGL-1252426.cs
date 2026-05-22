using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
            static void Main()
            {
            // Entrada de usuario
            Console.Write("¿Cómo te llamas? ");
            string name = Console.ReadLine();
            // Salida de datos
            Console.WriteLine("Hola, " + name + " ¡Bienvenido a C#!");


            // EJERCICIO 1 - WHILE
            

            string nombre = "Sebastián González"; 
                int carnet = 1252426;                 
                int indice = 1;

                Console.WriteLine("Nombre: " + nombre + " Carnet: " + carnet.ToString());
                Console.WriteLine("----------------------------------");

                while (indice <= 20)
                {
                    if (indice % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine(indice);
                    indice = indice + 1;
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();

                // EJERCICIO 2 - DO-WHILE

                Console.Write("Ingresa un número entero positivo: ");
                int numero = int.Parse(Console.ReadLine());
                int divisor = 1;

                Console.WriteLine("\nLos divisores positivos de " + numero + " son:");

                do
                {
                    if (numero % divisor == 0)
                    {
                        Console.WriteLine(divisor);
                    }
                    divisor = divisor + 1;
                } while (divisor <= numero);

                Console.ReadLine();

                // EJERCICIO 3 - FOR


                Console.Write("¿Cuántos elementos de la serie Fibonacci deseas ver? ");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine("\nLos primeros " + n + " elementos de la serie Fibonacci son:");

                int a = 0;
                int b = 1;

                for (int i = 0; i < n; i++)
                {
                    Console.Write(a);
                    if (i < n - 1)
                    {
                        Console.Write(", ");
                    }
                    int siguiente = a + b;
                    a = b;
                    b = siguiente;
                }

                Console.WriteLine();
                Console.ReadLine();

                // EJERCICIO 4 - CICLOS ANIDADOS

                for (int tabla = 1; tabla <= 12; tabla++)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Tabla del " + tabla);
                    Console.ForegroundColor = ConsoleColor.White;

                    for (int mult = 1; mult <= 10; mult++)
                    {
                        int resultado = tabla * mult;
                        Console.WriteLine(tabla + " x " + mult + " = " + resultado);
                    }

                    Console.WriteLine();
                }

                Console.ReadLine();
            }
        }
    }
