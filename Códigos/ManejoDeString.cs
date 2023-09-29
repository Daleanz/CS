// iTz_DiLAN

using System;

namespace Ejercicio2{
	public class Program{
		public static void Main(string[] args){
			bool flag = true;

			while(flag){
				System.Console.WriteLine("Programa que guardara los caracteres de una cadena en un vector.");
				System.Console.Write("Ingrese una cadena: ");

				string cadena = System.Console.ReadLine();
				if(cadena.Length == 0){
					bool flag1 = true;
					while(flag1){
						System.Console.WriteLine("Error, has ingresado una cadena nula.");
						System.Console.WriteLine(" ");
						System.Console.Write("Ingresa una cadena no nula: ");
						cadena = System.Console.ReadLine();
						if(cadena.Length != 0){
							flag1 = false;
						}
					}
				}
				System.Console.WriteLine(" ");

				char[] caracteres = new char[cadena.Length];
				char[] inversa = new char[cadena.Length];

				for(int i = 0; i < cadena.Length; i ++){
					caracteres[i] = cadena[i];
				}

				int indexAux = 0;
				for(int i = cadena.Length - 1; i >= 0; i --){
					inversa[indexAux] = cadena[i];
					indexAux = indexAux + 1;
				}

				System.Console.WriteLine("Cadena Normal: " + cadena);
				System.Console.WriteLine("Cadena Normal en Mayusculas: " + cadena.ToUpper());
				System.Console.WriteLine("Cadena Normal en Minusculas: " + cadena.ToLower());
				System.Console.Write("[ ");
				foreach(char c in caracteres){
					System.Console.Write(c + " ");
				}
				System.Console.Write("]");

				System.Console.WriteLine(" ");

				for(int i = 0; i < cadena.Length; i ++){
					System.Console.WriteLine($"Vector Pos {i} = {caracteres[i]}");
				}
				System.Console.WriteLine(" ");

				string cadena_inversa = new string(inversa);
				System.Console.WriteLine("Cadena Inversa: " + cadena_inversa);
				System.Console.WriteLine("Cadena Inversa en Mayusculas: " + cadena_inversa.ToUpper());
				System.Console.WriteLine("Cadena Inversa en Minusculas: " + cadena_inversa.ToLower());
				System.Console.Write("[ ");
				foreach(char c in inversa){
					System.Console.Write(c + " ");
				}
				System.Console.Write("]");

				System.Console.WriteLine(" ");
				
				for(int i = 0; i < cadena_inversa.Length; i ++){
					System.Console.WriteLine($"VectorInversa Pos {i} = {cadena_inversa[i]}");
				}

				System.Console.WriteLine(" ");
				System.Console.WriteLine($"El largo de la cadena: {cadena.Length}");
				System.Console.WriteLine(" ");
				System.Console.Write("¿Deseas continuar? (1) Si: ");
				int opcion = System.Convert.ToInt32(System.Console.ReadLine());

				if(opcion == 1){
					flag = true;
				}else{
					System.Console.WriteLine("Cerrando Programa...");
					flag = false;
				}

			}
			
		}
	}
}
