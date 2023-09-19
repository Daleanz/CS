using System;

namespace Proyect1;

public class Program{
    public static void Main(string[] args){
        int[] numeros = new int[5];

        int contador = 10;
        for(int i = 0; i < numeros.Length; i ++){
            numeros[i] = contador;
            contador = contador + 10;
        }
        foreach(int j in numeros){
            System.Console.WriteLine(j);
        }
    }
}
