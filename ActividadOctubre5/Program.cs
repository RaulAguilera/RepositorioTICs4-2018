using System;

namespace ActividadOctubre5
{
    class Program
    {
        static void Main(string[] args)
        {
           Television tv1 = new Television();

           Console.WriteLine("Canal actual t1: " + tv1.CanalActual);
           Console.WriteLine("La tv1 esta encendida? :" + tv1.Encendida);

           //Mandamos llamar el metodo cambiar canal con parametro nuevocanal = 39
           tv1.CambiarCanal(39);
           //Mandamos llamar el metodo BotonPower, despues de llamarlo la tv estara encendida.
           tv1.BotonPower();

           Console.WriteLine("Canal actual t1 (despues de cambiar canal): " + tv1.CanalActual);
           Console.WriteLine("La tv1 esta encendida? (despues de llamar BotonPower) :"+ tv1.Encendida);

           //Mandamos llamar el metodo BotonPower otra vez, despues de llamarlo la tv estara apagada de nuevo (Encendida = false).
           tv1.BotonPower();

           Console.WriteLine("La tv1 esta encendida? (despues de llamar BotonPower por 2da vez) :"+ tv1.Encendida);

            Console.ReadKey();
        }
    }
}
