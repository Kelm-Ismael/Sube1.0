using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carga : Operacion
    {
        public Cuenta Cuenta { get; }
        public MedioDePago MedioDePago { get; }

        public Carga(decimal monto, DateTime fecha, Cuenta cuenta, MedioDePago medioDePago) : base(monto, fecha, cuenta)
        {

            MedioDePago = medioDePago;
            //cuenta.AddOperacion(this);
        }

        public override string ToString()
        {
            return $"Carga: - {base.ToString()} - Medio de Pago: {MedioDePago}";
        }
    }
}
