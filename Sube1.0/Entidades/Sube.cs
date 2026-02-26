using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sube
    {
        private static decimal ValorPasaje;
        private static decimal MontoMinimo;
        private static readonly List<Cuenta> cuentas = new();
        private static readonly List<Pasajero> pasajeros = new();

        public static decimal valorPasaje
        {
            get => ValorPasaje;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El valor del pasaje debe ser un número positivo.");
                ValorPasaje = value;
            }
        }
        public static decimal montoMinimo
        {
            get => MontoMinimo;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El valor mínimo debe ser un número positivo.");
                MontoMinimo = value;
            }
        }

        public static void AddPasajero(Pasajero pasajero)
        {
            pasajeros.Add(pasajero);
        }

        public static List<Pasajero> GetPasajeros()
        {
            return pasajeros;
        }


        public static List<Cuenta> GetCuentas()
        {
            return cuentas;
        }



    }
}
