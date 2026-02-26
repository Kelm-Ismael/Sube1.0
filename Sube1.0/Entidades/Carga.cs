using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carga : Operacion
    {
        public MedioDePago MedioDePago { get; }

        public Carga(Cuenta cuenta, DateTime fecha, decimal monto, MedioDePago mediodepago) : base(cuenta, fecha, monto)
        {
            MedioDePago = mediodepago;
        }

        public override decimal Monto
        {
            get => base.Monto;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El monto de la carga debe ser mayor a cero.");
                base.Monto = value;
            }
        }

        public override string ToString()
        {
            return $"Carga: {base.ToString()} - MedioDePago {MedioDePago}";
        }

    }
}
