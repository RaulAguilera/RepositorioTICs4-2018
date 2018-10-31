namespace PracticaOctubre16 {

public class Triangulo : Figura {

    public override double CalcularArea(){ //Sobreescribimos metodo CalcularArea palabra clave es: Override
        double area = (Base * Altura)/2;

        return area;
    }
}

}