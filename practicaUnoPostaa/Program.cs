using practicaUno.Models;
using System;
class Program
{
    static void Main(string[] args)
    {
        Bebida bebida = new Bebida();
        Bebida bebida2 = new Bebida("Fanta", 400);

        bebida.SetNombre("Coca-Cola");
        bebida.SetCantidad(50);
        bebida.tomarse(100);
        bebida2.SetNombre("Fanta");
        bebida2.SetCantidad(100);
        bebida2.tomarse(50);
        
        System.Console.WriteLine("Le quedan " + bebida.cantidad + "a la bebida" + bebida.nombre);
        System.Console.WriteLine("Le queda" + bebida2.nombre + "a la bebida" + bebida2.nombre);

    }
}
