// iTz_DiLAN

using System;

namespace Ejemplo1{
    public class Perro{
	private string raza;
	private int edad;
	private double peso;
	private string nombre;

	public Perro(string nombre,string raza, int edad, double peso){
	    this.raza = raza;
	    this.edad = edad;
	    this.peso = peso;
	    this.nombre = nombre;
	}

	public void Comer(){
	    System.Console.WriteLine("Come");
	}
	public void Correr(){
	    System.Console.WriteLine("Corre");
	}
	public string getNombre(){
	    return this.nombre;
	}
	public string getRaza(){
	    return this.raza;
	}

	public int getEdad(){
	    return this.edad;
	}

	public double getPeso(){
	    return this.peso;
	}
	public void setNombre(string nombre){
	    this.nombre = nombre;
	}
	
	public void setRaza(string raza){
	    this.raza = raza;
	}

	public void setEdad(int edad){
	    this.edad = edad;
	}

	public void setPeso(float peso){
	    this.peso = peso;
	}
	
	// Metodo Override ToString
	public override string ToString(){
	    return $"Infomración de {nombre}: {raza}, {peso}, {edad}";
	}
	
    }
}
