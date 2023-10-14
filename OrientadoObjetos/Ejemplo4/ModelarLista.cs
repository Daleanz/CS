using System;

namespace Ejemplo4{
    public class ModelarLista{
	private List<int> lista = new List<int>();

	public ModelarLista(){
	    System.Console.WriteLine("Se ha creado una lista vacia.");
	    lista.Clear();
	}
	public ModelarLista(int elemento){
	    System.Console.WriteLine($"Se ha creado una lista con el elemento {elemento}");
	    this.lista.Add(elemento);
	}
	public ModelarLista(int[] elementos){
	    int cantidadElementos = elementos.Length;
	    System.Console.WriteLine("Se ha creado una lista con varios elementos.");

	    for(int i = 0; i < cantidadElementos; i ++){
		lista.Add(i);
	    }
	}

	public void MostrarLista(){
	    if(lista.Count == 0){
		System.Console.WriteLine("La lista esta vacia.");
	    }else{
		System.Console.WriteLine(String.Join(" - ", this.lista));
	    }
	}
	
	public void AgregarElemento(int elemento){
	    lista.Add(elemento);
	}

	public void EliminarElemento(int elemento){
	    foreach(int indice in lista){
		if(indice == elemento){
		    lista.Remove(indice);
		    System.Console.WriteLine($"El elemento {elemento} ha sido eliminado de la lista.");
		    return;
		}
	    }
	    System.Console.WriteLine($"El elemento {elemento} no se encontro en la Lista.");
	}

	public int[] ObtenerElementosArray(){
	    int cantidadElementosLista = lista.Count();
	    int[] elementos = new int[cantidadElementosLista];

	    for(int i = 0; i < cantidadElementosLista; i ++){
		elementos[i] = lista[i];
	    }
	    return elementos;
	}

	public List<int> ObtenerElementosLista(){
	    return lista;	
	}
	
    }
}
