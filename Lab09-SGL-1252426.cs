using System;

class Program {

    // ─── Ejercicio 1: Longitud de cadena (por valor) ──────────────────────
    static void MostrarLongitud(string cadena) {
        Console.WriteLine("Longitud de \"" + cadena + "\": " + cadena.Length);
    }

    // ─── Ejercicio 2: Intercambiar dos enteros (por referencia) ───────────
    static void Intercambiar(ref int a, ref int b) {
        int temp = a;
        a = b;
        b = temp;
    }

    // ─── Ejercicio 3: Descuento en boleto de cine ─────────────────────────
    // porcentaje por VALOR, precio por REFERENCIA
    static void AplicarDescuento(double porcentaje, ref double precio) {
        precio = precio - (precio * porcentaje);
    }

    // ─── Ejercicio 4a: Recibir daño (por referencia) ─────────────────────
    static void RecibirDanio(ref int puntosSalud) {
        puntosSalud -= 5;
        if (puntosSalud < 0) puntosSalud = 0;
    }

    // ─── Ejercicio 4b: Curar (por referencia) ────────────────────────────
    static void Curar(ref int puntosSalud) {
        puntosSalud += 3;
        if (puntosSalud > 15) puntosSalud = 15;
    }

    // ─── Ejercicio 4c: Mostrar salud con color ───────────────────────────
    static void MostrarSalud(int puntosSalud) {
        if (puntosSalud >= 11)
            Console.ForegroundColor = ConsoleColor.Green;
        else if (puntosSalud >= 6)
            Console.ForegroundColor = ConsoleColor.Yellow;
        else
            Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("Puntos de salud: " + puntosSalud);
        Console.ResetColor();
    }

    // ─── Ejercicio 4d: Calificar desempeño (por valor) ───────────────────
    static void CalificarDesempeno(int puntosSalud) {
        string calificacion;
        if (puntosSalud == 15)
            calificacion = "S";
        else if (puntosSalud >= 11)
            calificacion = "A";
        else if (puntosSalud >= 6)
            calificacion = "B";
        else
            calificacion = "C";

        Console.WriteLine("Calificación: " + calificacion);
    }

    // ─── Main ─────────────────────────────────────────────────────────────
    static void Main() {

        // Ejercicio 1
        Console.WriteLine("=== Ejercicio 1: Longitud de cadena ===");
        MostrarLongitud("Ratón");
        MostrarLongitud("Insomnio");

        // Ejercicio 2
        Console.WriteLine("\n=== Ejercicio 2: Intercambio de variables ===");
        int a = 4, b = 13;
        Console.WriteLine("Antes  -> A = " + a + ", B = " + b);
        Intercambiar(ref a, ref b);
        Console.WriteLine("Después-> A = " + a + ", B = " + b);

        // Ejercicio 3
        Console.WriteLine("\n=== Ejercicio 3: Descuento en boleto ===");
        double precio       = 48.50;
        double porcentaje   = 0.15;
        Console.WriteLine("Precio antes del descuento:  " + precio);
        AplicarDescuento(porcentaje, ref precio);
        Console.WriteLine("Precio después del descuento: " + precio.ToString("F2"));

        // Ejercicio 4
        Console.WriteLine("\n=== Ejercicio 4: Sistema de salud del jugador ===");
        int salud = 15;

        MostrarSalud(salud);
        RecibirDanio(ref salud);
        RecibirDanio(ref salud);
        MostrarSalud(salud);
        Curar(ref salud);
        MostrarSalud(salud);
        RecibirDanio(ref salud);
        RecibirDanio(ref salud);
        RecibirDanio(ref salud);
        MostrarSalud(salud);
        CalificarDesempeno(salud);

        Console.ReadLine();
    }
}
