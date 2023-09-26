/*

Jeison Salas Coloma - Ingenieria Civil Informatica - S1
15.306.099-1

*/
using System;

namespace problema2{
	public class Program{
		public static void Main(string[] args){
			System.Console.Write("Ingrese el primer numero entero:  ");
			int num1 = System.Convert.ToInt32(System.Console.ReadLine());

			System.Console.Write("Ingrese el segundo numero entero:  ");
			int num2 = System.Convert.ToInt32(System.Console.ReadLine());

			double suma_cuadrados = 0;

			if(num1 > num2){
				for(int i = num1; i <= num2; i ++){
					double potencia = Math.Pow(i, 2);
					suma_cuadrados = suma_cuadrados + potencia;
				}
			}
				
			if(num2 < num1){
				for(int i = num2; i >= num1; i --){
					double potencia = Math.Pow(i, 2);
					suma_cuadrados = suma_cuadrados + potencia;
				}
			}

			int mayor = 0;

			if(num1 > num2){
				mayor = num1;
				for(int i = num2; i <= mayor; i ++){
					double potencia = Math.Pow(i, 2);
					suma_cuadrados = suma_cuadrados + potencia;
				}
			
			}
			if(num2 > num1){
				mayor = num2;
				for(int i = num1; i <= mayor; i ++){
					double potencia = Math.Pow(i, 2);
					suma_cuadrados = suma_cuadrados + potencia;
				}
			}	
			System.Console.WriteLine($"La suma de los cuadrado da como resultado: {suma_cuadrados}");
		}
	}
}
