using System;

namespace Biblioteca{
  public abstract class ElementoBiblioteca{
    private string tituloElemento;
    private int anioPublicacion;

    public ElementoBiblioteca(string tituloElemento, int anioPublicacion){
      this.tituloElemento = tituloElemento;
      this.anioPublicacion = anioPublicacion;
    }
    
    public string TituloElemento{
      get{
        return this.tituloElemento;
      }
      set{
        this.tituloElemento = value;
      }
    }

    public int AnioPublicacion{
      get{
        return this.anioPublicacion;
      }
      set{
        this.anioPublicacion = value;
      }
    }

    public abstract void MostrarInformacion();

  }
} 
