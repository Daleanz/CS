// iTz_DiLAN

using System;

namespace Ejemplo7{
    public class NumerosComplejos : NumerosEnteros{
	private int parteImaginaria;	

	public NumerosComplejos(int valor, int parteImaginaria) : base(valor){
	    this.parteImaginaria = parteImaginaria;
	}

	public void setParteEntera(int parteEntera){
	    setValor(parteEntera);
	}

	public void setParteImaginaria(int parteImaginaria){
	    this.parteImaginaria = parteImaginaria;
	}
	
	public int getParteEntera(){
	    return getValor();
	}

	public int getParteImaginaria(){
	    return this.parteImaginaria;
	}

	public void normaNumeroComplejo(){
	    double norma = Math.Sqrt(Math.Pow(getValor(), 2) + Math.Pow(parteImaginaria, 2));

	    System.Console.WriteLine($"La norma del numero complejo: [{getValor()} {parteImaginaria}] es: {norma:F3}i");
	}

	public void sumaDeComplejos(int valor_entero, int parte_imaginaria){
	    int sumaParteEntera = getValor() + valor_entero;
	    int sumaParteImaginaria = parteImaginaria + parte_imaginaria;

	    System.Console.WriteLine($"La suma entre [{getValor()} {parteImaginaria}i] + [{valor_entero} {parte_imaginaria}i] es: [{sumaParteEntera} {sumaParteImaginaria}i]");
	}

	public void restaDeComplejos(int valor_entero, int parte_imaginaria){
	    int restaParteEntera = getValor() - valor_entero;
	    int restaParteImaginaria = parteImaginaria - parte_imaginaria;

	    System.Console.WriteLine($"La resta entre [{getValor()} {parteImaginaria}i] - [{valor_entero} {parte_imaginaria}i] es: [{restaParteEntera} {restaParteImaginaria}i]");
	}

	public void multiplicacionDeComplejos(int valor_entero, int parte_imaginaria){
	    int[] orden1 = new int[2];
	    orden1[0] = getValor() * valor_entero;
	    orden1[1] = getValor() * parte_imaginaria;

	    int[] orden2 = new int[2];
	    orden2[0] = parteImaginaria * valor_entero;
	    orden2[1] = parteImaginaria * parte_imaginaria;
	    
	    // i^2 = -1
	    int[] multiplicacion = {orden1[0] + (orden2[1] * (-1)), orden1[1] + orden2[0]};

	    System.Console.WriteLine($"La multiplicacion entre [{getValor()} {parteImaginaria}i] x [{valor_entero} {parte_imaginaria}i] es: [{multiplicacion[0]} {multiplicacion[1]}i]");
	}
	
	public void divisionDeComplejos(int valor_entero, int parte_imaginaria){
	    int[] orden1 = new int[2];
	    orden1[0] = getValor() * valor_entero;
	    orden1[1] = getValor() * parte_imaginaria * (-1);

	    int[] orden2 = new int[2];
	    orden2[0] = parteImaginaria * valor_entero;
	    orden2[1] = parteImaginaria * parte_imaginaria * (-1);
	    
	    // i^2 = -1
	    int[] multiplicacion = {orden1[0] + (orden2[1] * (-1)), orden1[1] + orden2[0]};

	    double denominador = Math.Pow(valor_entero, 2) + Math.Pow(parte_imaginaria, 2);

	    if(denominador != 0){
		double[] division = new double[2];
		division[0] = multiplicacion[0] / denominador;
		division[1] = multiplicacion[1] / denominador;

		System.Console.WriteLine($"La division entre [{getValor()} {parteImaginaria}i] / [{valor_entero} {parte_imaginaria}i] es: [{division[0]:F3} {division[1]:F3}i]");
	    }else{
		System.Console.WriteLine("No se puede realizar la division, ya que el denominador da [ 0 ]");
	    }
	    
	}
	public override string ToString(){
	    return $"Informacion del numero:[{getValor()} {parteImaginaria}i]\n\nParte Entera: {getValor()}\nParte Imaginaria: {parteImaginaria}i";
	}
    }
}
