using System;

namespace Bodega{
    class BodegaSistema{
        private Producto[] productos;
        private int capacidadBodega;
        private int contador;
        
        public BodegaSistema(int capacidadBodega){
            this.capacidadBodega = capacidadBodega;
            productos = new Producto[capacidadBodega];
            contador = 0;
        }

        public void agregarProducto(Producto producto){
            if(contador < capacidadBodega){
                productos[contador] = producto;
                contador ++;
            }else{
                System.Console.WriteLine("La bodega está llena, no se puede agregar más productos.");
            }
        }

        public void quitarProducto(Producto producto){
            for(int i = 0; i < contador; i ++){
                if(productos[i].NombreProducto == producto.NombreProducto){
                    productos[i].CantidadProducto = productos[i].CantidadProducto - producto.CantidadProducto;

                    if(productos[i].CantidadProducto <= 0){
                        for(int j = i; j < contador - 1; j ++){
                            productos[j] = productos[j + 1];
                        }
                        contador --;
                    }
                return;
                }
            }
            System.Console.WriteLine($"No se encontró el producto {producto.NombreProducto} en la bodega.");
        }

        public void mostrarInventario(){
            System.Console.WriteLine("Inventario de la Bodega:");

            foreach(var producto in productos){
                if(producto != null){
                    System.Console.WriteLine(producto);
                }
            }
        }
    }
}
