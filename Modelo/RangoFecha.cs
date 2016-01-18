using System;
using System.Collections.Generic;

namespace Modelo
{
    class RangoFecha
    {
        private int iCodigo;
        private DateTime iFechaInicio;
        private DateTime iFechaFin;
        private List<RangoHorario> iListaRangosHorario;

        /// <summary>
        /// Constructor del Rango de Fechas
        /// </summary>
        /// <param name="pFechaInicio">Fecha de Inicio del rango</param>
        /// <param name="pFechaFin">Fecha de Fin del rango</param>
        /// <param name="pListaRangosHorarios">Lista de Rangos Horarios</param>
        public RangoFecha(int pCodigo, DateTime pFechaInicio, DateTime pFechaFin)
        {
            this.iCodigo = pCodigo;
            this.iFechaInicio = pFechaInicio;
            this.iFechaFin = pFechaFin;
            this.iListaRangosHorario = new List<RangoHorario>();
        }

        /// <summary>
        /// Get del Código del Rango de Fechas
        /// </summary>
        public int Codigo
        {
            get { return this.iCodigo; }
            set { this.iCodigo = value; }
        }
        
        /// <summary>
        /// Get/Set de la Fecha de Inicio del Rango de Fechas
        /// </summary>
        public DateTime FechaInicio
        {
            get { return this.iFechaInicio; }
            set { this.iFechaInicio = value; }
        }

        /// <summary>
        /// Get/Set de la Fecha de Fin del Rango de Fechas
        /// </summary>
        public DateTime FechaFin
        {
            get { return this.iFechaFin; }
            set { this.iFechaFin = value; }
        }

        /// <summary>
        /// Get/Set de la Lista de Rangos de Horario
        /// </summary>
        public List<RangoHorario> ListaRangosHorario
        {
            get { return this.iListaRangosHorario; }
            set { this.iListaRangosHorario = value; }
        }

        /// <summary>
        /// Agrega un Rango Horario a un Rango Fecha
        /// </summary>
        /// <param name="pRangoHorario">Rango horario que se agregará</param>
        public void agregarRangoHorario(RangoHorario pRangoHorario)
        {
            this.iListaRangosHorario.Add(pRangoHorario);
        }


    }
}
