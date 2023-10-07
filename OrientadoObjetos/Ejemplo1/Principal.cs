// iTz_DiLAn

using System;
using Ejemplo1;

namespace Ejemplo1{
    public class Principal{
	public static void Main(string[] args){
	    Perro Aroha = new Perro("Aroha ","Pitbull", 6, 20);
	    Perro Betzi = new Perro("Betzi ","Firulai", 10, 25.4);

	    System.Console.WriteLine(Aroha.getNombre() + Aroha.getEdad() + " años");
	    Aroha.Comer();
	    Aroha.Correr();
	    System.Console.WriteLine(Aroha.getPeso() + " es su peso");

	    System.Console.WriteLine(Betzi.getNombre() + Betzi.getEdad() + " años");
	    Betzi.Comer();
	    Betzi.Correr();
	    System.Console.WriteLine(Betzi.getPeso() + " es su peso");

	    System.Console.WriteLine(Aroha.ToString());
	    System.Console.WriteLine(Betzi.ToString());
	}
    }
}
