using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    internal abstract class Vehiculo
    {
        private string marca;
        private string modelo;
        private int año;
        private int kilometraje;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int Año
        {
            get { return año; }
            set { año = value; }
        }

        public int Kilometraje
        {
            get { return kilometraje; }
            set { kilometraje = value; }
        }

        public Vehiculo(string marca, string modelo, int año, int kilometraje)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.año = año;
            this.kilometraje = kilometraje;
        }

        public abstract void Encender();
        public abstract void Apagar();
        public abstract void Conducir(int km);

        public override string ToString()
        {
            return $"{marca} {modelo} ({año}) - {kilometraje} km";
        }
    }
}
