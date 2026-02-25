using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sube
    {
        private static readonly List<Pasajero> pasajeros = new();
        private static readonly List<Cuenta> cuentas = new(); // consultar si esta bien asi
        private static decimal ValorPasaje;
        private static decimal MontoMinimo;

        public static decimal valorPasaje
        {
            get => ValorPasaje;
            set
            {
                if (value <= 0)
                    throw new Exception("El valor del pasaje debe ser mayor a 0");
                ValorPasaje = value;
            }
        }
        public static decimal montoMinimo
        {
            get => MontoMinimo;
            set
            {
                if (value <= 0)
                    throw new Exception("El monto minimo debe ser mayor a 0");
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

        public static List<Cuenta> GetCuentas() // no estaba lo agregue
        {
            return cuentas;
        }
    }
}
