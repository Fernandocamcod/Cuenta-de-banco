using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario los datos necesarios para crear una cuenta bancaria
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine(); // Leer el nombre del usuario

        Console.Write("Ingrese su apellido: ");
        string apellido = Console.ReadLine(); // Leer el apellido del usuario

        Console.Write("Ingrese el saldo inicial de la cuenta: ");
        double saldoInicial = Convert.ToDouble(Console.ReadLine()); // Leer el saldo inicial y convertirlo a double

        // Crear una nueva instancia de la clase Banco
        Banco cuenta = new Banco(nombre, apellido, saldoInicial);

        bool continuar = true; // Variable para controlar el bucle del menú

        while (continuar)
        {
            // Mostrar el menú de opciones al usuario
            Console.WriteLine("\nSeleccione una operación:");
            Console.WriteLine("1. Depositar dinero");
            Console.WriteLine("2. Retirar dinero");
            Console.WriteLine("3. Consultar saldo");
            Console.WriteLine("4. Salir");

            // Leer la opción elegida por el usuario
            Console.Write("Ingrese su opción (1-4): ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            // Realizar la operación correspondiente según la opción elegida
            switch (opcion)
            {
                case 1:
                    // Opción para depositar dinero
                    Console.Write("Ingrese la cantidad a depositar: ");
                    double deposito = Convert.ToDouble(Console.ReadLine()); // Leer y convertir la cantidad a double
                    cuenta.Depositar(deposito); // Llamar al método Depositar
                    break;
                case 2:
                    // Opción para retirar dinero
                    Console.Write("Ingrese la cantidad a retirar: ");
                    double retiro = Convert.ToDouble(Console.ReadLine()); // Leer y convertir la cantidad a double
                    cuenta.Retirar(retiro); // Llamar al método Retirar
                    break;
                case 3:
                    // Opción para consultar saldo
                    cuenta.ConsultarSaldo(); // Llamar al método ConsultarSaldo
                    break;
                case 4:
                    // Opción para salir del programa
                    continuar = false; // Cambiar la variable para salir del bucle
                    Console.WriteLine("Gracias por usar el sistema de cuentas bancarias.");
                    break;
                default:
                    // Mensaje para opción no válida
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        }
    }
}
