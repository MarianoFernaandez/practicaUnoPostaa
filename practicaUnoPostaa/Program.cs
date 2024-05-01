using practicaUno.Models;
using practicaUnoPostaa;
using System;
class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[5] { 1, 2, 3, 4, 5 };
        int numeroguardado = numeros[2];
        System.Console.WriteLine(numeroguardado);
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("iteracion: " + (i + 1) + "-" + numeros[i]);
        }


        foreach (var numero in numeros) // otra forma de hacer un for
        {
            Console.WriteLine(numeros);
        }

        System.Console.Write(numeros.Length); //largo del vector
        Bebida bebida = new Bebida();
        Bebida bebida2 = new Bebida("Fanta", 400);
        Vino vinoUno = new Vino(50);
        Cerveza cerveza = new Cerveza();
        bebida.SetNombre("Coca-Cola");
        bebida.SetCantidad(50);
        bebida.tomarse(100);
        bebida2.SetNombre("Fanta");
        bebida2.SetCantidad(100);
        bebida2.tomarse(50);

        System.Console.WriteLine("\n Le quedan " + bebida.cantidad + "a la bebida" + bebida.nombre);
        System.Console.WriteLine("Le queda" + bebida2.nombre + "a la bebida" + bebida2.nombre);

        mostrarRecomendacion(vinoUno);
        mostrarRecomendacion(cerveza);

        System.Console.ReadKey();
    }

    static void mostrarRecomendacion(IBebidaAlcoholica bebidaAlcoholica)
    {
        bebidaAlcoholica.maxRecomendado();
    }
}
