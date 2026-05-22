using System;

class Program
{
    static void Main()
    {
        // EJERCICIO 1 - Traduccion
        string[] espanol = { "rojo", "azul", "amarillo", "blanco", "verde" };
        string[] ingles = { "red", "blue", "yellow", "white", "green" };
        string[] italiano = { "rosso", "blu", "giallo", "bianco", "verde" };

        bool leccionActiva = true;
        while (leccionActiva)
        {
            Console.WriteLine("\n--- Traductor de Colores ---");
            Console.WriteLine("1. Practicar leccion");
            Console.WriteLine("2. Terminar leccion");
            Console.Write("Opcion: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("Ingresa una palabra en espanol: ");
                string entrada = Console.ReadLine().ToLower();
                int indice = -1;
                for (int i = 0; i < espanol.Length; i++)
                {
                    if (espanol[i] == entrada) indice = i;
                }
                if (indice != -1)
                {
                    string esp = char.ToUpper(espanol[indice][0]) + espanol[indice].Substring(1);
                    string ing = char.ToUpper(ingles[indice][0]) + ingles[indice].Substring(1);
                    string ita = char.ToUpper(italiano[indice][0]) + italiano[indice].Substring(1);
                    Console.WriteLine(esp + ", " + ing + ", " + ita);
                }
                else
                {
                    Console.WriteLine("La palabra no corresponde a la leccion actual.");
                }
            }
            else if (opcion == "2")
            {
                leccionActiva = false;
            }
        }

        // EJERCICIO 2 - Calificaciones
        Random rnd = new Random();
        int[] calificaciones = new int[10];
        for (int i = 0; i < 10; i++) calificaciones[i] = rnd.Next(50, 101);

        bool menuActivo = true;
        while (menuActivo)
        {
            Console.WriteLine("\n--- Calificaciones del Curso ---");
            Console.WriteLine("1. Reporte de rendimiento");
            Console.WriteLine("2. Estadisticas");
            Console.WriteLine("3. Salir");
            Console.Write("Opcion: ");
            string op = Console.ReadLine();

            if (op == "1")
            {
                Console.Write("Calificaciones: ");
                for (int i = 0; i < calificaciones.Length; i++)
                {
                    if (calificaciones[i] <= 64)
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    else if (calificaciones[i] <= 79)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.Write(calificaciones[i] + " ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            else if (op == "2")
            {
                int suma = 0;
                int mayor = calificaciones[0];
                int menor = calificaciones[0];
                for (int i = 0; i < calificaciones.Length; i++)
                {
                    suma += calificaciones[i];
                    if (calificaciones[i] > mayor) mayor = calificaciones[i];
                    if (calificaciones[i] < menor) menor = calificaciones[i];
                }
                Console.WriteLine("Promedio: " + ((double)suma / calificaciones.Length).ToString("F2"));
                Console.WriteLine("Calificacion mas alta: " + mayor);
                Console.WriteLine("Calificacion mas baja: " + menor);
            }
            else if (op == "3")
            {
                menuActivo = false;
            }
        }

        // EJERCICIO 3 - Palindromos
        Console.Write("\n--- Detector de Palindromos ---\nIngresa una palabra: ");
        string palabra = Console.ReadLine().ToLower();
        bool esPalindromo = true;
        int largo = palabra.Length;
        for (int i = 0; i < largo / 2; i++)
        {
            if (palabra[i] != palabra[largo - 1 - i]) esPalindromo = false;
        }
        Console.WriteLine(esPalindromo ? "True" : "False");

        // EJERCICIO 4 - Simetria Eje Y 3x3
        int[,] mat3 = new int[3, 3];
        llenar3(mat3);
        Console.WriteLine("\n--- Simetria respecto al Eje Y ---");
        Console.WriteLine(SimetriaEjeY(mat3) ? "La matriz ES simetrica." : "La matriz NO es simetrica.");

        // EJERCICIO 5 - Diagonales 5x5
        int[,] mat5 = new int[5, 5];
        llenar5(mat5);
        Console.WriteLine("\n--- Suma de Diagonales (5x5) ---");
        Console.WriteLine("Suma diagonal principal: " + sumaDiagonalPrincipal(mat5));
        Console.WriteLine("Suma diagonal secundaria: " + sumaDiagonalSecundaria(mat5));

        Console.Write("\nPresione enter para salir...");
        Console.ReadLine();
    }

    static void llenar3(int[,] m)
    {
        Console.WriteLine("\n--- Llenar matriz 3x3 ---");
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
            {
                Console.Write("m[" + i + "][" + j + "]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
    }

    static bool SimetriaEjeY(int[,] m)
    {
        for (int i = 0; i < 3; i++)
            if (m[i, 0] != m[i, 2]) return false;
        return true;
    }

    static void llenar5(int[,] m)
    {
        Console.WriteLine("\n--- Llenar matriz 5x5 ---");
        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
            {
                Console.Write("m[" + i + "][" + j + "]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
    }

    static int sumaDiagonalPrincipal(int[,] m)
    {
        int suma = 0;
        for (int i = 0; i < 5; i++) suma += m[i, i];
        return suma;
    }

    static int sumaDiagonalSecundaria(int[,] m)
    {
        int suma = 0;
        for (int i = 0; i < 5; i++) suma += m[i, 4 - i];
        return suma;
    }
}