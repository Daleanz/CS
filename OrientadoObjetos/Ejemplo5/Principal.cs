// iTz_DiLAN

using System;
using Ejemplo5;

namespace Ejemplo5{
    public class Principal{
	public static void Main(string[] args){
	    Vectores3D vectorA = new Vectores3D(3.0, 5.0, 2.0);

	    vectorA.NormaVector();

	    vectorA.ProductoPunto(3.0,4.0,5.0);
	    vectorA.ProductoCruz(3.0,4.0,5.0);
	}
    }
}
