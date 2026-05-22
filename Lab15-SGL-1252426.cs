using System;

// ══════════════════════════════════════════════════════════════════════════════
//  LABORATORIO 15 – Control de Calidad
//
//  EJERCICIO 1 – RESPUESTAS (Tipos de Defectos):
//
//  a) "Ingresar su fecha de nacimiento y presionar Enter:"
//     → DEFECTO DE AMBIGÜEDAD
//     El mensaje no especifica el formato esperado, por lo que los usuarios
//     ingresan la fecha en formatos distintos y el sistema no puede interpretarlas.
//
//  b) División entre cero cuando el usuario ingresa 0 en ambos valores.
//     → DEFECTO MATEMÁTICO
//     La operación cociente (a/b) no está definida cuando b = 0.
//     El programa no valida ese caso antes de ejecutar la división.
//
//  c) "Generar 20 números PARES aleatorios entre 50 y 100 y resaltar en CYAN
//      los que sean PRIMOS."
//     → DEFECTO DE INCONSISTENCIA
//     Los números pares mayores que 2 no pueden ser primos (contradicción
//     interna en el enunciado: pide resaltar primos dentro de un conjunto
//     donde no puede haberlos, salvo el 2 que queda fuera del rango).
//
//  d) Validación bancaria con OR en lugar de AND:
//       if (longitud >= 8 || longitud <= 16)  ← acepta cualquier longitud
//     → DEFECTO LÓGICO
//     El operador correcto es AND (&&), no OR (||).
//     Con OR, una contraseña de 3 caracteres pasa porque 3 <= 16 es true.
// ══════════════════════════════════════════════════════════════════════════════

class Program {

    // ── Métodos del Ejercicio 2 (Testing) ──────────────────────────────────

    // a) RetirarEfectivo
    static void RetirarEfectivo(ref double saldo, double montoRetirado) {
        saldo = saldo - montoRetirado;
    }

    // b) CalcularDescuento
    static double CalcularDescuento(double precio, double porcentaje) {
        return precio - (precio * porcentaje / 100);
    }

    // c) Depositar
    static void Depositar(ref double saldo, double monto) {
        saldo = saldo + monto;
    }

