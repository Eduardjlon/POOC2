using System;

namespace POO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Seleccione el tipo de vehículo a crear:");
                Console.WriteLine("1. Auto");
                Console.WriteLine("2. Motocicleta");
                Console.WriteLine("3. Camión");
                Console.WriteLine("4. Salir");
                var opcion = Console.ReadLine();

                if (opcion == "4")
                    break;

                Console.Write("Ingrese la marca: ");
                var marca = Console.ReadLine();

                Console.Write("Ingrese el modelo: ");
                var modelo = Console.ReadLine();

                Console.Write("Ingrese el año: ");
                var año = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el kilometraje: ");
                var kilometraje = int.Parse(Console.ReadLine());

                Vehiculo vehiculo = null;

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el número de puertas: ");
                        var numeroDePuertas = int.Parse(Console.ReadLine());
                        vehiculo = new Auto(marca, modelo, año, kilometraje, numeroDePuertas);
                        break;
                    case "2":
                        Console.Write("Ingrese el tipo de motocicleta (Deportiva, Cruiser, etc.): ");
                        var tipoDeMoto = Console.ReadLine();
                        vehiculo = new Motocicleta(marca, modelo, año, kilometraje, tipoDeMoto);
                        break;
                    case "3":
                        Console.Write("Ingrese la capacidad de carga (en toneladas): ");
                        var capacidadDeCarga = int.Parse(Console.ReadLine());
                        vehiculo = new Camion(marca, modelo, año, kilometraje, capacidadDeCarga);
                        break;
                }

                Console.WriteLine($"Vehículo creado: {vehiculo}");

                while (true)
                {
                    Console.WriteLine("Acción:");
                    Console.WriteLine("1. Encender");
                    Console.WriteLine("2. Apagar");
                    Console.WriteLine("3. Conducir");
                    Console.WriteLine("4. Salir al menú principal");
                    var accion = Console.ReadLine();

                    if (accion == "4")
                        break;

                    switch (accion)
                    {
                        case "1":
                            vehiculo.Encender();
                            break;
                        case "2":
                            vehiculo.Apagar();
                            break;
                        case "3":
                            Console.Write("Ingrese los kilómetros a conducir: ");
                            var km = int.Parse(Console.ReadLine());
                            vehiculo.Conducir(km);
                            break;
                    }

                    Console.WriteLine($"Estado actual del vehículo: {vehiculo}");
                }
            }
        }
    }
}
