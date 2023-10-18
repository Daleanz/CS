using System;
using Vehiculos;

namespace Vehiculos{
  public class Moto : Vehiculo{
    private int caballosFuerza;

    public Moto(string marcaVehiculo, string modeloVehiculo, int anioVehiculo, int caballosFuerza) : base(marcaVehiculo, modeloVehiculo, anioVehiculo){
      this.caballosFuerza = caballosFuerza;
    }

    public int CaballosFuerza{
      get{
        return this.caballosFuerza;
      }
      set{
        this.caballosFuerza = value;
      }
    }

    public override void Describir(){
      System.Console.WriteLine($"Informacion de la Moto:\nMarca: {base.MarcaVehiculo}\nModelo: {base.ModeloVehiculo}\nAnio: {base.AnioVehiculo}\nCaballos: {caballosFuerza}");
    }
  }
}
