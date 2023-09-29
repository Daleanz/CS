using System;

namespace NumerosParesProcedimental{
    public class Program{
        public static void Main(string[] args){
            bool flag = true;
            while(flag){
                System.Console.Write("Ingrese un numero: ");
                int numero = System.Convert.ToInt32(System.Console.ReadLine());

                int valor = EsPar(numero);

                if(valor == 1){
                    System.Console.WriteLine("El numero es par.");
                }else{
                    System.Console.WriteLine("El numero es impar.");
                    flag = false;
                } 
            }
            

    }
        static int EsPar(int n){
            if(n == 0){
                return 1;
            }
            if(n < 0){
                n = n * (-1);
            }
            if(n >= 2){
                if(n % 2 == 0){
                    return 1;
                }
                return 0;
            }
            return 0;
        }
    }
}
