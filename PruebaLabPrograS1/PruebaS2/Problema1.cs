/*
iTz_DiLAN

Problema 1: Escribe un programa que permita al usuario ingresar un número entero positivo y luego calcule la cantidad de números pares e impares
en el rango desde [ 1 ] hasta el número ingresado.

El programa debe mostrar por pantalla la cantidad de números pares e impares encontrados.
*/

using System;

namespace P1{
	public class Program{
		public static void Main(string[] args){
			bool flag = true;

			int cantidad_pares = 0, cantidad_impares = 0;

			while(flag){
				System.Console.Write("Ingrese un número entero positivo: ");
				int numero_ingresado = System.Convert.ToInt32(System.Console.ReadLine());

				if(numero_ingresado < 0){
					System.Console.WriteLine("El numero es negativo, se cambiara a positivo.");
					numero_ingresado = numero_ingresado * (-1);
				}
				if(numero_ingresado > 0){
					for(int i = 1; i <= numero_ingresado; i ++){
						if(i % 2 == 0){
							cantidad_pares = cantidad_pares + 1;
						}else{
							cantidad_impares = cantidad_impares + 1;
						}
					}
				}
				System.Console.WriteLine($"Cantidad de números pares: {cantidad_pares}");
				System.Console.WriteLine($"Cantidad de números impares: {cantidad_impares}");

				System.Console.Write("¿Seguir? (1) Si: ");
				int opcion = System.Convert.ToInt32(System.Console.ReadLine());

				if(opcion == 1){
					cantidad_pares = 0;
					cantidad_impares = 0;
					flag = true;
				}else{
					System.Console.WriteLine("Cerrando programa...");
					flag = false;
				}
			}
		}
	}
}
