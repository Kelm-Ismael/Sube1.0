using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasaje : Operacion
    {
        //private decimal monto;
        private Int16 unidad;
        private byte linea;
        public MedioDePago MedioDePago { get; }

        public override decimal Monto
        {
            get => -Math.Abs(base.Monto);
            set => base.Monto = Math.Abs(value);

        }

        public Int16 Unidad
        {
            get => unidad;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La unidad debe ser un número positivo.");
                unidad = value;
            }
        }

        public byte Linea
        {
            get => linea;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La línea debe ser un número positivo.");
                linea = value;
            }
        }

        public Pasaje(Cuenta cuenta, DateTime fecha, decimal monto, MedioDePago mediodepago) : base(cuenta, fecha, monto)
        {
            MedioDePago = mediodepago;
            Unidad = 1;
            Linea = 1;
        }

        public Pasaje(Cuenta cuenta, DateTime fecha, decimal monto, MedioDePago mediodepago, byte linea) : this(cuenta, fecha, monto, mediodepago)
        {
            Linea = linea;
        }

        public Pasaje(Cuenta cuenta, DateTime fecha, decimal monto, MedioDePago mediodepago, Int16 unidad, byte linea) : this(cuenta, fecha, monto, mediodepago, linea)
        {
            Unidad = unidad;
        }

        public override string ToString()
        {
            return $"Pasaje: {base.ToString()} - MedioDePago: {MedioDePago} - Unidad: {Unidad} - Linea: {Linea}";


        }

    }
}
