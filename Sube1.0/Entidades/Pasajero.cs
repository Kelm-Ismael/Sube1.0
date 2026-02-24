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

        public int Dni
        {
            get => dni;
            set
            {
                if (value <= 8)
                    throw new Exception("El dni debe tener al menos 8 caracteres"); 
            }
        }

        public string Nombre
        {
            get => nombre;
            set
            {
                if ( nombre.Length > 3)
                    throw new Exception("El nombre debe tener al menos 3 caracteres");
                nombre = value;
            }
        }

        public Pasajero(string nombre, int dni)
        {
            Nombre = nombre;
            Dni = dni;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre} - Dni: {Dni}";
        }

    }
}
