// iTz_DiLAN

using System;

namespace Ejercicio1{
	public class Program{
		public static void Main(string[] args){
			bool flag = true;
			while(flag){
				System.Console.WriteLine("Programa, que muestra el largo de la cadena");
				System.Console.Write("Ingrese una cadena: ");
				string cadena = System.Console.ReadLine();
				System.Console.WriteLine($"El largo de la cadena es: {cadena.Length}");

				System.Console.Write("¿Desea continuar con otra cadena? (1) Si: ");
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
