namespace Entidades
{
    public abstract class Operacion
    {
        private DateTime fecha;
        private decimal monto;
        public Cuenta Cuenta { get; }

        

        public DateTime Fecha
        {
            get => fecha;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("La fecha de la operación no puede ser futura.");
                fecha = value;
            }
        }

        public virtual decimal Monto
        {
            get => monto;
            set
            {
                if (value < 0)
                    throw new ArgumentException("El monto de la operación es Invàlido, debe ser mayor a cero.");
                monto = value;
            }
        }

        public Operacion(Cuenta cuenta, DateTime fecha, decimal monto)
        {
            Cuenta = cuenta;
            Fecha = fecha;
            Monto = monto;
           
        }

        public override string ToString()
        {
            return $"Fecha: {Fecha} - Monto: {Monto}";
        }

    }


}
