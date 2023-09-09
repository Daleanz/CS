using System;

namespace Proyect1;

public class Proyect{
	public static void Main(string[] args){
		// Mostrar numeros pares entre el [1 - 100]

		bool flag = true;
		int contador = 1;

		while(flag){
			if(contador % 2 == 0){
				System.Console.WriteLine(contador);
			}
			contador = contador + 1;

			if(contador > 100){
				flag = false;
			}
		}
	}
}
