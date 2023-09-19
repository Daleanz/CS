using System;

namespace SerieFibonacci{
    public class Program{
        public static void Main(string[] args){
            System.Console.Write("Ingrese el numero para la serie de fibonacci: ");
            int num = System.Convert.ToInt32(System.Console.ReadLine());

            int a = 0, b = 1;
            for(int i = 0; i <= num; i ++){
                System.Console.Write(a + " ");
                int temp = a;
                a = b;
                b = temp + b;
            }
        }
    }
}
