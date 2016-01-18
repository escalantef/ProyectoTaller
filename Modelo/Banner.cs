using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System;

//Hace que sea visible para el Testing y los Servicios
[assembly: InternalsVisibleTo("Servicios")]
[assembly: InternalsVisibleTo("UI")]

namespace Modelo
{
    class Banner
    {
        private int iCodigo;
        private string iNombre;
        private ITexto iTexto;
        private List<RangoFecha> iListaRangosFecha;

        /// <summary>
        /// Constructor del Banner
        /// </summary>
        /// <param name="pCodigo">Código del Banner</param>
        /// <param name="pNombre">Nombre del Banner</param>
        public Banner(int pCodigo, string pNombre)
        {
            this.iCodigo = pCodigo;
            this.iNombre = pNombre;
            this.iListaRangosFecha = new List<RangoFecha>();
        }

        /// <summary>
        /// Get del código del Banner
        /// </summary>
        public int Codigo
        {
            get { return this.iCodigo; }
        }

        /// <summary>
        /// Get/Set del nombre del Banner
        /// </summary>
        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }

        /// <summary>
        /// Get del Texto del Banner
        /// </summary>
        public string Texto
        {
            get { return this.iTexto.Texto(); }

        }

        /// <summary>
        /// Get/Set del iTexto del Banner
        /// </summary>
        public ITexto InstanciaTexto
        {
            get { return this.iTexto; }
            set { this.iTexto = value; }
        }




        /// <summary>
        /// Get/Set de la Lista de Rangos de Fechas
        /// </summary>
        public List<RangoFecha> ListaRangosFecha
        {
            get { return this.iListaRangosFecha; }
            set { this.iListaRangosFecha = value; }
        }

        /// <summary>
        /// Agrega un Rango Fecha a la lista de rangos de fecha
        /// </summary>
        /// <param name="pRangoFecha">Rango de fecha que se agregará a la lista</param>
        public void AgregarRangoFecha(RangoFecha pRangoFecha)
        {
            this.iListaRangosFecha.Add(pRangoFecha);
        }

        /// <summary>
        /// Busca un rango fecha en la lista de rangos fechas por un determinado código
        /// </summary>
        /// <param name="pCodigo">Código del rango fecha</param>
        /// <returns></returns>
        public RangoFecha BuscarRangoFechaEnLista(DateTime pFechaDesde,DateTime pFechaHasta)
        {
            return this.iListaRangosFecha.Find(x => ((this.CompararFechas(x.FechaInicio, pFechaDesde)) && (this.CompararFechas(x.FechaFin, pFechaHasta))));
        }

        /// <summary>
        /// Compara dia,mes y año de dos fechas
        /// </summary>
        private Boolean CompararFechas(DateTime pFecha1, DateTime pFecha2)
        {
            bool devolucion;
            if(pFecha1.Day.Equals(pFecha2.Day) && pFecha1.Month.Equals(pFecha2.Month) && pFecha1.Year.Equals(pFecha2.Year))
            {
                devolucion = true;
            }
            else { devolucion = false; }
            return devolucion;
        }
    }
}
