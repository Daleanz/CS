// iTz_DiLAN

using System;

namespace NumerosPares{
    public class Program{
        public static void Main(string[] args){
            bool flag = true;
            while(flag){
                System.Console.Write("Ingrese un numero: ");
                int numero = System.Convert.ToInt32(System.Console.ReadLine());

                if(numero == 0){
                    System.Console.WriteLine("Es un caso especial.");
                }
                if(numero < 0){
                    numero = numero * (-1);
                }    
                if(numero >= 2){
                    if(numero % 2 == 0){
                        System.Console.WriteLine($"El numero {numero} es par.");
                    }else{
                        System.Console.WriteLine("El numero es impar.");
                        flag = false;
                    }
                }
            }
        }
    }
}