    // ── Main ───────────────────────────────────────────────────────────────
    static void Main() {

        Console.WriteLine("======================================================");
        Console.WriteLine("  LABORATORIO 15 – Control de Calidad");
        Console.WriteLine("======================================================");

        // ── Ejercicio 1: Respuestas impresas ──────────────────────────────
        Console.WriteLine("\n--- Ejercicio 1: Tipos de Defectos ---");
        Console.WriteLine("a) Defecto de AMBIGUEDAD  - No especifica formato de fecha.");
        Console.WriteLine("b) Defecto MATEMATICO     - División entre cero no validada.");
        Console.WriteLine("c) Defecto de INCONSISTENCIA - Números pares no pueden ser primos (>2).");
        Console.WriteLine("d) Defecto LOGICO         - Usa || en lugar de && en la validación.");

        // ── Ejercicio 2: Pruebas de los métodos ───────────────────────────
        Console.WriteLine("\n--- Ejercicio 2a: Pruebas RetirarEfectivo ---");

        // Caso 1: retiro normal (saldo suficiente)
        double saldo1 = 500;
        RetirarEfectivo(ref saldo1, 200);
        Console.WriteLine("Caso 1 | Entrada: saldo=500, retiro=200 | Esperado: 300 | Obtenido: " + saldo1
                          + " | " + (saldo1 == 300 ? "APROBADO" : "REPROBADO"));

        // Caso 2: retiro igual al saldo
        double saldo2 = 300;
        RetirarEfectivo(ref saldo2, 300);
        Console.WriteLine("Caso 2 | Entrada: saldo=300, retiro=300 | Esperado: 0   | Obtenido: " + saldo2
                          + " | " + (saldo2 == 0 ? "APROBADO" : "REPROBADO"));

        // Caso 3: retiro mayor al saldo (DEFECTO – el saldo queda negativo, no se valida)
        double saldo3 = 100;
        RetirarEfectivo(ref saldo3, 500);
        Console.WriteLine("Caso 3 | Entrada: saldo=100, retiro=500 | Esperado: Error/Rechazo | Obtenido: "
                          + saldo3 + " | DEFECTO DETECTADO – saldo negativo no validado");
        Console.WriteLine("Propuesta: validar que montoRetirado <= saldo antes de restar.");

        Console.WriteLine("\n--- Ejercicio 2b: Pruebas CalcularDescuento ---");

        // Caso 1: descuento normal
        double r1 = CalcularDescuento(200, 10);
        Console.WriteLine("Caso 1 | precio=200, desc=10% | Esperado: 180   | Obtenido: " + r1
                          + " | " + (r1 == 180 ? "APROBADO" : "REPROBADO"));

        // Caso 2: descuento 0%
        double r2 = CalcularDescuento(150, 0);
        Console.WriteLine("Caso 2 | precio=150, desc=0%  | Esperado: 150   | Obtenido: " + r2
                          + " | " + (r2 == 150 ? "APROBADO" : "REPROBADO"));

        // Caso 3: porcentaje mayor a 100 (DEFECTO – precio queda negativo)
        double r3 = CalcularDescuento(100, 150);
        Console.WriteLine("Caso 3 | precio=100, desc=150% | Esperado: Error/Rechazo | Obtenido: "
                          + r3 + " | DEFECTO DETECTADO – porcentaje fuera de rango");
        Console.WriteLine("Propuesta: validar que porcentaje esté entre 0 y 100.");

        Console.WriteLine("\n--- Ejercicio 2c: Pruebas Depositar ---");

        // Caso 1: depósito normal
        double s1 = 200;
        Depositar(ref s1, 100);
        Console.WriteLine("Caso 1 | saldo=200, monto=100 | Esperado: 300 | Obtenido: " + s1
                          + " | " + (s1 == 300 ? "APROBADO" : "REPROBADO"));

        // Caso 2: depósito de 0
        double s2 = 400;
        Depositar(ref s2, 0);
        Console.WriteLine("Caso 2 | saldo=400, monto=0   | Esperado: 400 | Obtenido: " + s2
                          + " | " + (s2 == 400 ? "APROBADO" : "REPROBADO"));

        // Caso 3: depósito negativo (DEFECTO – reduce el saldo en lugar de rechazarlo)
        double s3 = 300;
        Depositar(ref s3, -50);
        Console.WriteLine("Caso 3 | saldo=300, monto=-50 | Esperado: Error/Rechazo | Obtenido: "
                          + s3 + " | DEFECTO DETECTADO – monto negativo no validado");
        Console.WriteLine("Propuesta: validar que monto > 0 antes de sumar.");

        // ── Ejercicio 3: Debugging – Simulación de crédito ────────────────
        Console.WriteLine("\n--- Ejercicio 3: Simulación de Crédito (Debugging) ---");
        Console.WriteLine("(Coloca un breakpoint en la línea 'capital = capital + intereses - abonos;')");
        Console.WriteLine();

        double capital   = 1000;
        double tasa      = 0.05;
        double intereses = 0;
        double abonos    = 0;

        for (int mes = 1; mes <= 12 && capital > 0; mes++) {
            intereses = capital * tasa;
            abonos    = 100 + (mes * 10);
            capital   = capital + intereses - abonos;   // ← breakpoint aquí

            // Mostrar estado en los meses requeridos
            if (mes == 2 || mes == 4 || mes == 6 || mes == 8) {
                Console.WriteLine("── Mes " + mes + " ──────────────────────────");
                Console.WriteLine("   capital:   " + capital.ToString("F4"));
                Console.WriteLine("   intereses: " + intereses.ToString("F4"));
                Console.WriteLine("   abonos:    " + abonos.ToString("F4"));
                Console.WriteLine("   tasa:      " + tasa);
                Console.WriteLine("   mes:       " + mes);
            }
        }

        Console.WriteLine("\nPresiona Enter para salir...");
        Console.ReadLine();
    }
}
