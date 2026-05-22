using System;

class Program {

    // ─── Ejercicio 1: Suma de dígitos (por valor) ─────────────────────────
    static int SumaDigitos(int numero) {
        int suma = 0;
        while (numero > 0) {
            suma   += numero % 10;
            numero /= 10;
        }
        return suma;
    }

    // ─── Ejercicio 2: Correo institucional ────────────────────────────────
    static string GenerarCorreo(string primerNombre, string segundoNombre,
                                 string apellidoPaterno, string apellidoMaterno) {
        string correo =
            primerNombre[0].ToString().ToLower()   +
            segundoNombre[0].ToString().ToLower()  +
            apellidoPaterno.ToLower()               +
            apellidoMaterno[0].ToString().ToLower() +
            "@correo.url.edu.gt";
        return correo;
    }

    // ─── Ejercicio 3: Conversión de temperatura ───────────────────────────
    // celsius llega como string "C = 25" (por valor)
    // fahrenheit se devuelve también por referencia
    static string ConvertirTemperatura(string celsiusStr, ref double fahrenheit) {
        // "C = 25" -> tomamos desde el índice 4 en adelante
        double celsius = Convert.ToDouble(celsiusStr.Substring(4));
        fahrenheit = (celsius * 9.0 / 5.0) + 32;
        return "F = " + fahrenheit;
    }

    // ─── Ejercicio 4.1: agregarPuntos ────────────────────────────────────
    static int AgregarPuntos(ref int puntos) {
        puntos += 10;
        if (puntos > 100) puntos = 100;
        return puntos;
    }

    // ─── Ejercicio 4.2: quitarPuntos ─────────────────────────────────────
    static int QuitarPuntos(ref int puntos) {
        puntos -= 7;
        if (puntos < 0) puntos = 0;
        return puntos;
    }

    // ─── Ejercicio 4.3: obtenerNivel ─────────────────────────────────────
    static string ObtenerNivel(int puntos) {
        if (puntos >= 80) return "Avanzado";
        if (puntos >= 50) return "Intermedio";
        return "Básico";
    }

    // ─── Ejercicio 4.4: evaluarEstado ────────────────────────────────────
    static string EvaluarEstado(int puntos) {
        if (puntos == 100) return "Excelente";
        if (puntos >= 70)  return "Aprobado";
        return "Reprobado";
    }

    // ─── Main ─────────────────────────────────────────────────────────────
    static void Main() {

        // Ejercicio 1
        Console.WriteLine("=== Ejercicio 1: Suma de dígitos ===");
        Console.WriteLine("SumaDigitos(1234) = " + SumaDigitos(1234));
        Console.WriteLine("SumaDigitos(905)  = " + SumaDigitos(905));

        // Ejercicio 2
        Console.WriteLine("\n=== Ejercicio 2: Correo Institucional ===");
        Console.WriteLine(GenerarCorreo("Juan",     "Carlos", "Morales", "Paz"));
        Console.WriteLine(GenerarCorreo("Angelica",  "Paola",  "Lopez",   "Santos"));

        // Ejercicio 3
        Console.WriteLine("\n=== Ejercicio 3: Conversión de Temperatura ===");
        double fahrenheit = 0;
        string resultado  = ConvertirTemperatura("C = 25", ref fahrenheit);
        Console.WriteLine(resultado);

        fahrenheit = 0;
        resultado  = ConvertirTemperatura("C = 0", ref fahrenheit);
        Console.WriteLine(resultado);

        // Ejercicio 4
        Console.WriteLine("\n=== Ejercicio 4: Sistema de puntos ===");
        int puntos = 50;
        Console.WriteLine("Puntos iniciales: " + puntos);

        AgregarPuntos(ref puntos);
        Console.WriteLine("Después de agregar 10: " + puntos);
        Console.WriteLine("Nivel:  " + ObtenerNivel(puntos));
        Console.WriteLine("Estado: " + EvaluarEstado(puntos));

        QuitarPuntos(ref puntos);
        Console.WriteLine("\nDespués de quitar 7: " + puntos);
        Console.WriteLine("Nivel:  " + ObtenerNivel(puntos));
        Console.WriteLine("Estado: " + EvaluarEstado(puntos));

        // Llevar a 100 para probar límite máximo
        for (int i = 0; i < 10; i++) AgregarPuntos(ref puntos);
        Console.WriteLine("\nTras varios aumentos (máx 100): " + puntos);
        Console.WriteLine("Estado: " + EvaluarEstado(puntos));

        Console.ReadLine();
    }
}
