using Ejercicio_13_04.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13_04.ClaseHijo
{
    internal class Nintendo:ClsConsola
    {
        public bool esPortable {  get; set; }  

        public string MostarDetallesNintendo()
        {
            string detallePadre = MostrarDetalles();
            return detallePadre + "Es portable:" + esPortable;
        }
    }
}
