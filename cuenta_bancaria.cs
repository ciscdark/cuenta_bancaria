using System;

class CuentaBancaria
{
    public string Titular { get; set; }
    public decimal Saldo { get; set; }

    public CuentaBancaria(string titular, decimal saldoInicial)
    {
        Titular = titular;
        Saldo = saldoInicial;
    }

    public void Retirar(decimal monto)
    {
        if (monto <= Saldo)
        {
            Saldo -= monto;
            Console.WriteLine($"Se han retirado {monto:C} de la cuenta de {Titular}. Saldo actual: {Saldo:C}");
        }
        else
        {
            Console.WriteLine($"Fondos insuficientes para retirar {monto:C}. Saldo actual: {Saldo:C}");
        }
    }

    public void Depositar(decimal monto)
    {
        if (monto > 0)
        {
            Saldo += monto;
            Console.WriteLine($"Se han depositado {monto:C} en la cuenta de {Titular}. Saldo actual: {Saldo:C}");
        }
        else
        {
            Console.WriteLine("No se puede depositar un monto negativo o cero.");
        }
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("\n----------------------------------------");
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo: {Saldo:C}");
        Console.WriteLine("----------------------------------------\n");
    }
}

class Program
{
    static void Main()
    {
        CuentaBancaria cuenta1 = new CuentaBancaria("Juan Perez", 1500m);
        CuentaBancaria cuenta2 = new CuentaBancaria("Ana Gómez", 2000m);
        CuentaBancaria cuenta3 = new CuentaBancaria("Carlos López", 500m);

        int opcion;
        decimal monto;

        do
        {
            Console.Clear();
            Console.WriteLine("### MENÚ DE OPERACIONES ###");
            Console.WriteLine("1. Ver información de la cuenta");
            Console.WriteLine("2. Realizar depósito");
            Console.WriteLine("3. Realizar retiro");
            Console.WriteLine("4. Salir");
            Console.Write("\nSeleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\nSeleccione la cuenta:");
                    Console.WriteLine("1. Juan Perez");
                    Console.WriteLine("2. Ana Gómez");
                    Console.WriteLine("3. Carlos López");
                    Console.Write("\nSeleccione una opción: ");
                    int cuentaSeleccionada = int.Parse(Console.ReadLine());

                    switch (cuentaSeleccionada)
                    {
                        case 1:
                            cuenta1.MostrarInformacion();
                            break;
                        case 2:
                            cuenta2.MostrarInformacion();
                            break;
                        case 3:
                            cuenta3.MostrarInformacion();
                            break;
                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("\nSeleccione la cuenta para realizar el depósito:");
                    Console.WriteLine("1. Juan Perez");
                    Console.WriteLine("2. Ana Gómez");
                    Console.WriteLine("3. Carlos López");
                    Console.Write("\nSeleccione una opción: ");
                    cuentaSeleccionada = int.Parse(Console.ReadLine());

                    Console.Write("\nIngrese el monto a depositar: ");
                    monto = decimal.Parse(Console.ReadLine());

                    if (monto > 0)
                    {
                        switch (cuentaSeleccionada)
                        {
                            case 1:
                                cuenta1.Depositar(monto);
                                break;
                            case 2:
                                cuenta2.Depositar(monto);
                                break;
                            case 3:
                                cuenta3.Depositar(monto);
                                break;
                            default:
                                Console.WriteLine("Opción inválida.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("El monto a depositar debe ser mayor que 0.");
                    }
                    break;

                case 3:
                    Console.WriteLine("\nSeleccione la cuenta para realizar el retiro:");
                    Console.WriteLine("1. Juan Perez");
                    Console.WriteLine("2. Ana Gómez");
                    Console.WriteLine("3. Carlos López");
                    Console.Write("\nSeleccione una opción: ");
                    cuentaSeleccionada = int.Parse(Console.ReadLine());

                    Console.Write("\nIngrese el monto a retirar: ");
                    monto = decimal.Parse(Console.ReadLine());

                    if (monto > 0)
                    {
                        switch (cuentaSeleccionada)
                        {
                            case 1:
                                cuenta1.Retirar(monto);
                                break;
                            case 2:
                                cuenta2.Retirar(monto);
                                break;
                            case 3:
                                cuenta3.Retirar(monto);
                                break;
                            default:
                                Console.WriteLine("Opción inválida.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("El monto a retirar debe ser mayor que 0.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Gracias por usar el sistema.");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();

        } while (opcion != 4);
    }
}
