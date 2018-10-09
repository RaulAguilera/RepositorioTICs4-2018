using System;

namespace ActividadOctubre5{

public class Television{

public int CanalActual { get; set; }

public bool Encendida { get; set; }

public void CambiarCanal(int nuevoCanal)
{
    CanalActual = nuevoCanal;//El nuevo canal que recibimos lo asignamos al atributo canal actual
}

public void BotonPower()
{
    if(Encendida) //Si Encendida es true
    {
        Encendida = false; //Entonces cambiamos Encendida a false
    }
    else{ //Si encendida NO es true
        Encendida = true; //Entonces ponemos Encendida igual a true
    }
}





}



}