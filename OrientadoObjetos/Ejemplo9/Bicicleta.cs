using System;
using Vehiculos;

namespace Vehiculos{
  public class Bicicleta : Vehiculo{
    private int velocidadesBici;

    public Bicicleta(string marcaVehiculo, string modeloVehiculo, int anioVehiculo, int velocidadesBici) : base(marcaVehiculo, modeloVehiculo, anioVehiculo){
      this.velocidadesBici = velocidadesBici;
    }
    
    public int VelocidadesBici{
      get{
        return this.velocidadesBici;
      }
      set{
        this.velocidadesBici = value;
      }
    }

    public override void Describir(){
      System.Console.WriteLine($"Informacion de la Bicicleta:\nModelo: {base.MarcaVehiculo}\nModelo: {base.ModeloVehiculo}\nAnio: {base.AnioVehiculo}\nVelocidades: {velocidadesBici}");
    }
  }
}
