using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Fachada
    {
        List<Banner> iListaBanners;
        private static Fachada cInstancia = null;

        /// <summary>
        /// Constructor de la fachada
        /// </summary>
        public Fachada()
        {
            this.iListaBanners =new List<Banner>();
        }


        /// <summary>
        /// Devuelve la única instancia fachada de la clase
        /// </summary>
        public static Fachada Instancia
        {
            get
            {
                if (cInstancia == null)
                {
                    cInstancia = new Fachada();
                }
                return cInstancia;
            }
        }

        public List<Banner> ListaBanners
        {
            get { return this.iListaBanners; }
        }




        /// <summary>
        /// Agrega un rango de fecha a un Banner
        /// </summary>
        /// <param name="pBanner">Banner al que se le agregará un rango de fecha</param>
        /// <param name="pFechaDesde">Fecha de inicio del rango de fecha</param>
        /// <param name="pFechaHasta">Fecha fin del rango de fecha</param>
        public void AgregarRangoFecha(Banner pBanner,DateTime pFechaDesde,DateTime pFechaHasta)
        {
            RangoFecha rangoFecha = new RangoFecha(0, pFechaDesde, pFechaHasta);
            pBanner.AgregarRangoFecha(rangoFecha);
        }

        /// <summary>
        /// Agrega un Rango Horario a un Rango Fecha
        /// </summary>
        /// <param name="pRangoFecha">Rango fecha al que se le agregará un rango horario</param>
        /// <param name="pTiempoDesde">Inicio del rango horario</param>
        /// <param name="pTiempoHasta">Fin del rango horario</param>
        public void AgregarRangoHorario(RangoFecha pRangoFecha, TimeSpan pTiempoDesde, TimeSpan pTiempoHasta)
        {
            RangoHorario rangoHorario = new RangoHorario(0, pTiempoDesde, pTiempoHasta);
            pRangoFecha.agregarRangoHorario(rangoHorario);
        }

        /// <summary>
        /// Busca un rango de fecha en una lista
        /// </summary>
        /// <param name="pBanner">Banner en el cual buscará el rango de fecha</param>
        /// <param name="pCodigo">Código del rango de fecha.</param>
        /// <returns></returns>
        public RangoFecha BuscarRangoFechaEnLista(Banner pBanner, DateTime pFechaDesde, DateTime pFechaHasta)
        {
            return pBanner.BuscarRangoFechaEnLista(pFechaDesde, pFechaHasta);
        }

        /// <summary>
        /// Agrega un banner a la lista de banners
        /// </summary>
        /// <param name="pBanner">Banner a agregar</param>
        public void AgregarBanner(Banner pBanner)
        {
            this.iListaBanners.Add(pBanner);
        }
    }
}
