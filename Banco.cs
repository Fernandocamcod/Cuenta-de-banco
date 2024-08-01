using System;

public class Banco
{
    // Propiedades privadas para almacenar el nombre, apellido y saldo de la cuenta
    public string Nombre { get; private set; }
    public string Apellido { get; private set; }
    public double Saldo { get; private set; }

    // Constructor para inicializar la cuenta con nombre, apellido y saldo inicial
    public Banco(string nombre, string apellido, double saldoInicial)
    {
        // Asignar los valores de los parámetros a las propiedades
        Nombre = nombre;
        Apellido = apellido;
        Saldo = saldoInicial;
    }

    // Método para depositar dinero en la cuenta
    public void Depositar(double cantidad)
    {
        // Verificar que la cantidad a depositar sea mayor que cero
        if (cantidad > 0)
        {
            Saldo += cantidad; // Aumentar el saldo con la cantidad depositada
            Console.WriteLine($"Se han depositado {cantidad:C}. Nuevo saldo: {Saldo:C}");
        }
        else
        {
            Console.WriteLine("La cantidad a depositar debe ser mayor que cero.");
        }
    }

    // Método para retirar dinero de la cuenta
    public void Retirar(double cantidad)
    {
        // Verificar que la cantidad a retirar sea válida
        if (cantidad > 0 && cantidad <= Saldo)
        {
            Saldo -= cantidad; // Disminuir el saldo con la cantidad retirada
            Console.WriteLine($"Se han retirado {cantidad:C}. Nuevo saldo: {Saldo:C}");
        }
        else if (cantidad > Saldo)
        {
            Console.WriteLine("Saldo insuficiente para realizar el retiro.");
        }
        else
        {
            Console.WriteLine("La cantidad a retirar debe ser mayor que cero.");
        }
    }

    // Método para consultar el saldo actual de la cuenta
    public void ConsultarSaldo()
    {
        // Mostrar el saldo actual en la consola
        Console.WriteLine($"El saldo actual de {Nombre} {Apellido} es: {Saldo:C}");
    }
}
