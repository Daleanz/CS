// iTz_DiLAN

using System;

namespace TablaMultiplicar{
    public class Program{
        public static void Main(string[] args){

            string mensaje = "Tabla de Multiplicar \r\n¿Tabla de que numero quiere ver?";
            bool flag = true;

            while(flag){
                System.Console.WriteLine(mensaje);
                System.Console.Write("Ingrese el numero: ");
                int numero = System.Convert.ToInt32(System.Console.ReadLine());
                System.Console.Write("Ingrese el rango de la tabla: ");
                int rango = System.Convert.ToInt32(System.Console.ReadLine());

                for(int i = 1; i <= rango; i ++){
                    System.Console.WriteLine($"{numero} x {i} = {numero * i}");
                }

                System.Console.Write("¿Continuar? (1) Si: ");
                int opcion = System.Convert.ToInt32(System.Console.ReadLine());
                if(opcion == 1){
                    flag = true;
                }else{
                    System.Console.WriteLine("Cerrando programa...");
                    flag = false;
                }
            }
        }
    }
}
