// iTz_DiLAN

using System;

namespace CelsiusFahrenheit{
    public class Program{
        public static void Main(string[] args){
            bool flag = true;
            while(flag){
                System.Console.WriteLine("Convertir Grados Celcius a Grados Fahrenheit");
                System.Console.Write("Ingrese los grados en celcius: ");
                double celcius = System.Convert.ToDouble(System.Console.ReadLine());
                double conversionGrados = ConvertirToFahrenheit(celcius);

                System.Console.WriteLine($"La conversion de {celcius}°C es igual a {conversionGrados}°F");

                System.Console.Write("¿Continuar? Presione (1): ");
                int opcion = System.Convert.ToInt32(System.Console.ReadLine());
                if(opcion == 1){
                    flag = true;
                }else{
                    System.Console.WriteLine("Cerrando programa...");
                    flag = false;
                }
            }
            // Función encargada de la conversión de grados.
            static double ConvertirToFahrenheit(double gradosCelcius){
                double fahrenheit = (gradosCelcius * 9 / 5) + 32;
                return fahrenheit;
            }
        }
    }
}
