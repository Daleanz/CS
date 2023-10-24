using System;
using FlotaVehiculos;

namespace FlotaVehiculos{
    class Camion : Vehiculo{
        private double capacidadCarga;

        public Camion(string marca, string modelo, int anioFabricacion, double consumo, double kilometraje, double capacidadCarga) : base (marca, modelo, anioFabricacion, consumo, kilometraje){
            this.capacidadCarga = capacidadCarga;
        }

        public double CapacidadCarga{
            get{return capacidadCarga;}
            set{this.capacidadCarga = value;}
        }

        public override void calcularEficienciaCombustible(){
            double eficiencia = (base.Kilometraje / base.Consumo);
            System.Console.WriteLine("Eficiencia Combustible: " + eficiencia);
        }

        public override void mostrarInformacion(){
            System.Console.WriteLine("Informacion Completa del Camion:");
            System.Console.WriteLine($"Marca: {base.Marca}\nModelo: {base.Modelo}\nAnio Fabricacion: {base.AnioFabricacion}\nConsumo: {base.Consumo}\nKilometraje: {base.Kilometraje}");
            System.Console.WriteLine($"Capacidad Carga: {CapacidadCarga}");
        }
    } 
}
