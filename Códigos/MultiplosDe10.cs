// iTz_DiLAN

using System;

namespace Multiplos10X{
    public class Program{
        public static void Main(string[] args){
            bool flag = true;
            while(flag){
                System.Console.Write("Ingrese un numero: ");
                int numero = System.Convert.ToInt32(System.Console.ReadLine());

                System.Console.WriteLine(numero * 10);
                if(numero == 0){
                    System.Console.WriteLine("Cerrando programa...");
                    flag = false;
                }
            }
        }
    }
}
