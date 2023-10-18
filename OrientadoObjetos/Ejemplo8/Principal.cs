using System;
using TiendaOnline;

namespace TiendaOnline{
  public class Principal{
    public static void Main(string[] args){
      Productos P1 = new Productos(459, "Coca Cola", 600, 10);
      Productos P2 = new Productos(2930, "PC Gamer", 2400, 12);

      System.Console.WriteLine(P1.ToString());

      System.Console.WriteLine(P2.ToString());

      P1.ComprarProducto(9);

      P2.ComprarProducto(20);
    }
  }
}
