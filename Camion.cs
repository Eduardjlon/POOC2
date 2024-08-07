using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    internal class Camion : Vehiculo
    {
        private int capacidadDeCarga;

        public int CapacidadDeCarga
        {
            get { return capacidadDeCarga; }
            set { capacidadDeCarga = value; }
        }

        public Camion(string marca, string modelo, int año, int kilometraje, int capacidadDeCarga)
            : base(marca, modelo, año, kilometraje)
        {
            this.capacidadDeCarga = capacidadDeCarga;
        }

        public override void Encender()
        {
            Console.WriteLine($"El camión {Marca} {Modelo} está encendido.");
        }

        public override void Apagar()
        {
            Console.WriteLine($"El camión {Marca} {Modelo} está apagado.");
        }

        public override void Conducir(int km)
        {
            Kilometraje += km;
            Console.WriteLine($"Condujiste el camión {Marca} {Modelo} por {km} km. Kilometraje total: {Kilometraje} km.");
        }

        public override string ToString()
        {
            return base.ToString() + $" - Capacidad de carga: {capacidadDeCarga} toneladas";
        }
    }
}
