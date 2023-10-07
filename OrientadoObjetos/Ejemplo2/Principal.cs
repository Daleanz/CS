// iTz_DiLAN

using System;
using Ejemplo2;

namespace Ejemplo2{
    public class Principal{
	public static void Main(string[] args){
	    EntidadBancaria Cliente1 = new EntidadBancaria("Jeison Salas", 19029384, 350000);
	    EntidadBancaria Cliente2 = new EntidadBancaria(); 

	    System.Console.WriteLine(Cliente1.ToString());

	    Cliente2.setNombreCuenta("Franciscas Hernandez");
	    Cliente2.setSaldoCuenta(450000);
	    System.Console.WriteLine(Cliente2.ToString());
	    
	    Cliente2.AgregarSaldo(200000);
	    System.Console.WriteLine(Cliente2.ToString());

	    Cliente2.Transferencia(4505432, 345000);
	    
	    System.Console.WriteLine(Cliente2.ToString());


	}
    }
}
