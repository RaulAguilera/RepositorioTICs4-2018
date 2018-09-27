namespace EjemploClases { //Espacio de nombres

    public class Automovil { //Declaracion de la clase
        //Atributos
        public int VelocidadActual { get; set; }
        public bool Encendido { get; set; }
        public int KilometrajeActual {get;set;}
        private int KilometrajeRevision = 1000;
        //Metodos
        /*
        Modificador de accesso
        Tipo de dato de retorno
        Nombre del método
        Parámetros
        Cuerpo del método
         */

        public void Acelerar(int velocidadAumentar)
        {
            VelocidadActual = VelocidadActual + velocidadAumentar;
        }

        public bool NecesitaRevision()
        {
            if(KilometrajeActual > KilometrajeRevision)
                return true;
            else
                return false;
        }
    }
}