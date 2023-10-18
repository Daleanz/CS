using System;
using Biblioteca;

namespace Biblioteca{
  public class Usuario{
    private string nombreUsuario;
    private int numeroIdentificacion;
    private List<ElementoBiblioteca> elementosPrestados;

    public Usuario(string nombreUsuario, int numeroIdentificacion){
      this.nombreUsuario = nombreUsuario;
      this.numeroIdentificacion = numeroIdentificacion;
      this.elementosPrestados = new List<ElementoBiblioteca>();
    }

    public string NombreUsuario{
      get{
        return this.nombreUsuario;
      }
      set{
        this.nombreUsuario = value;
      }
    }

    public int NumeroIdentificacion{
      get{
        return this.numeroIdentificacion;
      }
      set{
        this.numeroIdentificacion = value;
      }
    }

    public List<ElementoBiblioteca> ElementosPrestados{
      get{
        return this.elementosPrestados;
      }
    }

    public void PrestarElemento(ElementoBiblioteca elemento){
      elementosPrestados.Add(elemento);
    }

    public void DevolverElemento(ElementoBiblioteca elemento){
      elementosPrestados.Remove(elemento);
    }

    public void MostrarInformacion(){
      System.Console.WriteLine($"Informacion del Usuario:\nNombre: {nombreUsuario}\nNum Identificacion: {numeroIdentificacion}\nElementos Prestados: ");

      foreach(var elemento in elementosPrestados){
        elemento.MostrarInformacion();
      }
    }
  }
}
