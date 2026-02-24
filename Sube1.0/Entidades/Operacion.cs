namespace Entidades
{
    public abstract class Operacion
    {
        private decimal monto;
        private DateTime fecha;

        public Cuenta Cuenta { get; }

        public virtual decimal Monto
        {
            get => monto;
            set
            {
                if (value < 0)
                    throw new Exception("El monto es Invàlido no puede ser menor a 0");

                monto = value;
            }
        }
        public DateTime Fecha
        {
            get => fecha;
            set
            {
                if (value > DateTime.Now)
                    throw new Exception("La fecha no puede ser mayor a la fecha actual");
                fecha = value;
            }
        }
        public Operacion(decimal monto, DateTime fecha, Cuenta cuenta)
        {
            Monto = monto;
            Fecha = fecha;
            Cuenta = cuenta;
        }
        public override string ToString()
        {
            return $"Fecha: {Fecha} - Monto: {Monto}";
        }

    }
}
