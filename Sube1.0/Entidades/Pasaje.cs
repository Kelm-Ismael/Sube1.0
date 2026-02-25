using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasaje : Operacion
    {
        // Campos
        private byte _linea;
        private short _unidad;
        private MedioDePago _medioDePago;

        // Propiedades
        public byte Linea
        {
            get => _linea;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Línea inválida, debe ser mayor a cero.");
                _linea = value;
            }
        }

        public short Unidad
        {
            get => _unidad;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Unidad inválida, debe ser mayor a cero.");
                _unidad = value;
            }
        }
        // Propiedad de solo lectura para el medio de pago
        public MedioDePago MedioDePago
        {
            get => _medioDePago;
            private set => _medioDePago = value;
        }

        // Constructores
        public Pasaje(Cuenta cuenta, DateTime fecha, decimal monto, MedioDePago medioDePago) : base(cuenta, fecha, monto)
        {
            MedioDePago = medioDePago;
            Linea = 1;
            Unidad = 1;
        }

        public Pasaje(Cuenta cuenta, DateTime fecha, decimal monto, MedioDePago medioDePago, byte linea) : this(cuenta, fecha, monto, medioDePago)
        {
            Linea = linea;

        }

        public Pasaje(Cuenta cuenta, DateTime fecha, decimal monto, MedioDePago medioDePago, byte linea, short unidad) : this(cuenta, fecha, monto, medioDePago, linea)
        {
            Unidad = unidad;

        }

        // Siempre devuelve el monto negativo
        public override decimal Monto
        {
            get => -Math.Abs(base.Monto);
            set => base.Monto = Math.Abs(value);
        }

        public override string ToString()
        {
            return $"Pasaje - Fecha: {Fecha} - Monto: {Monto} - Línea: {Linea} - Unidad: {Unidad}";
        }
    }

    
}
