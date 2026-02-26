using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasajero
    {
        private string nombre;
        private int dni;

        public string Nombre
        {
            get => nombre;
            set 
            {
                if (nombre != null)
                    throw new Exception("Nombre inválido.");
                nombre = value;
            }
        }

        public int Dni
        {
            get => dni;
            set
            {
                if (value < 10000000 || value > 99999999)
                    throw new ArgumentException("El dni debe tener exactamente 8 dígitos");
                dni = value;
            }
        }

        public Pasajero(string nombre, int dni)
        {
            Nombre = nombre;
            Dni = dni;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre} - DNI: {Dni}";
        }

    }
}
