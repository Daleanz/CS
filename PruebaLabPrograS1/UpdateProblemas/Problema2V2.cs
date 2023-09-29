// iTz_DiLAN

using System;

namespace Problema2V2{
	public class Program{
		public static void Main(string[] args){
			bool flag = true;
			while(flag){
				System.Console.Write("Ingrese el primer numero entero:  ");
				int num1 = System.Convert.ToInt32(System.Console.ReadLine());

				System.Console.Write("Ingrese el segundo numero entero:  ");
				int num2 = System.Convert.ToInt32(System.Console.ReadLine());

				double suma_cuadrados = 0;

				int largo = 0;
				if(num1 > num2){
					largo = num1 - num2 + 1;
				}else{
					if(num2 > num1){
						largo = num2 - num1 + 1;
					}else{
						System.Console.WriteLine("Error, los numeros son iguales.");
					}
				}

				double[] suma = new double[largo];

				int indice = 0;
				if(num1 > num2){
					for(int i = num1; i <= num2; i ++){
						double potencia = Math.Pow(i, 2);
						System.Console.WriteLine($"{i}^2 = {potencia}");
						suma_cuadrados = suma_cuadrados + potencia;
						suma[indice] = potencia;
						indice ++;
					}
				}
					
				if(num2 < num1){
					for(int i = num2; i >= num1; i --){
						double potencia = Math.Pow(i, 2);
						System.Console.WriteLine($"{i}^2 = {potencia}");
						suma_cuadrados = suma_cuadrados + potencia;
						suma[indice] = potencia;
						indice ++;
					}
				}

				int mayor = 0;

				if(num1 > num2){
					mayor = num1;
					for(int i = num2; i <= mayor; i ++){
						double potencia = Math.Pow(i, 2);
						System.Console.WriteLine($"{i}^2 = {potencia}");
						suma_cuadrados = suma_cuadrados + potencia;
						suma[indice] = potencia;
						indice ++;
					}
				
				}
				if(num2 > num1){
					mayor = num2;
					for(int i = num1; i <= mayor; i ++){
						double potencia = Math.Pow(i, 2);
						System.Console.WriteLine($"{i}^2 = {potencia}");
						suma_cuadrados = suma_cuadrados + potencia;
						suma[indice] = potencia;
						indice ++;
					}
				}
				
				int contador = 0;
				foreach(int i in suma){
					if(contador == suma.Length - 1){
						System.Console.Write(i);
					}				
				}

				System.Console.Write(" = " + suma_cuadrados + "\n");

				System.Console.WriteLine($"La suma de los cuadrado da como resultado: {suma_cuadrados}");

				System.Console.Write("¿Continuar con otros numeros? (1) Si:  ");
				int opcion = System.Convert.ToInt32(System.Console.ReadLine());

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
