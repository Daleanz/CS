// iTz_DiLAN

using System;

namespace Proyect1;

public class Program{
    public static void Main(string[] args){
        int[] numeros1 = { 1, 2, 3, 4, 5 };
        int[] numeros2 = { 10, 2, 3, 4, 1 };
        int[] numeros3 = new int[numeros1.Length];

        for (int i = 0; i < numeros1.Length; i ++){
            for(int j = 0; j < numeros2.Length; j ++){
                if(i == j){
                    numeros3[i] = numeros1[i] + numeros2[j];
                }
            }
        }
        foreach(int indice in numeros3){
            System.Console.WriteLine(indice);
        }
    }
}
