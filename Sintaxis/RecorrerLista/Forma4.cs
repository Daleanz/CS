// iTz_DiLAN

using System;

namespace Prueba{
	public class Program{
		public static void Main(string[] args){
			List<dynamic> Lista = new List<dynamic>();

			Lista.Add("Messi");
			Lista.Add("Ronaldo");

			Lista.Add(7);
			Lista.Add(5);

			Lista.Add(1.34);
			Lista.Add(1.20);

			foreach(dynamic varAux in Lista){
				System.Console.WriteLine(varAux);
			}
		}
	}
}
