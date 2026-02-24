using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasaje : Operacion
    {

        private byte linea;
        private Int16 unidad;
     
        public MedioDePago MedioDePago { get; }

        public byte Linea
        {
            get => linea;
            set
            {
                if (value < 0 )
                    throw new Exception("La linea no puede ser menor a 0");
                linea = value;
            }
        }

        public Int16 Unidad
        {
            get => unidad;
            set
            {
                if (value < 0)
                    throw new Exception("La unidad no puede ser menor a 0");
                unidad = value;
            }
        }

        public override decimal Monto
        {
            get => -Math.Abs(base.Monto);
            protected set => base.Monto = Math.Abs(value);
            
        }

        public Pasaje(decimal monto, DateTime fecha, Cuenta cuenta, MedioDePago mediopago) : base(monto, fecha, cuenta)
        {
            MedioDePago = mediopago;

        }
        public Pasaje(decimal monto, DateTime fecha, Cuenta cuenta, MedioDePago mediopago, byte linea ) : base(monto, fecha, cuenta)
        {
            Linea = linea;
        }
        public Pasaje(decimal monto, DateTime fecha, Cuenta cuenta, MedioDePago mediopago, byte linea, Int16 unidad) : base(monto, fecha, cuenta)
        {
            Unidad = unidad;
        }

        public override string ToString()
        {
            return $"Pasaje: - {base.ToString()} - Linea: {Linea} - Unidad: {Unidad}";
        }
    }
}
