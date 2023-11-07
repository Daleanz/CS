using System;

namespace Bodega{
    class Producto{
        private string nombreProducto;
        private int cantidadProducto;

        public Producto(string nombreProducto, int cantidadProducto){
            this.nombreProducto = nombreProducto;
            this.cantidadProducto = cantidadProducto;
        }

        public string NombreProducto{
            get{
                return nombreProducto;
            }
            set{
                this.nombreProducto = value;
            }
        }

        public int CantidadProducto{
            get{
                return cantidadProducto;
            }
            set{
                this.cantidadProducto = value;
            }
        }

        public override string ToString(){
            return $"Informacion Producto:\n Nombre: {NombreProducto}\n Cantidad: {CantidadProducto}";
        }

        public static BodegaSistema operator +(BodegaSistema bodega, Producto producto){
            bodega.agregarProducto(producto);
            return bodega;
        }

        public static BodegaSistema operator -(BodegaSistema bodega, Producto producto){
            bodega.quitarProducto(producto);
            return bodega;
        }
    }
}
