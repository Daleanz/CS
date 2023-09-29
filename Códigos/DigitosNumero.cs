using System;

namespace DigitosNumero{
    public class Program{
        public static void Main(string[] args){
            bool flag = true;
            while(flag){
                System.Console.Write("Ingrese un numero: ");
                int numero = System.Convert.ToInt32(System.Console.ReadLine());

                if(numero < 0){
                    numero = numero * (-1);
                }
                string Numero = numero.ToString();
                int longitud = Numero.Length;

                System.Console.WriteLine($"El largo del numero {Numero} es: {longitud}");
            }
        }
    }
}
