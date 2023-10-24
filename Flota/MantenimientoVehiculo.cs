using System;
using FlotaVehiculos;

namespace FlotaVehiculos{
    class MantenimientoVehiculo{
        private DateTime fecha;
        private string descripcion;
        private double costo;

        public MantenimientoVehiculo(DateTime fecha, string descripcion, double costo){
            this.fecha = fecha;
            this.descripcion = descripcion;
            this.costo = costo;
        }

        public DateTime Fecha{
            get{return fecha;}
            set{this.fecha = value;}
        }

        public string Descripcion{
            get{return descripcion;}
            set{this.descripcion = value;}
        }

        public double Costo{
            get{return costo;}
            set{this.costo = value;}
        }

        public void mostrarInformacion(){
            System.Console.WriteLine($"Informacion del Mantenimiento:\nFecha: {Fecha}\nDescripcion: {Descripcion}\nCosto: ${Costo}");
        }
    }
}
