using System;
using FlotaVehiculos;

public class Program{
    public static void Main(string[] args){
        Object[] FlotaVehiculos = new Object[3];

        Camion C1 = new Camion("Volvo", "VNL", 2020, 5, 150000, 20000);
        Automovil A1 = new Automovil("Toyota", "Corolla", 2019, 2.5, 80000, 5);
        Motocicleta M1 = new Motocicleta("Honda", "CBR600RR", 2021, 1.2, 10000, "Deportiva");

        FlotaVehiculos[0] = C1;
        FlotaVehiculos[1] = A1;
        FlotaVehiculos[2] = M1;

        MantenimientoVehiculo MC1 = new MantenimientoVehiculo(DateTime.Parse("15-1-2023"), "Cambio de aceite", 50000);
        MantenimientoVehiculo MA1 = new MantenimientoVehiculo(DateTime.Parse("20-2-2023"), "Reemplazo de frenos", 75000); 
        MantenimientoVehiculo MM1 = new MantenimientoVehiculo(DateTime.Parse("10-3-2023"), "Ajuste de motor", 150000);

        C1.agregarMantenimiento(MC1);
        A1.agregarMantenimiento(MA1);
        M1.agregarMantenimiento(MM1);

        foreach(Vehiculo ob in FlotaVehiculos){
            ob.mostrarInformacion();
            ob.calcularEficienciaCombustible();

        }
    }
}
