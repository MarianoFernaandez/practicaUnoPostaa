using practicaUno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaUnoPostaa
{
    internal class Cerveza : Bebida, IBebidaAlcoholica
    {
        public Cerveza()
        {

        }
        public Cerveza(int Cantidad, string Nombre = "Cerveza")
            : base(Nombre, Cantidad)
        {

        }
        public int alcohol { get; set; }

        public void maxRecomendado()
        {
            Console.WriteLine("El maximo permitido de cerveza es de seis latas por persona");
        }
    }
}

