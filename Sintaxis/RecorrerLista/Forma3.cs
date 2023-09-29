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

			int aux = 0;

			for(aux = 0; aux < Lista.Count(); aux ++){
				System.Console.WriteLine(Lista[aux]);
			}
		}
	}
}
