using practicaUno.Models;
using System;
class Program
{
    static void Main(string[] args)
    {
        Bebida bebida = new Bebida("Coca-Cola", 500);
        Bebida bebida2 = new Bebida("Fanta", 400);

        bebida.tomarse(100);
        
        System.Console.WriteLine("Le quedan " + bebida.cantidad + "a la bebida" + bebida.nombre);
        System.Console.WriteLine("Le queda" + bebida2.nombre + "a la bebida" + bebida2.nombre);

    }
}
