// iTz_DiLAN

using System;

namespace AreaRectangulo{
    public class Program{
        public static void Main(string[] args){
            bool flag = true;
            while(flag){
                System.Console.WriteLine("Calcular Area Rectangulo");
                System.Console.Write("Ingrese la base del rectangulo: ");
                double BaseRectangulo = System.Convert.ToDouble(System.Console.ReadLine());

                System.Console.Write("Ingrese la altura del rectangulo: ");
                double AlturaRectangulo = System.Convert.ToDouble(System.Console.ReadLine());

                double resultado = CalcularAreaRectangulo(BaseRectangulo, AlturaRectangulo);
                int cantidadDecimales = 2;
                string areaR = resultado.ToString($"F{cantidadDecimales}");
                System.Console.WriteLine($"El are del rectangulo es: {areaR}");

                System.Console.Write("¿Continua? Presione (1): ");

                int opcion = System.Convert.ToInt32(System.Console.ReadLine());
                if(opcion == 1){
                    flag = true;
                }else{
                    System.Console.WriteLine("Cerrando programa...");
                    flag = false;
                }
            }

            static double CalcularAreaRectangulo(double Base, double Altura){
                double areaRectangulo = Base * Altura;
                return areaRectangulo;
            }
        }
    }
}
