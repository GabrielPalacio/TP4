using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    internal class Evento
    {
        public static readonly Evento PROXIMO_LLEGADA_CLIENTE = new Evento("PROXIMO_LLEGADA_CLIENTE");
        public static readonly Evento FIN_BUSQUEDA_LIBRO = new Evento("FIN_BUSQUEDA_LIBRO");
        public static readonly Evento FIN_DEVOLUCION_LIBRO = new Evento("FIN_DEVOLUCION_LIBRO");
        public static readonly Evento FIN_CONSULTA_AFILIACION = new Evento("FIN_CONSULTA_AFILIACION");
        public static readonly Evento FIN_USO_INSTALACION = new Evento("FIN_USO_INSTALACION");

        public string Nombre { get; private set; }

        private Evento(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
