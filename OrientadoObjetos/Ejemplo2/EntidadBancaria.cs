// iTz_DiLAN

using System;

namespace Ejemplo2{
    public class EntidadBancaria{
	private string nombre_cuenta; private int numero_cuenta; private double saldo_cuenta;

	public EntidadBancaria(string nombre_cuenta, int numero_cuenta, double saldo_cuenta){
	   this.nombre_cuenta = nombre_cuenta;
	   this.numero_cuenta = numero_cuenta;
	   this.saldo_cuenta = saldo_cuenta;
	}
	
	public EntidadBancaria(){
	    this.nombre_cuenta = " ";
	    this.numero_cuenta = 0;
	    this.saldo_cuenta = 0.0;
	}
	
	public void AgregarSaldo(double cantidad){
	    saldo_cuenta = saldo_cuenta + cantidad;
	}

	public void RetirarDinero(double cantidad){
	    if(saldo_cuenta < 0){
		System.Console.WriteLine("Saldo insuficiente");
	    }
	    saldo_cuenta = saldo_cuenta - cantidad;
	}

	public void SaldoActual(){
	    System.Console.WriteLine($"{saldo_cuenta}");
	}

	public void Transferencia(int numeroCuenta, double cantidad){
	    if(saldo_cuenta < 0){
		System.Console.WriteLine("Saldo insuficiente");
	    }
	    saldo_cuenta = saldo_cuenta - cantidad;

	    System.Console.WriteLine($"Transferencia Correcta a: {numeroCuenta} monto de ${cantidad}");

	}

	public void setNombreCuenta(string nombre_cuenta){
	    this.nombre_cuenta = nombre_cuenta;
	}

	public void setNumeroCuenta(int numero_cuenta){
	    this.numero_cuenta = numero_cuenta;
	}

	public void setSaldoCuenta(double saldo_cuenta){
	    this.saldo_cuenta = saldo_cuenta;
	}

	public string getNombreCuenta(){
	    return this.nombre_cuenta;
	}

	public int getNumeroCuenta(){
	    return this.numero_cuenta;
	}

	public double getSaldoCuenta(){
	    return this.saldo_cuenta;
	}

	public override string ToString(){
	    return $"Información cliente {nombre_cuenta}: N° Cuenta: {numero_cuenta}, Saldo Cuenta: ${saldo_cuenta}";
	}
    }
}
