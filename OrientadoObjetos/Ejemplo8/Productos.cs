using System;

namespace TiendaOnline{
  public class Productos{
    private int codigoProducto;
    private string? nombreProducto;
    private double precioProducto;
    private int stockProducto;

    public Productos(int codigoProducto, string nombreProducto, double precioProducto, int stockProducto){
      this.codigoProducto = codigoProducto;
      this.nombreProducto = nombreProducto;
      this.precioProducto = precioProducto;
      this.stockProducto = stockProducto;
    }

    public int CodigoProducto{
      get{
        return this.codigoProducto;
      }
      set{
        this.codigoProducto = value;
      }
    }

    public string NombreProducto{
      get{
        if(this.nombreProducto == null){
          return "No se retornara nada, ya que la variable es NULL";
        }
        return this.nombreProducto;
      }
      set{
        this.nombreProducto = value;
      }
    } 

    public double PrecioProducto{
      get{
        return this.precioProducto;
      }
      set{
        this.precioProducto = value;
      }
    } 

    public int StockProducto{
      get{
        return this.stockProducto;
      }
      set{
        this.stockProducto = value;
      }
    } 

    public void ComprarProducto(int cantidad){
      if(cantidad <= stockProducto){
        System.Console.WriteLine($"Se ha realizado una compra de {cantidad} {nombreProducto} por ${cantidad * precioProducto}");
      }else{
        System.Console.WriteLine($"No hay suficiente stock, solamente quedan {stockProducto}");
      }
    }
    public override  string ToString(){
      return $"Informacion del Producto:\nCodigo: {codigoProducto}\nNombre: {nombreProducto}\nPrecio:{precioProducto}\nStock: {stockProducto}";
    }
  }
}
