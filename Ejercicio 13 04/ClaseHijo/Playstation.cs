using Ejercicio_13_04.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13_04.ClaseHijo
{
    internal class Playstation:ClsConsola
    {
        public string ModeloControlador {  get; set; }
        
        public String MostrarDetallePlay()
        {
            return MostrarDetalles() + "Controlador:" + ModeloControlador;
        }
    }
}
