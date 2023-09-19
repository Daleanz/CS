using System;

namespace Proyect1;

public class Program{
    public static void Main(string[] args){
        int[] valores = new int[20];
        int contador = 0;
        int aux = 0;

        for(int i = 0; i < valores.Length; i ++){
            valores[i] = contador + 15;
            aux = contador;
            if(aux == contador){
                contador = contador * 2;
            }
            contador = aux + 100;
        }

        foreach(int t in valores){
            if(t % 3 == 0){
                System.Console.WriteLine(t);
            }
        }
    }
}
