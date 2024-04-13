using Ejercicio_13_04.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13_04.ClaseHijo
{
    internal class SegaDreamCast : ClsConsola
    {
        public string Color { get; set; }

        public String MostrarDetalleSega()
        {
            return MostrarDetalles() + "Color:" + Color;
        }

    }
}

