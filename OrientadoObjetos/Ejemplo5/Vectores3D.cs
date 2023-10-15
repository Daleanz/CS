// iTz_DiLAN

using System;

namespace Ejemplo5{
    public class Vectores3D{
	private double valor1;
	private double valor2;
	private double valor3;

	public Vectores3D(double valor1, double valor2, double valor3){
	    this.valor1 = valor1;
	    this.valor2 = valor2;
	    this.valor3 = valor3;
	}

	public void AsignarValor(int indice, double valor){
	    if(indice > 0 && indice < 4){
		if(indice == 1){
		    this.valor1 = valor;
		}
		if(indice == 2){
		    this.valor2 = valor;
		}
		if(indice == 3){
		    this.valor3 = valor;
		}
	    }else{
		System.Console.WriteLine("Error, ingreso de indice no existe [ 3 indices ]");
	    }
	}

	public void NormaVector(){
	    double norma = Math.Sqrt(Math.Pow(this.valor1, 2) + Math.Pow(this.valor2, 2) + Math.Pow(this.valor3, 2));

	    System.Console.WriteLine($"La norma del vector [{this.valor1},{this.valor2},{this.valor3}] es: {norma:F3}");
	}

	public void ProductoPunto(double v1, double v2, double v3){
	    double producto_punto = (this.valor1 * v1) + (this.valor2 * v2) + (this.valor3 * v3);

	    System.Console.WriteLine($"El producto punto entre el vector [{this.valor1},{this.valor2},{this.valor3}] * [{v1},{v2},{v3}] es: {producto_punto}");
	}

	public void ProductoCruz(double v1, double v2, double v3){
	    double[] vectorProductoCruz = new double[3];
	    double posX = (this.valor2 * v3) - (this.valor3 * v2);
	    double posY = -((this.valor1 * v3) - (this.valor3 * v1));
	    double posZ = (this.valor1 * v2) - (this.valor2 * v1);

	    vectorProductoCruz[0] = posX;
	    vectorProductoCruz[1] = posY;
	    vectorProductoCruz[2] = posZ;

	    System.Console.Write($"El producto cruz entre el vector [{this.valor1},{this.valor2},{this.valor3}] * [{v1},{v2},{v3}] es: ");
	    System.Console.WriteLine("[" + string.Join(", ", vectorProductoCruz) + "]");
	}
    }
}
