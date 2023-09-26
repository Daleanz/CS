using System;

namespace Problema1{
	public class Program{
		public static void Main(string[] args){
			System.Console.Write("Ingrese un numero:  ");
			int numero = System.Convert.ToInt32(System.Console.ReadLine());

			if(numero < 0){
				System.Console.WriteLine("El numero ingresado es negativo, se cambio a positivo.");
				numero = numero * (-1);
			}

			int cantidad_mayores = 0;
			int cantidad_menores = 0;

			for(int i = 1; i <= numero; i ++){
				if(i < 5){
					cantidad_menores = cantidad_menores + 1;
				}
				if(i > 5){
					cantidad_mayores = cantidad_mayores + 1;
				}
			}

			System.Console.WriteLine($"Cantidad de numeros mayores a 5 son. {cantidad_mayores}");

			System.Console.WriteLine($"Cantidad de numeros menores a 5 son. {cantidad_menores}");

		}
	}
}
