using System;
using Biblioteca;

namespace Biblioteca{
  public class Principal{
    public static void Main(string[] args){
      Libro L1 = new Libro("Que es lo que", 2000,"El Mati", 100);
      Revista R1 = new Revista("XFJSNj", 2008, "Joaquin");
      Empleado E1 = new Empleado("Juaquina F",1022, "Bibliotecaria");
      Usuario U1 = new Usuario("Stefi", 2001);

      L1.MostrarInformacion();
      U1.MostrarInformacion();

      U1.PrestarElemento(L1);
      U1.PrestarElemento(R1);
      U1.MostrarInformacion();
    }
  }
}
