// iTz_DiLAN

using System;

namespace Ejemplo3{
    public class NumerosNaturales{
	private int valor;

	public NumerosNaturales(int valor){
	    if(valor < 0){
		valor = valor * (-1);
		System.Console.WriteLine("El numero es negativo, se cambio a positivo.");
	    }
	    this.valor = valor;
	}

	public NumerosNaturales(){
	    this.valor = 0;
	}

	public void Suma(int numero){
	    valor = valor + numero;
	    if(valor < 0){
		valor = valor * (-1);
	    }
	    System.Console.WriteLine($"El valor al sumarle {numero} queda: {valor}");
	} 
	
	public void Resta(int numero){
	    valor = valor - numero;
	    if(valor < 0){
		valor = valor * (-1);
	    }
	    System.Console.WriteLine($"El valor al restarle {numero} queda: {valor}");
	}
    
	public void Multiplicacion(int numero){
	    valor = valor * numero;
	    if(valor < 0){
		valor = valor * (-1);
	    }
	    System.Console.WriteLine($"El valor al multiplicarlo {numero} queda: {valor}");
	}

	public void Division(int numero){
	    if(numero == 0){
		System.Console.WriteLine("No se puede dividir por 0.");
	    }
	    valor = valor / numero;
	    System.Console.WriteLine($"El valor al dividirlo por {numero} queda: {valor}");
	}

	public void EsPar(){
	    if(valor % 2 == 0){
		System.Console.WriteLine($"{valor} es par.");
	    }else{
		System.Console.WriteLine($"{valor} es impar.");
	    }
	}

	public void EsPrimo(){
	    bool flag = false;
	    if(valor < 2){
		flag = false;
	    }

	    for(int i = 2; i <= Math.Sqrt(valor); i ++){
		if(valor % i == 0){
		    flag = false;
		}
	    }

	    if(flag == false){
		System.Console.WriteLine($"{valor} no es Primo.");
	    }else{
		System.Console.WriteLine($"{valor} es Primo.");
	    }
	}
    }
    
}

