/*
Jeison Salas Coloma - Ingenieria Civil Informatica - S1

Problema 2: Crea un programa que solicite al usuario dos números enteros, representando el inicio y el fin de un rango, y seguidamente calcule
la suma de todos los números de ese rango (incluyendo los extremos).

El programa debe mostrar el resultado de la suma por pantalla.
*/

using System;

namespace P2{
	public class Program{
		public static void Main(string[] args){
			bool flag = true;
			int suma = 0;

			while(flag){
				System.Console.Write("Ingrese el numero inicial del rango (numero entero): ");
				int numero_inicial = System.Convert.ToInt32(System.Console.ReadLine());
				System.Console.Write("Ingrese el numero final del rango (numero entero): ");
				int numero_final = System.Convert.ToInt32(System.Console.ReadLine());

				for(int i = numero_inicial; i <= numero_final; i ++){
					suma = suma + i;
				}
				System.Console.WriteLine($"El resultado de la suma en el rango de [{numero_inicial} a {numero_final}] es: {suma}");

				System.Console.Write("¿Seguir? (1) Si: ");
				int opcion = System.Convert.ToInt32(System.Console.ReadLine());

				if(opcion == 1){
					suma = 0;
					flag = true;
				}else{
					System.Console.WriteLine("Cerrando programa...");
					flag = false;
				}
			}
		}
	}
}
