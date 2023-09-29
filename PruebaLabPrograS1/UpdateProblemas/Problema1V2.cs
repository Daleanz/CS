// iTz_DiLAN

using System;

namespace Problema1V2{
	public class Program{
		public static void Main(string[] args){
			bool flag = true;
			while(flag){
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

				System.Console.Write("¿Ver de mejor forma? (1) Si: ");
				int opcion = System.Convert.ToInt32(System.Console.ReadLine());

				int contador1 = 1;
				int contador2 = 1;
				if(opcion == 1){
					for(int i = 1; i <= numero; i ++){
						if(i < 5){
							System.Console.WriteLine($"{i} < 5 = {true} {contador1 ++}");
						}
						if(i > 5){
							System.Console.WriteLine($"{i} > 5 = {true} {contador2 ++}");
						}
					}
				}
				opcion = 0;
				System.Console.Write("¿Continuar con otro numero? (1) Si: ");
				opcion = System.Convert.ToInt32(System.Console.ReadLine());

				if(opcion == 1){
					flag = true;
				}else{
					System.Console.WriteLine("Cerrando programa...");
					flag = false;
				}

			}
			

		}
	}
}
