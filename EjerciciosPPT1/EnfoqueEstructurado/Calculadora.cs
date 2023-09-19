using System;

namespace Calculadora{
    public class Program{
        public static void Main(string[] args){
            System.Console.Write("Ingrese el primer numero: ");
            int numero1 = System.Convert.ToInt32(System.Console.ReadLine());

            System.Console.Write("Ingrese el segundo numero: ");
            int numero2 = System.Convert.ToInt32(System.Console.ReadLine());

            string mensaje1 = "Calculadora \r\n 1) Suma \r\n 2) Resta \r\n 3) Multiplicacion \r\n 4) Division \r\n 5) Salir";
            string mensaje2 = "¿Continuar usando la calculadora? Presione (1): ";
            System.Console.WriteLine(mensaje1);

            System.Console.Write("Ingrese una opcion: ");
            int opcion = System.Convert.ToInt32(System.Console.ReadLine());
            bool flag = true;
            int resultado = 0;
            while(flag){
                switch (opcion)
                {
                    case 1:
                        resultado = numero1 + numero2;
                        System.Console.WriteLine($"El resultado de la suma es: {resultado}");
                        System.Console.Write(mensaje2);
                        opcion = System.Convert.ToInt32(System.Console.ReadLine());

                        if(opcion == 1){
                            opcion = 0;
                            System.Console.WriteLine(mensaje1);
                            System.Console.Write("Ingrese una opcion: ");
                            opcion = System.Convert.ToInt32(System.Console.ReadLine());
                            flag = true;
                        }else{
                            opcion = 5;
                        }
                        break;
                    case 2:
                        resultado = numero1 - numero2;
                        System.Console.WriteLine($"El resultado de la resta es: {resultado}");
                        System.Console.Write(mensaje2);
                        opcion = System.Convert.ToInt32(System.Console.ReadLine());

                        if(opcion == 1){
                            opcion = 0;
                            System.Console.WriteLine(mensaje1);
                            System.Console.Write("Ingrese una opcion: ");
                            opcion = System.Convert.ToInt32(System.Console.ReadLine());
                            flag = true;
                        }else{
                            opcion = 5;
                        }
                        break;
                    case 3:
                        resultado = numero1 * numero2;
                        System.Console.WriteLine($"El resultado de la multiplicacion es: {resultado}");
                        System.Console.Write(mensaje2);
                        opcion = System.Convert.ToInt32(System.Console.ReadLine());

                        if(opcion == 1){
                            opcion = 0;
                            System.Console.WriteLine(mensaje1);
                            System.Console.Write("Ingrese una opcion: ");
                            opcion = System.Convert.ToInt32(System.Console.ReadLine());
                            flag = true;
                        }else{
                            opcion = 5;
                        }
                        break;
                    case 4:
                        resultado = numero1 / numero2;
                        System.Console.WriteLine($"El resultado de la division es: {resultado}");
                        System.Console.Write(mensaje2);
                        opcion = System.Convert.ToInt32(System.Console.ReadLine());

                       if(opcion == 1){
                            opcion = 0;
                            System.Console.WriteLine(mensaje1);
                            System.Console.Write("Ingrese una opcion: ");
                            opcion = System.Convert.ToInt32(System.Console.ReadLine());
                            flag = true;
                       }else{
                            opcion = 5;
                       }
                        break;
                    case 5:
                        System.Console.WriteLine("Cerrando calculadora...");
                        flag = false;
                        break;
                    default:
                        System.Console.WriteLine("Error al ingresar un numero.");
                        return;
                }
            }
        }
    }
}
