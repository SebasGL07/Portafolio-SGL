using System;

class Program {
    static void Main() {

        // ══════════════════════════════════════════════════════════════════
        //  DESAFÍO 1: Número Positivo, Negativo o Cero
        //  Entrada:  número entero ingresado por el usuario
        //  Proceso:  comparar el número con cero
        //  Salida:   indicar si es positivo, negativo o cero
        // ══════════════════════════════════════════════════════════════════
        Console.WriteLine("=== Desafío 1: Positivo, Negativo o Cero ===");
        Console.Write("Ingrese un número entero: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 0)
            Console.WriteLine("El número " + numero + " es POSITIVO.");
        else if (numero < 0)
            Console.WriteLine("El número " + numero + " es NEGATIVO.");
        else
            Console.WriteLine("El número es CERO.");

        // ══════════════════════════════════════════════════════════════════
        //  DESAFÍO 2: Año Bisiesto
        //  Entrada:  año (número entero)
        //  Proceso:  divisible entre 4 y no entre 100, EXCEPTO si es
        //            divisible entre 400
        //  Salida:   indicar si es bisiesto o no
        // ══════════════════════════════════════════════════════════════════
        Console.WriteLine("\n=== Desafío 2: Año Bisiesto ===");
        Console.Write("Ingrese un año: ");
        int anio = int.Parse(Console.ReadLine());

        bool esBisiesto;
        if (anio % 400 == 0)
            esBisiesto = true;
        else if (anio % 100 == 0)
            esBisiesto = false;
        else if (anio % 4 == 0)
            esBisiesto = true;
        else
            esBisiesto = false;

        if (esBisiesto)
            Console.WriteLine("El año " + anio + " SÍ es bisiesto.");
        else
            Console.WriteLine("El año " + anio + " NO es bisiesto.");

        // ══════════════════════════════════════════════════════════════════
        //  DESAFÍO 3: Boleto de Ornato
        //  Entrada:  ingresoMensual (double), multa (bool)
        //  Proceso:  determinar arbitrio según rango de ingreso;
        //            si multa = true, el costo se duplica
        //  Salida:   monto a contribuir al ornato
        // ══════════════════════════════════════════════════════════════════
        Console.WriteLine("\n=== Desafío 3: Boleto de Ornato ===");
        Console.Write("Ingrese su ingreso mensual (Q): ");
        double ingresoMensual = Convert.ToDouble(Console.ReadLine());

        Console.Write("¿Tiene multa? (true/false): ");
        bool multa = Convert.ToBoolean(Console.ReadLine());

        double arbitrio;
        if (ingresoMensual > 12000)
            arbitrio = multa ? 300.00 : 150.00;
        else if (ingresoMensual > 9000)
            arbitrio = multa ? 200.00 : 100.00;
        else if (ingresoMensual > 6000)
            arbitrio = multa ? 150.00 : 75.00;
        else if (ingresoMensual > 3000)
            arbitrio = multa ? 100.00 : 50.00;
        else if (ingresoMensual > 1000)
            arbitrio = multa ? 30.00 : 15.00;
        else if (ingresoMensual > 500)
            arbitrio = multa ? 20.00 : 10.00;
        else {
            Console.WriteLine("Su ingreso no está en el rango de contribución.");
            arbitrio = 0;
        }

        if (arbitrio > 0)
            Console.WriteLine("Monto a contribuir al ornato: Q" + arbitrio.ToString("F2"));

        // ══════════════════════════════════════════════════════════════════
        //  DESAFÍO 4: Máquina de Pago de Parqueo
        //  Entrada:  horas estacionado (int), monto de pago (int)
        //  Proceso:  calcular total (horas * Q10), calcular vuelto y
        //            descomponer en billetes usando DIV y MOD
        //  Salida:   mensaje de error, sin cambio, o desglose de vuelto
        // ══════════════════════════════════════════════════════════════════
        Console.WriteLine("\n=== Desafío 4: Máquina de Parqueo ===");
        Console.Write("Ingrese las horas estacionado: ");
        int horasEstacionado = int.Parse(Console.ReadLine());

        int totalPagar = horasEstacionado * 10;
        Console.WriteLine("Total a pagar: Q" + totalPagar);

        Console.Write("Ingrese el monto de pago (solo billetes): ");
        int montoIngresado = int.Parse(Console.ReadLine());

        if (montoIngresado < totalPagar) {
            Console.WriteLine("Error, los fondos no son suficientes.");
        } else if (montoIngresado == totalPagar) {
            Console.WriteLine("No se requiere cambio, ¡Feliz día!");
        } else {
            int vuelto = montoIngresado - totalPagar;
            Console.WriteLine("Cambio -> Q" + vuelto);

            int billetes100 = vuelto / 100;
            vuelto          = vuelto % 100;

            int billetes50  = vuelto / 50;
            vuelto          = vuelto % 50;

            int billetes20  = vuelto / 20;
            vuelto          = vuelto % 20;

            int billetes10  = vuelto / 10;
            vuelto          = vuelto % 10;

            int billetes5   = vuelto / 5;
            vuelto          = vuelto % 5;

            int billetes1   = vuelto;

            Console.WriteLine("Billetes de Q100: " + billetes100);
            Console.WriteLine("Billetes de Q50:  " + billetes50);
            Console.WriteLine("Billetes de Q20:  " + billetes20);
            Console.WriteLine("Billetes de Q10:  " + billetes10);
            Console.WriteLine("Billetes de Q5:   " + billetes5);
            Console.WriteLine("Billetes de Q1:   " + billetes1);
        }

        Console.WriteLine("\nPresione Enter para salir...");
        Console.ReadLine();
    }
}
