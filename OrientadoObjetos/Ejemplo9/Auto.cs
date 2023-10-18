using System;
using Vehiculos;

namespace Vehiculos{
  public class Auto : Vehiculo{
    private int puertasAuto;

    public Auto(string marcaVehiculo, string modeloVehiculo, int anioVehiculo, int puertasAuto) : base(marcaVehiculo, modeloVehiculo, anioVehiculo){
      this.puertasAuto = puertasAuto;
    }

    public int PuertasAuto{
      get{
        return this.puertasAuto;
      }
      set{
        this.puertasAuto = value;
      }
    }

    public override void Describir(){
      System.Console.WriteLine($"Informacion del Auto:\nMarca: {base.MarcaVehiculo}\nModelo: {base.ModeloVehiculo}\nAnio: {base.AnioVehiculo}\nPuertas: {puertasAuto}");
    }
  }
}
