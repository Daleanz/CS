// iTz_DiLAN

using System;
using Ejemplo6;

namespace Ejemplo6{
    public class Funcionario{
	private string nombreFuncionario;
	private string tituloFuncionario;
	private int añosDeServicio;

	public Funcionario(string nombreFuncionario, string tituloFuncionario, int añosDeServicio){
	    this.nombreFuncionario = nombreFuncionario;
	    this.tituloFuncionario = tituloFuncionario;
	    this.añosDeServicio = añosDeServicio;
	}

	public void setNombreFuncionario(string nombreFuncionario){
	    this.nombreFuncionario = nombreFuncionario;
	}

	public void setTituloFuncionario(string tituloFuncionario){
	    this.tituloFuncionario = tituloFuncionario;
	}

	public void setAñosDeServicioFuncionario(int añosDeServicio){
	    this.añosDeServicio = añosDeServicio;
	}

	public string getNombreFuncionario(){
	    return this.nombreFuncionario;
	}

	public string getTituloFuncionario(){
	    return this.tituloFuncionario;
	}

	public int getAñosDeServicioFuncionario(){
	    return this.añosDeServicio;
	}

	public void Reunion(){
	    System.Console.WriteLine($"{nombreFuncionario} esta en una reuinion.");
	}

	public void Colar(){
	    System.Console.WriteLine($"{nombreFuncionario} esta colando.");
	}

	public override string ToString(){
	    return $"Informacion Funcionario\nNombre: {nombreFuncionario}\n Titulo: {tituloFuncionario}\n Años de Servicio: {añosDeServicio}";
	}
    }
}
