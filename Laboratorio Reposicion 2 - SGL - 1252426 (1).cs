using System;

// EJERCICIO 1 - Conceptos Clave
// Clase: Plantilla que define atributos y metodos para describir una entidad del mundo real.
// Atributo: Variable que representa una caracteristica de la clase.
// Metodo: Funcion que define las acciones que puede realizar la clase.
// Constructor: Metodo especial que se ejecuta al crear un objeto e inicializa sus atributos.
// Objeto: Instancia concreta de una clase con valores propios en sus atributos.

// EJERCICIO 2 - Abstraccion

class Libro
{
    string autor;
    int numeroPaginas;
    string editorial;
    string titulo;

    public void CambiarDisponibilidad() { }
}

class HabitacionHotel
{
    int numeroHabitacion;
    DateTime ultimaLimpieza;
    double precioPorNoche;
    bool disponibilidad;
    double consumoMinibar;

    public void SolicitarLimpieza() { }
    public void Reservar() { }
    public void Liberar() { }
}

class Vehiculo
{
    string placa;
    string marca;
    DateTime horaEntrada;
    DateTime horaSalida;
    string color;

    public void ValidarTicket() { }
    public void BajarVentana() { }
}

class Estacionamiento
{
    int capacidad;
    double tarifaPorHora;

    public double CalcularCosto(DateTime entrada, DateTime salida)
    {
        double horas = (salida - entrada).TotalHours;
        return horas * tarifaPorHora;
    }
}

class Estudiante
{
    int carnet;
    double calificacionFinal;
    string correoElectronico;
    string carrera;

    public void PagarMatricula() { }
}

class Curso
{
    int cupoMaximo;
    int carnetDocente;
    string nombre;

    public void AgregarEstudiante() { }
}

// EJERCICIO 3 - CuentaBancaria

class CuentaBancaria
{
    string titular;
    string numeroCuenta;
    double saldo;

    public CuentaBancaria(string numeroCuenta, string titular)
    {
        this.numeroCuenta = numeroCuenta;
        this.titular = titular;
        this.saldo = 200.00;
    }

    public void MostrarCuenta()
    {
        Console.WriteLine("Numero de cuenta: " + numeroCuenta);
        Console.WriteLine("Titular: " + titular);
        Console.WriteLine("Saldo disponible: Q" + saldo.ToString("F2"));
    }

    public void Depositar(double monto)
    {
        saldo += monto;
        Console.WriteLine("Deposito de Q" + monto.ToString("F2") + " realizado.");
    }

    public void Retirar(double monto)
    {
        if (monto <= saldo)
        {
            saldo -= monto;
            Console.WriteLine("Retiro de Q" + monto.ToString("F2") + " realizado.");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para retirar Q" + monto.ToString("F2"));
        }
    }
}

// EJERCICIO 4 - Producto

class Producto
{
    string nombre;
    double precio;
    int inventario;
    double ganancias;

    public Producto(string nombre, double precio)
    {
        this.nombre = nombre;
        this.precio = precio;
        this.inventario = 10;
        this.ganancias = 0.00;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Precio: Q" + precio.ToString("F2"));
        Console.WriteLine("Inventario: " + inventario + " unidades");
        Console.WriteLine("Ganancias: Q" + ganancias.ToString("F2"));
    }

    public void Vender(int cantidad)
    {
        if (cantidad <= inventario)
        {
            inventario -= cantidad;
            ganancias += cantidad * precio;
            Console.WriteLine("Venta de " + cantidad + " unidades realizada.");
        }
        else
        {
            Console.WriteLine("Stock insuficiente. Inventario actual: " + inventario);
        }
    }

    public void Reabastecer(int cantidad)
    {
        inventario += cantidad;
        Console.WriteLine("Reabastecimiento de " + cantidad + " unidades realizado.");
    }
}

// PROGRAMA PRINCIPAL

class Program
{
    static void Main()
    {
        // Ejercicio 3
        Console.WriteLine("========== CUENTAS BANCARIAS ==========");

        CuentaBancaria bac = new CuentaBancaria("123456", "Juan Perez");
        CuentaBancaria banrural = new CuentaBancaria("888888", "Juan Perez");

        Console.WriteLine("\nSaldo inicial:");
        bac.MostrarCuenta();
        Console.WriteLine();
        banrural.MostrarCuenta();

        Console.WriteLine("\nDepositando Q200...");
        bac.Depositar(200);
        banrural.Depositar(200);

        Console.WriteLine("\nRetirando efectivo...");
        bac.Retirar(100);
        banrural.Retirar(10000);

        Console.WriteLine("\nSaldo final:");
        bac.MostrarCuenta();
        Console.WriteLine();
        banrural.MostrarCuenta();

        // Ejercicio 4
        Console.WriteLine("\n========== PRODUCTO ==========");

        Producto computadora = new Producto("Computadora HP", 4560.20);

        Console.WriteLine("\nInformacion inicial:");
        computadora.MostrarInformacion();

        computadora.Vender(8);
        computadora.Reabastecer(5);

        Console.WriteLine("\nInformacion actualizada:");
        computadora.MostrarInformacion();

        Console.Write("\nPresione enter para salir...");
        Console.ReadLine();
    }
}