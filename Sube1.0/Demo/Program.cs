using Entidades;

namespace Demo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\t\t\t_____Sube_____\n");
            // Sube
            Sube.valorPasaje = 2500;
            Sube.montoMinimo = 500;

            Console.WriteLine($"New - Valor del pasaje: {Sube.valorPasaje}");
            Console.WriteLine($"New - Monto Mìnimo: {Sube.valorPasaje}");

            // Pasajeros
            Pasajero pasajero1 = new("Juan Perez", 12345678);
            Pasajero pasajero2 = new("Maria Gomez", 87654321);
            Pasajero pasajero3 = new("Pedro Simon", 50004119);

            // Agregar pasajeros a Sube
            Sube.AddPasajero(pasajero1);
            Sube.AddPasajero(pasajero2);
            Sube.AddPasajero(pasajero3);

            try
            {
                Pasajero pasajero4 = new("Ana", -12345678);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\t\tError al crear pasajero: " + ex.Message);
            }
            // Mostrar pasajeros
            Console.WriteLine("\tLista de Pajeros\n");

            foreach (Pasajero pasajero in Sube.GetPasajeros())
            {
                Console.WriteLine("New: " + pasajero);
            }

            // Cuentas
            Cuenta cuenta1 = new(pasajero1, 10001);
            Cuenta cuenta2 = new(pasajero2, 20002);
            Cuenta cuenta3 = new(pasajero3, 30003);
            Cuenta cuenta4 = new(pasajero1, 40004);


            try
            {
                Cuenta cuenta5 = new(pasajero1, -10001);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\t\tError al crear cuenta: " + ex.Message);
            }
            //IMPLEMNTACION METODO PARA AGREGAR CUENTA A SUBE

            Console.WriteLine();
            Sube.GetCuentas().Add(cuenta1); // CONSUTLAR
            Sube.GetCuentas().Add(cuenta2); // CONSULTAR
            Sube.GetCuentas().Add(cuenta3);// CONSULTAR

            Console.WriteLine();
            Console.WriteLine("new: " + cuenta1);
            Console.WriteLine("new: " + cuenta2);
            Console.WriteLine("new: " + cuenta3);
            Console.WriteLine();

            //Operacion Carga

            cuenta1.AddOperacion(new Carga(cuenta1, DateTime.Now, 5000, MedioDePago.Efectivo));
            cuenta2.AddOperacion(new Carga(cuenta2, DateTime.Now, 7000, MedioDePago.TarjetaDeCredito));
            cuenta3.AddOperacion(new Carga(cuenta3, DateTime.Now, 9000, MedioDePago.TarjetaDeDebito));
            cuenta4.AddOperacion(new Carga(cuenta1, DateTime.Now, 3000, MedioDePago.Efectivo));

            try
            {
                cuenta4.AddOperacion(new Carga(cuenta4, DateTime.Now, -5000, MedioDePago.Efectivo));
            }
            catch (Exception ex)
            {
                Console.WriteLine("\t\tError al agregar operacion de carga: " + ex.Message);
            }

            Console.WriteLine();
            // Operacion pasajes
            cuenta1.AddOperacion(new Pasaje(cuenta1, DateTime.Now, Sube.valorPasaje, MedioDePago.Efectivo, 60, 235));
            cuenta2.AddOperacion(new Pasaje(cuenta2, DateTime.Now, Sube.valorPasaje, MedioDePago.TarjetaDeCredito, 60));
            cuenta3.AddOperacion(new Pasaje(cuenta3, DateTime.Now, Sube.valorPasaje, MedioDePago.TarjetaDeDebito));

            //List<Cuenta> cuentas = new() { cuenta1, cuenta2, cuenta3 }; // CONSULTAR SI CREAR UNA LISTA CUENTA O CREAR LISTA DE CUENTA EN SUBE 

            //foreach (Cuenta cuenta in cuentas)
            //{
            //    Console.WriteLine(cuenta.pasajero);
            //    Console.WriteLine(cuenta);

            //    foreach (Operacion operacion in cuenta.GetOperaciones())
            //    {
            //        Console.WriteLine("   " + operacion);
            //    }

            //    Console.WriteLine($"   Saldo actual: {cuenta.saldo}\n");
            //}


            //implemente el metodo para obtener las cuentas de sube y mostrar sus operaciones

            foreach (Cuenta cuenta in Sube.GetCuentas())
            {
                Console.WriteLine(cuenta.pasajero);
                Console.WriteLine(cuenta);

                Console.WriteLine();
                foreach (Operacion operacion in cuenta.GetOperaciones())
                {
                    Console.WriteLine("New: " + operacion);
                }

                Console.WriteLine($"   Saldo actual: {cuenta.saldo}\n");
            }



        }

    }
}
}
}
