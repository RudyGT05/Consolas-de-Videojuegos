using Ejercicio_13_04.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13_04.ClaseHijo
{
    internal class Xbox:ClsConsola
    {
        public string Almacenamiento {  get; set; }
        
        public String MostrarDetalleXbox()
        {
            return MostrarDetalles() + "Almacenamiento:" + Almacenamiento;
        }
    }
}
