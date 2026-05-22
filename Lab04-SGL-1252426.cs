using System;

class Program {
    static void Main() {

        // ─── Ejercicio 1: Perfil de un Personaje ───────────────────────────
        string nombre       = "Arthas";
        int    nivel        = 35;
        float  puntosDeVida = 280.5F;
        bool   esUnJefe     = true;

        Console.WriteLine("=== Ejercicio 1: Perfil del Personaje ===");
        Console.WriteLine("Nombre: "        + nombre);
        Console.WriteLine("Nivel: "         + nivel);
        Console.WriteLine("Puntos de vida: "+ puntosDeVida);
        Console.WriteLine("¿Es un jefe?: "  + esUnJefe);

        // ─── Ejercicio 2: Conversión Implícita ────────────────────────────
        Console.WriteLine("\n=== Ejercicio 2: Conversión Implícita ===");
        int    numeroEntero  = 1500;
        long   numeroLargo;
        numeroLargo = numeroEntero;          // implícita: int -> long
        Console.WriteLine("numeroLargo: " + numeroLargo);

        double numeroDecimal;
        numeroDecimal = numeroLargo;         // implícita: long -> double
        Console.WriteLine("numeroDecimal: " + numeroDecimal);

        // ─── Ejercicio 3: Casting Explícito ───────────────────────────────
        Console.WriteLine("\n=== Ejercicio 3: Casting Explícito ===");
        double precioExacto    = 45.89;
        int    precioRedondeado;
        precioRedondeado = (int)precioExacto;   // los decimales se truncan
        Console.WriteLine("precioExacto: "     + precioExacto);
        Console.WriteLine("precioRedondeado: " + precioRedondeado);
        // Respuesta: los decimales (.89) se pierden; el resultado es 45.

        // ─── Ejercicio 4: De Texto a Número (Parse) ───────────────────────
        Console.WriteLine("\n=== Ejercicio 4: Parse ===");
        // Console.ReadLine() devuelve string; asignarlo directo a int
        // causa error CS0029 (cannot implicitly convert type 'string' to 'int').
        Console.Write("Ingresar un número: ");
        string entradaUsuario = Console.ReadLine();
        int    numero         = int.Parse(entradaUsuario);
        Console.WriteLine("Número + 5 = " + (numero + 5));

        // ─── Ejercicio 5: Clase Convert ───────────────────────────────────
        Console.WriteLine("\n=== Ejercicio 5: Clase Convert ===");
        string valorTexto    = "true";
        bool   valorBooleano = Convert.ToBoolean(valorTexto);

        string valorDecimalStr = "25.5";
        double valorDouble     = Convert.ToDouble(valorDecimalStr);

        Console.WriteLine("valorBooleano: " + valorBooleano);
        Console.WriteLine("valorDouble: "   + valorDouble);

        // ─── Ejercicio 6: Número a Texto (.ToString) ──────────────────────
        Console.WriteLine("\n=== Ejercicio 6: ToString ===");
        double pi     = 3.14159265;
        string cadena = pi.ToString();
        Console.WriteLine("pi como string: " + cadena);
        Console.WriteLine("pi con 2 decimales: " + pi.ToString("F2"));

        // ─── Ejercicio 7: Calculadora de IVA ──────────────────────────────
        Console.WriteLine("\n=== Ejercicio 7: Calculadora de IVA ===");
        Console.Write("Ingrese el precio del producto: ");
        string precioTexto = Console.ReadLine();
        double precio      = Convert.ToDouble(precioTexto);
        double iva         = precio * 0.21;
        double total       = precio + iva;
        int    totalEntero = (int)total;
        Console.WriteLine("El total a pagar es: " + totalEntero);

        Console.ReadLine();
    }
}
