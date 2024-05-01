﻿using practicaUno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaUnoPostaa
{
    internal class Vino : Bebida , IBebidaAlcoholica
    {
        public Vino(int Cantidad, string Nombre = "Vino")
            : base(Nombre, Cantidad)
        {

        }
        public int alcohol { get ; set ; }

        public void maxRecomendado()
        {
            Console.WriteLine("El maximo permitido de vino es de dos botellas por persona");
        }
    }
}
