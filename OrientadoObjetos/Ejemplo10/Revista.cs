using System;
using Biblioteca;

namespace Biblioteca{
  public class Revista : ElementoBiblioteca{
    private string editorRevista;

    public Revista(string tituloElemento, int anioPublicacion, string editorRevista) : base(tituloElemento, anioPublicacion){
      this.editorRevista = editorRevista;
    }

    public string EditorRevista{
      get{
        return this.editorRevista;
      }
      set{
        this.editorRevista = value;
      }
    }

    public override void MostrarInformacion(){
      System.Console.WriteLine($"Informacion de la Revista:\nTitulo: {base.TituloElemento}\nAnio Publicacion: {base.AnioPublicacion}\nEditor: {editorRevista}");
    }
  }
}
