using System;

class Program {
    static void Main() {

        // ─── Ejercicio 1: 20 números – mayor, menor, promedio ─────────────
        Console.WriteLine("=== Ejercicio 1: Mayor, Menor y Promedio ===");
        int    mayor  = int.MinValue;
        int    menor  = int.MaxValue;
        double suma   = 0;

        for (int i = 1; i <= 20; i++) {
            Console.Write("Ingrese el número " + i + ": ");
            int num = int.Parse(Console.ReadLine());

            if (num > mayor) mayor = num;
            if (num < menor) menor = num;
            suma += num;
        }

        Console.WriteLine("Mayor:   " + mayor);
        Console.WriteLine("Menor:   " + menor);
        Console.WriteLine("Promedio: " + (suma / 20));

        // ─── Ejercicio 2: 1 al 100 – Par / Siete / ParSiete ──────────────
        Console.WriteLine("\n=== Ejercicio 2: Par, Siete, ParSiete ===");
        for (int i = 1; i <= 100; i++) {
            bool esPar   = (i % 2 == 0);
            bool esSiete = (i % 7 == 0);

            if (esPar && esSiete)
                Console.WriteLine(i + " -> ParSiete");
            else if (esPar)
                Console.WriteLine(i + " -> Par");
            else if (esSiete)
                Console.WriteLine(i + " -> Siete");
            else
                Console.WriteLine(i);
        }

        // ─── Ejercicio 3: 10 clientes con descuentos ──────────────────────
        Console.WriteLine("\n=== Ejercicio 3: Tienda – Descuentos ===");
        int    clientesConDescuento = 0;
        double totalVentas          = 0;

        for (int c = 1; c <= 10; c++) {
            Console.Write("Monto de compra cliente " + c + ": ");
            double monto = Convert.ToDouble(Console.ReadLine());

            double descuento = 0;
            if (monto > 700)
                descuento = monto * 0.12;
            else if (monto > 300)
                descuento = monto * 0.05;

            double totalPagado = monto - descuento;
            totalVentas += totalPagado;

            if (descuento > 0)
                clientesConDescuento++;

            Console.WriteLine("  Total pagado: " + totalPagado.ToString("F2"));
        }

        Console.WriteLine("Clientes con descuento: " + clientesConDescuento);
        Console.WriteLine("Total ventas del día:    " + totalVentas.ToString("F2"));

        // ─── Ejercicio 4: Opciones con el número ingresado ────────────────
        Console.WriteLine("\n=== Ejercicio 4: Opciones ===");
        Console.Write("Ingrese un número entero: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Opciones:");
        Console.WriteLine("1. Mostrar números desde " + n + " hasta 1");
        Console.WriteLine("2. Mostrar múltiplos de 3 hasta " + n);
        Console.WriteLine("3. Mostrar múltiplos de 5 hasta " + n);
        Console.Write("Elija una opción (1/2/3): ");
        int opcion = int.Parse(Console.ReadLine());

        if (opcion == 1) {
            for (int i = n; i >= 1; i--)
                Console.Write(i + " ");
            Console.WriteLine();
        } else if (opcion == 2) {
            for (int i = 3; i <= n; i += 3)
                Console.Write(i + " ");
            Console.WriteLine();
        } else if (opcion == 3) {
            for (int i = 5; i <= n; i += 5)
                Console.Write(i + " ");
            Console.WriteLine();
        } else {
            Console.WriteLine("Opción no válida.");
        }

        // ─── Ejercicio 5: Triángulo de asteriscos ─────────────────────────
        Console.WriteLine("\n=== Ejercicio 5: Triángulo de Asteriscos ===");
        Console.Write("Número de filas: ");
        int filas = int.Parse(Console.ReadLine());

        for (int i = 1; i <= filas; i++) {
            for (int j = 1; j <= i; j++)
                Console.Write("*");
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
