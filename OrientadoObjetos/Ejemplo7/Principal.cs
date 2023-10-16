// iTz_DiLAN

using System;
using Ejemplo7;

namespace Ejemplo7{
    public class Principal{
	public static void Main(string[] args){
	    int n = -4;
	    NumerosEnteros numero = new NumerosEnteros(n);
	    NumerosComplejos numero_complejo = new NumerosComplejos(n, 5);
	   
	    numero_complejo.normaNumeroComplejo();
	    numero_complejo.sumaDeComplejos(1,3);
	    numero_complejo.restaDeComplejos(1,3);
	    numero_complejo.multiplicacionDeComplejos(1, 3);
	    numero_complejo.divisionDeComplejos(8, -2);


	}
    }
}
