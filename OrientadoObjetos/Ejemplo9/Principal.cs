using System;
using Vehiculos;

namespace Vehiculos{
  public class Principal{
    public static void Main(string[] args){
      Auto A1 = new Auto("BMW", "GCCES", 2019, 4);
      Moto M1 = new Moto("Kawasaki", "H2R", 2020, 300);
      A1.Describir();
      M1.Describir();
    }
  }
}
