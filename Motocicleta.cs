using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    internal class Motocicleta : Vehiculo
    {
        private string tipoDeMoto;

        public string TipoDeMoto
        {
            get { return tipoDeMoto; }
            set { tipoDeMoto = value; }
        }

        public Motocicleta(string marca, string modelo, int año, int kilometraje, string tipoDeMoto)
            : base(marca, modelo, año, kilometraje)
        {
            this.tipoDeMoto = tipoDeMoto;
        }

        public override void Encender()
        {
            Console.WriteLine($"La motocicleta {Marca} {Modelo} está encendida.");
        }

        public override void Apagar()
        {
            Console.WriteLine($"La motocicleta {Marca} {Modelo} está apagada.");
        }

        public override void Conducir(int km)
        {
            Kilometraje += km;
            Console.WriteLine($"Condujiste la motocicleta {Marca} {Modelo} por {km} km. Kilometraje total: {Kilometraje} km.");
        }

        public override string ToString()
        {
            return base.ToString() + $" - Tipo de motocicleta: {tipoDeMoto}";
        }
    }
}
