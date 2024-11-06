using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    internal class Empleado
    {
        private EstadoEmpleado estado;

        public Empleado()
        {
            this.estado = EstadoEmpleado.LIBRE;
        }

        public void setEstado(EstadoEmpleado estado)
        {
            this.estado = estado;
        }

        public String getEstado()
        {
            return this.estado.ToString();
        }
    }
}
