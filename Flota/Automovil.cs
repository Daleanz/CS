using System;
using FlotaVehiculos;

namespace FlotaVehiculos{
    class Automovil : Vehiculo{
        private int cantidadPasajeros;

        public Automovil(string marca, string modelo, int anioFabricacion, double consumo, double kilometraje, int cantidadPasajeros) : base(marca, modelo, anioFabricacion, consumo, kilometraje){
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public int CantidadPasajeros{
            get{return cantidadPasajeros;}
            set{this.cantidadPasajeros = value;}
        }

        public override void calcularEficienciaCombustible(){
            double eficiencia = (base.Kilometraje / base.Consumo);
            System.Console.WriteLine("Eficiencia Combustible: " + eficiencia);
        }

        public override void mostrarInformacion(){
            System.Console.WriteLine("Informacion Completa del Automovil:");
            System.Console.WriteLine($"Marca: {base.Marca}\nModelo: {base.Modelo}\nAnio Fabricacion: {base.AnioFabricacion}\nConsumo: {base.Consumo}\nKilometraje: {base.Kilometraje}");
            System.Console.WriteLine($"Cantidad Pasajeros: {CantidadPasajeros}");
        }
    }
}
