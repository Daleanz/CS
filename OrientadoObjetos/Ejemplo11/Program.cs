using System;
using Bodega;

namespace Bodega{
    public class Program{
        public static void Main(string[] args){
            BodegaSistema bodega = new BodegaSistema(5);

            Producto p1 = new Producto("Camiseta", 20);
            Producto p2 = new Producto("Zapatillas", 20);
            Producto p3 = new Producto("Pantalones", 20);

            bodega = bodega + p1;
            bodega = bodega + p2;
            bodega = bodega + p3;

            System.Console.WriteLine("Inventario despues de agregar productos:\n");
            bodega.mostrarInventario();

            Producto p4 = new Producto("Camiseta", 5);

            bodega = bodega - p4;

            System.Console.WriteLine("Inventario despues de quitar productos:\n");
            bodega.mostrarInventario();
        }
    }
}
