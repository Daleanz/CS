/*
Jeison Salas Coloma - Ingeniercia Civil Informatica - S1
15.306.099-1

Problema 3: Implementa un programa que permita al usuario ingresar un número entero positivo y luego calcule la suma de todos los números primos en el
rango desde 2 hasta el número ingresado.

El programa debe mostrar por pantalla la suma de los números primos.
*/

using System;

namespace P3{
	public class Program{
		public static void Main(string[] args){
			bool flag = true;
			while(flag){
				System.Console.Write("Ingrese el numero limite final del rango: ");
				int numero_ingresado = System.Convert.ToInt32(System.Console.ReadLine());

				if(numero_ingresado < 0){
					System.Console.WriteLine("El numero ingresado es negativo, se transformo a positivo (+).");
					numero_ingresado = numero_ingresado * (-1);
				}

				if(numero_ingresado < 2){
					System.Console.WriteLine("El numero tiene que ser mayor o igual que 2.");
				}

				int suma_primos = SumarPrimos(numero_ingresado);

				System.Console.WriteLine($"La suma de los números primos en el rango de [ 2 a {numero_ingresado}] es: {suma_primos}");

				System.Console.Write("¿Seguir? (1) Si:  ");
				int opcion = System.Convert.ToInt32(System.Console.ReadLine());

				if(opcion == 1){
					suma_primos = 0;
					flag = true;
				}else{
					System.Console.WriteLine("Cerrando programa...");
					flag = false;
				}

			}
		}

		static bool VerificarPrimo(int numero){
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

		static int SumarPrimos(int numero_limite){
			int suma = 0;

			for(int i = 2; i <= numero_limite; i ++){
				if(VerificarPrimo(i)){
					suma = suma + i;
				}
			}
			return suma;
		}
	}
}
