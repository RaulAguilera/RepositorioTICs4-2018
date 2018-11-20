namespace PracticaNoviembre12
{
    public class CalculadoraPromedios{

        public void CalcularPromedio(int n1, int n2){
            
            var promedio = (n1 + n2)/2;

            Console.WriteLine(String.Format("Promedio de {0} {1} es: {2}",n1,n2,promedio);

        }

        public void CalcularPromedio(int n1, int n2, int n3){
            
            var promedio = (n1 + n2 + n3)/3;

            Console.WriteLine(String.Format("Promedio de {0} {1} {2} es: {3}",n1,n2,n2,promedio);

        }

public void CalcularPromedio(int n1, int n2, int n3, int n4){
            
            var promedio = (n1 + n2 + n3 + n4)/4;

            Console.WriteLine(String.Format("Promedio de {0} {1} {2} {3} es: {4}",n1,n2,n3,n4,promedio);

        }


    }

}