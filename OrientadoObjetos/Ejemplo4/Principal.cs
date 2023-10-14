using System;
using Ejemplo4;

namespace Ejemplo4{
    public class Principal{
	public static void Main(string[] args){
	    int[] valores = {1,100,200,20,30};
	    ModelarLista l1 = new ModelarLista(4);
	    ModelarLista l2 = new ModelarLista(valores);
	    l1.MostrarLista();

	    l1.AgregarElemento(10);
	    l1.MostrarLista();

	    l2.MostrarLista();
	}
    }
}
