using System;


namespace PracticaOctubre16{

public class Circulo : Figura 
{
public double Radio {get;set;}

public override double CalcularArea(){

    double area = Math.PI * (Radio * Radio);

    return area;

}

}

}