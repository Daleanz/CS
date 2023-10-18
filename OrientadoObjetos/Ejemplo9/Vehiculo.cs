using System;

namespace Vehiculos{
 public abstract class Vehiculo{
    private string marcaVehiculo;
    private string modeloVehiculo;
    private int anioVehiculo;

    public Vehiculo(string marcaVehiculo, string modeloVehiculo, int anioVehiculo){
      this.marcaVehiculo = marcaVehiculo;
      this.modeloVehiculo = modeloVehiculo;
      this.anioVehiculo = anioVehiculo;
    }

    public string MarcaVehiculo{
      get{
        return this.marcaVehiculo;
      }
      set{
        this.marcaVehiculo = value;
      }
    }

    public string ModeloVehiculo{
      get{
        return this.modeloVehiculo;
      }
      set{
        this.modeloVehiculo = value;
      }
    }

    public int AnioVehiculo{
      get{
        if(this.anioVehiculo < 0){
          return 0;
        }else{
          return this.anioVehiculo;
        }
      }
      set{
        this.anioVehiculo = value;
      }
    } 
  
    public abstract void Describir();
  }
}
