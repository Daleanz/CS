using System;

namespace Biblioteca{
  public class Empleado{
    private string nombreEmpleado;
    private int numeroIdentificacion;
    private string cargoEmpleado;

    public Empleado(string nombreEmpleado, int numeroIdentificacion, string cargoEmpleado){
      this.nombreEmpleado = nombreEmpleado;
      this.numeroIdentificacion = numeroIdentificacion;
      this.cargoEmpleado = cargoEmpleado;
    }

    public string NombreEmpleado{
      get{
        return this.nombreEmpleado;
      }
      set{
        this.nombreEmpleado = value;
      }
    }

    public int NumeroIdentificacion{
      get{
        return this.numeroIdentificacion;
      }
      set{
        this.numeroIdentificacion = value ;
      }
    }

    public string CargoEmpleado{
      get{
        return this.cargoEmpleado;
      }
      set{
        this.cargoEmpleado = value;
      }
    }

    public void MostrarInformacion(){
      System.Console.WriteLine($"Informacion del Empleado:\nNombre: {nombreEmpleado}\nNum Identificacion: {numeroIdentificacion}\nCargo: {cargoEmpleado}");
    }
  }
}
