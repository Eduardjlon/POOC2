using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    internal class Auto : Vehiculo
    {
        private int numeroDePuertas;

        public int NumeroDePuertas
        {
            get { return numeroDePuertas; }
            set { numeroDePuertas = value; }
        }

        public Auto(string marca, string modelo, int año, int kilometraje, int numeroDePuertas)
            : base(marca, modelo, año, kilometraje)
        {
            this.numeroDePuertas = numeroDePuertas;
        }

        public override void Encender()
        {
            Console.WriteLine($"El auto {Marca} {Modelo} está encendido.");
        }

        public override void Apagar()
        {
            Console.WriteLine($"El auto {Marca} {Modelo} está apagado.");
        }

        public override void Conducir(int km)
        {
            Kilometraje += km;
            Console.WriteLine($"Condujiste el auto {Marca} {Modelo} por {km} km. Kilometraje total: {Kilometraje} km.");
        }
    }
}
