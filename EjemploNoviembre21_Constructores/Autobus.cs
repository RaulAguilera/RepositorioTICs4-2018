namespace EjemploNoviembre21_Constructores {

public class Autobus {

    //Constructor default
    public Autobus()
    {}

    //Constructor con 3 parametros
    public Autobus(string modelo, int kilometraje, bool activo)
    {
        Modelo = modelo;
        Kilometraje = kilometraje;
        Activo = activo;
    }

    public string Modelo { get;set;}

    public int Kilometraje {get;set;}

    public bool Activo {get;set;}

}

}