using System;

namespace Proyect1;

public class Proyect{
	public static void Main(string[] args){
		System.Console.Write("Ingrese el numero para ver su tabla de multiplicar: ");
		int numero = System.Convert.ToInt32(System.Console.ReadLine());

		System.Console.Write("Ingrese el rango de la tabla de multiplicar: ");
		int rango = System.Convert.ToInt32(System.Console.ReadLine());

		System.Console.WriteLine($"La tabla de multiplicar de {numero} es: ");

		bool flag = true;
		int contador = 1;
		
		while(flag){
			System.Console.WriteLine($"{numero} x {contador} = {numero * contador}");
			
			if(contador < rango){
				contador ++;
			}else{
				flag = false;
			}
		}

	}
}
