using System;
using System.Collections.Generic;
using FlotaVehiculos;

namespace FlotaVehiculos{
    abstract class Vehiculo{
        private string marca;
        private string modelo;
        private int anioFabricacion;
        private double consumo;
        private double kilometraje;
        private List<MantenimientoVehiculo> mantenimientos;

        public Vehiculo(string marca, string modelo, int anioFabricacion, double consumo, double kilometraje){
            this.marca = marca;
            this.modelo = modelo;
            this.anioFabricacion = anioFabricacion;
            this.consumo = consumo;
            this.kilometraje = kilometraje;
            this.mantenimientos = new List<MantenimientoVehiculo>();
        }

        public string Marca{
            get{return marca;}
            set{this.marca = value;}
        }

        public string Modelo{
            get{return modelo;}
            set{this.modelo = value;}
        }

        public int AnioFabricacion{
            get{return anioFabricacion;}
            set{this.anioFabricacion = value;}
        }

        public double Consumo{
            get{return consumo;}
            set{this.consumo = value;}
        }

        public double Kilometraje{
            get{return kilometraje;}
            set{this.kilometraje = value;}
        }

        public List<MantenimientoVehiculo> Mantenimientos{
            get{return mantenimientos;}
        }

        public void agregarMantenimiento(MantenimientoVehiculo mantenimiento){
            mantenimientos.Add(mantenimiento);
        }
        
        public abstract void calcularEficienciaCombustible();

        public abstract void mostrarInformacion();
    }
}
