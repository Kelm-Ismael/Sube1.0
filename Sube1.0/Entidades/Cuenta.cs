using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuenta
    {


        private readonly List<Operacion> Operacion = new();

        private int Numero;
        private Pasajero Pasajero;
        private readonly decimal Saldo;


        //propiedades
        public int numero
        {
            get => Numero;
            set
            {
                if (value <= 0)
                    throw new Exception("Número inválido.");
                Numero = value;
            }
        }
        //propiedades
        public Pasajero pasajero
        {
            get => Pasajero;
            set
            {
                Pasajero = value;
            }
        }

        //constructor
        public Cuenta(Pasajero pasajero, int numero)
        {

            Pasajero = pasajero;
            Numero = numero;
        }

        //sobrecarga de ToString
        public decimal saldo
        {
            get
            {
                decimal total = 0;

                foreach (Operacion operaciones in Operacion)
                    total += operaciones.Monto;  // ahora funciona 

                return total;
            }

        }

        // Agrega una operación a la cuenta verificando que el saldo no sea negativo
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

        public List<Operacion> GetOperaciones()
        {
            return Operacion;
        }

        public override string ToString()
        {
            return $"Cuenta N° {Numero} - Pasajero: {pasajero}";
        }


    }


}
