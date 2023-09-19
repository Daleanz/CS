using System;

namespace Potencia{
    public class Program{
        public static void Main(string[] args){
            bool flag = true;
            while(flag){
                System.Console.WriteLine("Potencia");
                System.Console.Write("Ingrese la base: ");
                int Base = System.Convert.ToInt32(System.Console.ReadLine());

                System.Console.Write("Ingrese el exponente: ");
                int Exponente = System.Convert.ToInt32(System.Console.ReadLine());

                double potencia = Math.Pow(Base, Exponente);
                System.Console.WriteLine($"{Base} elevado a {Exponente} = {potencia}");

                System.Console.Write("¿Continuar? Presione (1): ");
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
