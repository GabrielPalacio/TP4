using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
    public partial class Form1 : Form
    {
        private Double llegadaCliente;
        private VectorEstado vectorEstado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            vectorEstado = new VectorEstado();

            Parametros.TiempoLlegadaCliente = 4;
            Parametros.ProbabilidadPedirLibro = 0.45;
            Parametros.ProbabilidadDevolucionLibro = 0.45;
            Parametros.ProbabilidadConsultaAfiliacion = 0.10;
            Parametros.TiempoResolucionConsultaA = 2;
            Parametros.TiempoResolucionConsultaB = 5;
            Parametros.TiempoMedioBusquedaLibro = 6;
            Parametros.ProbabilidadRetiradaInstalacion = 0.60;
            Parametros.ProbabilidadUsoInstalacion = 0.40;
            Parametros.TiempoUsoInstalacion = 30;


            vectorEstado.calcularProximaLlegada(Parametros.TiempoLlegadaCliente);
            dibujarTabla();


            for (int i = 1; i < 4; i++)
            {
                switch (vectorEstado.proximoEvento())
                {
                    case var evento when evento == Evento.PROXIMO_LLEGADA_CLIENTE:
                        vectorEstado.llegadaCliente();
                        break;


                }

                dibujarTabla();
            }
        }

        private void dibujarTabla()
        {
            int newRowIndex = dgvSimulacion.Rows.Add(); // Agrega una nueva fila y devuelve el índice de la fila creada

            dgvSimulacion.Rows[newRowIndex].Cells["cEvento"].Value = vectorEstado.getEvento();
            dgvSimulacion.Rows[newRowIndex].Cells["cReloj"].Value = vectorEstado.getReloj();
            dgvSimulacion.Rows[newRowIndex].Cells["cProximaLlegadaCliente"].Value = vectorEstado.getTiempoProximaLlegadaCliente();
            dgvSimulacion.Rows[newRowIndex].Cells["cSolicitudCliente"].Value = vectorEstado.getSolicitudCliente();
            dgvSimulacion.Rows[newRowIndex].Cells["cRndSolicitud"].Value =;



            dgvSimulacion.Rows[newRowIndex].Cells["cEmpleadoUno"].Value = vectorEstado.getEmpleadoEstado(1);
            dgvSimulacion.Rows[newRowIndex].Cells["cEmpleadoDos"].Value = vectorEstado.getEmpleadoEstado(2);


        }

        private void dgvSimulacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
