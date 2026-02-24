using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuenta
    {
        private int numero;
        public readonly decimal saldo { get; }
        private List<Operacion> Operacion = new();

        //
        public Pasajero Pasajero { get; }

        public int Numero
        {
            get => numero;
            set
            {
                if (value <= 0)
                    throw new Exception("El numero de cuenta debe ser mayor a 0");
                numero = value;
            }
        }

        public decimal Saldo
        {
            get
            {
                decimal total = 0;

                foreach (Operacion operacion in Operacion)
                {
                    total += operacion.Monto;
                }
                return total;
            }
        }

        public void AddOperacion(Operacion operacion)
        {
            if (saldo + operacion.Monto < 0)
                throw new Exception($"Saldo ( ${saldo} ) insuficiente para realizar esta operación.");
            Operacion.Add(operacion);
        }

        public void RemoveOperacion(Operacion operacion)
        {

            Operacion.Remove(operacion);
        }

        public List<Operacion> GetOperacion()
        {
            return Operacion;
        }

        public Cuenta(int numero, Pasajero pasajero)
        {
            Numero = numero;
            Pasajero = pasajero;
        }

        public override string ToString()
        {
            return $"Numero de cuenta: {Numero} - Pasajero: {Pasajero}";
        }
    }
}
