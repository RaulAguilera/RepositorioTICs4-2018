namespace PracticaOctubre16{
    public class Figura {
        public double Base {get;set;}
        public double Altura {get;set;}

        //Al ser virtual, el método se puede sobreescribir en una clase derivada.
        public virtual double CalcularArea(){ 
            double area = Base * Altura;

            return area;
        }
    }
}