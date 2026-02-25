namespace Entidades
{
    public abstract class Operacion
    {

        public decimal _monto;

        public DateTime Fecha;
        private Cuenta Cuenta { get; set; }

        public virtual decimal Monto
        {
            get => _monto;
            set
            {
                if (value <= 0)
                    throw new Exception($"Monto inválido: {value}");

                _monto = value;
            }
        }

        public DateTime fecha
        {
            get => Fecha;

        }

        public Cuenta cuenta
        {
            get => Cuenta;
            set
            {
                if (value == null)
                    throw new Exception("Cuenta inválida.");
                Cuenta = value;
            }

        }


        protected Operacion(Cuenta cuenta, DateTime fecha, decimal monto)
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
