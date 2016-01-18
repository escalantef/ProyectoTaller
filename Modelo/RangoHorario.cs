using System;

namespace Modelo
{
    class RangoHorario
    {
        private TimeSpan iHoraInicio;
        private TimeSpan iHoraFin;
        private int iCodigo;

        /// <summary>
        /// Constructor del Rango de Horario
        /// </summary>
        /// <param name="pHoraInicio">Hora de inicio del Rango</param>
        /// <param name="pHoraFin">Hora de fin del Rango</param>
        public RangoHorario(int pCodigo, TimeSpan pHoraInicio, TimeSpan pHoraFin)
        {
            this.iCodigo = pCodigo;
            this.iHoraInicio = pHoraInicio;
            this.iHoraFin = pHoraFin;
        }

        /// <summary>
        /// Get del Código del Rango Horario
        /// </summary>
        public int Codigo
        {
            get { return this.iCodigo; }
            set { this.iCodigo = value; }
        }

        /// <summary>
        /// Get/Set de la Hora de Inicio del Rango Horario
        /// </summary>
        public TimeSpan HoraInicio
        {
            get { return this.iHoraInicio; }
            set { this.iHoraInicio = value; }
        }

        /// <summary>
        /// Get/Set de la Hora de Fin del Rango Horario
        /// </summary>
        public TimeSpan HoraFin
        {
            get { return this.iHoraFin; }
            set { this.iHoraFin = value; }
        }
    }
}
