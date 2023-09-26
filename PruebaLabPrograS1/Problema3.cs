/*

Jeison Salas Coloma - Ingenieria Civil Informatica - S1
15.306.099-1

*/
using System;

namespace Problema3{
	public class Program{
		public static void Main(string[] args){
			System.Console.Write("Ingrese un numero entero positivo:  ");
			int numero_ingresado = System.Convert.ToInt32(System.Console.ReadLine());

			if(numero_ingresado < 0){
				numero_ingresado = numero_ingresado * (-1);
			}

			int rango = calcularFactorial(numero_ingresado);

			System.Console.WriteLine($"factorial de {numero_ingresado} es = {calcularFactorial(numero_ingresado)}");

			int cantidad_primos = 0;

			for(int i = 2; i <= rango; i ++){
				if(verificarPrimo(i)){
					cantidad_primos = cantidad_primos + 1;
				}
			}

			System.Console.WriteLine($"La cantidad de numeros primos en el rango de [ 2 a {rango} ] son: {cantidad_primos}");
		}

		static int calcularFactorial(int numero){
			int factorial = 1;

			for(int i = 1; i <= numero; i ++){
				factorial = factorial * i;
			}

			return factorial;
		}

		static bool verificarPrimo(int numero){
			if(numero < 2){
				return false;
			}

			for(int i = 2; i <= Math.Sqrt(numero); i ++){
				if(numero % i == 0){
					return false;
				}
			}
			return true;
		}


	}
}
