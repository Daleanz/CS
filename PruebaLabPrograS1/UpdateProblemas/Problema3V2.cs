// iTz_DiLAN

using System;

namespace Problema3V2{
	public class Program{
		public static void Main(string[] args){
			bool flag = true;
			while(flag){
				System.Console.Write("Ingrese un numero entero positivo:  ");
				int numero_ingresado = System.Convert.ToInt32(System.Console.ReadLine());

				if(numero_ingresado < 0){
					System.Console.ForegroundColor = System.ConsoleColor.Green;
					System.Console.WriteLine("El numero ingresado es negativo, se cambio a positivo.");
					System.Console.ResetColor();
					numero_ingresado = numero_ingresado * (-1);
				}

				int rango = calcularFactorial(numero_ingresado);

				System.Console.WriteLine($"Factorial de {numero_ingresado} es = {calcularFactorial(numero_ingresado)}");

				int cantidad_primos = 0;

				for(int i = 2; i <= rango; i ++){
					if(verificarPrimo(i)){
						cantidad_primos = cantidad_primos + 1;
					}
				}
				System.Console.ForegroundColor = System.ConsoleColor.Blue;
				System.Console.WriteLine($"La cantidad de numeros primos en el rango de [ 2 a {rango} ] son: {cantidad_primos}");
				System.Console.ResetColor();

				System.Console.Write("¿Continuar? (1) Si: ");
				int opcion = System.Convert.ToInt32(System.Console.ReadLine());

				if(opcion == 1){
					flag = true;
				}else{
					System.Console.ForegroundColor = System.ConsoleColor.Red;
					System.Console.WriteLine("Cerrando programa...");
					System.Console.ResetColor();
					flag = false;
				}
			}
				
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
