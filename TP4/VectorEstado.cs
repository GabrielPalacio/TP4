using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    internal class VectorEstado
    {
        private String evento;
        private Double reloj;
        private Double tiempoProximaLlegadaCliente;
        private Double rndSolicitudCliente;
        private String solicitudCliente;
        private Double rndConsulta;
        private Double tiempoConsulta;
        private Double tiempoFinConsulta;
        private Double rndBusquedaLibro;
        private Double tiempoBusquedaLibro;
        private Double tiempoFinBusquedaLibro;
        private Double rndDevolucionLibro;
        private Double tiempoDevolucionLibro;
        private Double tiempoFinDevolucionLibro;
        private Double rndUsoInstalacion;
        private String usoInstalacion;
        private Double tiempoFinUsoInstalacion;
        private long cantidadClientesDentro;
        private List<Empleado> empleadoList;
        private long clientesQueIngresaron;
        private long cantidadColaBusquedaLibro;
        private long cantidadColaDevolucionLibro;
        private long cantidadColaConsultaAfiliacion;

        public double Reloj { get => reloj; set => reloj = value; }
        public double TiempoProximaLlegadaCliente { get => tiempoProximaLlegadaCliente; set => tiempoProximaLlegadaCliente = value; }
        public double RndSolicitudCliente { get => rndSolicitudCliente; set => rndSolicitudCliente = value; }
        public string SolicitudCliente { get => solicitudCliente; set => solicitudCliente = value; }
        public double RndConsulta { get => rndConsulta; set => rndConsulta = value; }
        public double TiempoConsulta { get => tiempoConsulta; set => tiempoConsulta = value; }
        public double TiempoFinConsulta { get => tiempoFinConsulta; set => tiempoFinConsulta = value; }
        public double RndBusquedaLibro { get => rndBusquedaLibro; set => rndBusquedaLibro = value; }
        public double TiempoBusquedaLibro { get => tiempoBusquedaLibro; set => tiempoBusquedaLibro = value; }
        public double TiempoFinBusquedaLibro { get => tiempoFinBusquedaLibro; set => tiempoFinBusquedaLibro = value; }
        public double RndDevolucionLibro { get => rndDevolucionLibro; set => rndDevolucionLibro = value; }
        public double TiempoDevolucionLibro { get => tiempoDevolucionLibro; set => tiempoDevolucionLibro = value; }
        public double TiempoFinDevolucionLibro { get => tiempoFinDevolucionLibro; set => tiempoFinDevolucionLibro = value; }
        public double RndUsoInstalacion { get => rndUsoInstalacion; set => rndUsoInstalacion = value; }
        public string UsoInstalacion { get => usoInstalacion; set => usoInstalacion = value; }
        public double TiempoFinUsoInstalacion { get => tiempoFinUsoInstalacion; set => tiempoFinUsoInstalacion = value; }
        public long CantidadClientesDentro { get => cantidadClientesDentro; set => cantidadClientesDentro = value; }


        public VectorEstado()
        {
            evento = "INICIO";
            reloj = 0;
            tiempoProximaLlegadaCliente = 0;
            solicitudCliente = "";

            this.empleadoList = new List<Empleado>();
            this.empleadoList.Add(new Empleado());
            this.empleadoList.Add(new Empleado());

            this.clientesQueIngresaron = 0;
            this.cantidadColaBusquedaLibro = 0;
            this.cantidadColaDevolucionLibro = 0;
            this.cantidadColaConsultaAfiliacion = 0;

    }


    public void calcularProximaLlegada(Double tiempo)
        {
            tiempoProximaLlegadaCliente = reloj + tiempo;
        }

        public void tipoSolicitudCliente(Double probPedirLibro, Double probDevolverLibro, Double probConsultarAfiliacion)
        {
            Double rnd = GeneradorDistribuciones.GenerarRandom();

            this.rndSolicitudCliente= rnd;

            if(rnd >= 0 &&  rnd <= probPedirLibro)
            {
                this.solicitudCliente = "PEDIR LIBRO";
            }
            else if(rnd > probPedirLibro && rnd <= probDevolverLibro)
            {
                this.solicitudCliente = "DEVOLUCION LIBRO";
            }
            else
            {
                this.solicitudCliente = "CONSULTA AFILIACION";
            }

        }

        public void calcularTiempoConsulta(Double a, Double b)
        {
            this.rndConsulta = GeneradorDistribuciones.GenerarRandom();
            this.tiempoConsulta = GeneradorDistribuciones.GenerarUniforme(a, b, this.rndConsulta);
            this.tiempoFinConsulta = this.reloj + this.tiempoConsulta;
        }

        public void calcularTiempoBusquedaLibro(Double media)
        {
            this.rndBusquedaLibro = GeneradorDistribuciones.GenerarRandom();
            this.tiempoBusquedaLibro  = GeneradorDistribuciones.GenerarExponencial(media, this.rndBusquedaLibro);
            this.tiempoFinBusquedaLibro = this.reloj + this.tiempoBusquedaLibro;
        }

        public void calcularTiempoDevolucionLibro(Double a, Double b)
        {
            this.rndDevolucionLibro = GeneradorDistribuciones.GenerarRandom();
            this.tiempoDevolucionLibro = GeneradorDistribuciones.GenerarUniforme(a, b, this.rndDevolucionLibro);
            this.tiempoDevolucionLibro = this.reloj + this.tiempoDevolucionLibro;
        }

        public void utilizaInstalacion(Double probRetirarse, Double probQuedarse, Double tiempoUsoInstalacion)
        {
            this.rndUsoInstalacion = GeneradorDistribuciones.GenerarRandom();

            if(this.rndBusquedaLibro >= 0 && this.rndBusquedaLibro <= probQuedarse)
            {
                this.usoInstalacion = "NO";
            }
            else
            {
                this.usoInstalacion = "SI";
                this.tiempoFinUsoInstalacion = this.reloj + tiempoUsoInstalacion;
            }
        }

        public bool bibliotecaCerrada()
        {
            return this.cantidadClientesDentro == 20;
        }

        public Double getReloj() { return reloj; }

        public Double getTiempoProximaLlegadaCliente()
        {
            return tiempoProximaLlegadaCliente;
        }

        public String getSolicitudCliente() { return solicitudCliente; }


        public String getEmpleadoEstado(int nroEmpleado)
        {
            return this.empleadoList[nroEmpleado-1].getEstado();
        }

        public String getEvento()
        {
            return this.evento;
        }


        public Evento proximoEvento()
        {
            if(this.evento == "INICIO")
            {
                return Evento.PROXIMO_LLEGADA_CLIENTE;
            }

            if(this.tiempoProximaLlegadaCliente > this.reloj)
            {
                this.evento = Evento.PROXIMO_LLEGADA_CLIENTE.ToString();

                return Evento.PROXIMO_LLEGADA_CLIENTE;
            }
            return null;
        }

        internal void llegadaCliente()
        {
            this.reloj = this.reloj + this.tiempoProximaLlegadaCliente;
            this.evento = Evento.PROXIMO_LLEGADA_CLIENTE.ToString();
            this.clientesQueIngresaron++;


            calcularProximaLlegada(Parametros.TiempoLlegadaCliente);

            if(this.cantidadClientesDentro < 20)
            {
                int indexEmpleadoLibre = empleadoList.FindIndex(empleado => empleado.getEstado() == EstadoEmpleado.LIBRE.ToString());

                // indexEmpleadoLibre != -1 => Hay un empleado libre en esa posicion (index)
                // indexEmpleadoLibre == -1 => NO hay empleado libre
                if (indexEmpleadoLibre != -1)
                {
                    this.rndConsulta = GeneradorDistribuciones.GenerarRandom();

                    if (this.rndConsulta >= 0 && this.rndConsulta <= Parametros.ProbabilidadPedirLibro)
                    {
                        this.solicitudCliente = "PEDIR LIBRO";

                        calcularTiempoBusquedaLibro(Parametros.TiempoMedioBusquedaLibro);


                        this.rndUsoInstalacion = GeneradorDistribuciones.GenerarRandom();

                        if (this.rndBusquedaLibro >= 0 && this.rndBusquedaLibro <= Parametros.ProbabilidadUsoInstalacion)
                        {
                            this.usoInstalacion = "NO";
                        }
                        else
                        {
                            this.usoInstalacion = "SI";
                            this.tiempoFinUsoInstalacion = this.reloj + Parametros.TiempoUsoInstalacion;
                        }
                    }
                    else if (this.rndConsulta > Parametros.ProbabilidadDevolucionLibro && this.rndConsulta <= Parametros.ProbabilidadDevolucionLibro)
                    {
                        this.solicitudCliente = "DEVOLUCION LIBRO";

                        calcularTiempoDevolucionLibro(Parametros.TiempoDevolucionLibroA, Parametros.TiempoDevolucionLibroB);
                    }
                    else
                    {
                        this.solicitudCliente = "CONSULTA AFILIACION";

                        calcularTiempoConsulta(Parametros.TiempoResolucionConsultaA, Parametros.TiempoResolucionConsultaB);
                    }


                    empleadoList[indexEmpleadoLibre].setEstado(EstadoEmpleado.OCUPADO);
                }
            }



        }
    }
}
