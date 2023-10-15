// iTz_DiLAN

using System;
using Ejemplo6;

namespace Ejemplo6{
    public class Principal{
	public static void Main(string[] args){
	    Funcionario F1 = new Funcionario("Renato", "Ingeniero en Geomensura", 1);
	    Funcionario F2 = new Funcionario("Juan", "Ingeniero Civil", 2);

	    System.Console.WriteLine(F1.ToString());
	    F1.Reunion();
	    
	    System.Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

	    System.Console.WriteLine(F2.ToString());
	    F2.Colar();

	    System.Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

	    Academico A1 = new Academico("Hugo", "Profesor de Matematica y Computacion", 30, "Auxiliar", "Administracion");
	    Academico A2 = new Academico("Phillip", "Ingenierco Civil Informatico", 4, "Instructor", "Docencia");
	    
	    System.Console.WriteLine(A1.ToString());
	    A1.Accion();

	    System.Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

	    System.Console.WriteLine(A2.ToString());
	    A2.Accion();
	}
    }
}
