// iTz_DiLAN

using System;
using Ejemplo6;

namespace Ejemplo6{
    public class Academico : Funcionario{
	private string categoriaAcademica;
	private string labor;

	public Academico(string nombreFuncionario, string tituloFuncionario, int añosDeServicio, string categoriaAcademica, string labor) : base(nombreFuncionario, tituloFuncionario, añosDeServicio){
	    this.categoriaAcademica = categoriaAcademica;
	    this.labor = labor;
	}

	public void setCategoriaAcademica(string categoriaAcademica){
	    this.categoriaAcademica = categoriaAcademica;
	}

	public string getCategoriaAcademica(){
	    return this.categoriaAcademica;
	}

	public void Accion(){
	    System.Console.WriteLine($"{getNombreFuncionario()} se encuentra en {labor}");
	}
	public override string ToString(){
	    return $"Informacion Academico\nNombre: {getNombreFuncionario()}\nTitulo: {getTituloFuncionario()}\nAños de Servicio: {getAñosDeServicioFuncionario()}\nCategoria: {categoriaAcademica}\nLabor: {labor}";
	}
    }
}
