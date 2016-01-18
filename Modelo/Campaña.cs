using System.Collections.Generic;

namespace Modelo
{
    class Campaña
    {
        private int iCodigo;
        private int iInteravaloTiempo;
        private string iNombre;
        private List<RangoFecha> iListaRangosFecha;
        private List<Imagen> iListaImagenes;

        /// <summary>
        /// Constructor de la Campaña
        /// </summary>
        /// <param name="pCodigo">Codigo de la Campaña</param>
        /// <param name="pIntervaloTiempo">Intervalo de Tiempo de la Camapaña</param>
        /// <param name="pNombre">Nombre de la Campaña</param>
        /// <param name="pListaRangosFecha">Lista de los Rangos de Fecha de la Campaña</param>
        /// <param name="pListaImagenes">Lista de Imágenes de la Camapaña</param>
        public Campaña(int pCodigo, int pIntervaloTiempo, string pNombre, List<RangoFecha> pListaRangosFecha, List<Imagen> pListaImagenes)
        {
            this.iCodigo = pCodigo;
            this.iInteravaloTiempo = pIntervaloTiempo;
            this.iNombre = pNombre;
            this.iListaRangosFecha = pListaRangosFecha;
            this.iListaImagenes = pListaImagenes;
        }

        /// <summary>
        /// Get del código de la campaña
        /// </summary>
        public int Codigo
        {
            get { return this.iCodigo; }
        }

        /// <summary>
        /// Get/Set del intervalo de tiempo  de la campaña
        /// </summary>
        public int IntervaloTiempo
        {
            get { return this.iInteravaloTiempo; }
            set { this.iInteravaloTiempo = value; }
        }

        /// <summary>
        /// Get/Set del nombre de la campaña
        /// </summary>
        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }

        /// <summary>
        /// Get/Set de la lista de imágenes de la campaña
        /// </summary>
        public List<Imagen> ListaImagenes
        {
            get { return this.iListaImagenes; }
            set { this.iListaImagenes = value; }
        }

        /// <summary>
        /// Get/Set de la lista de Rangos de Fecha
        /// </summary>
        public List<RangoFecha> ListaRangosFecha
        {
            get { return this.iListaRangosFecha; }
            set { this.iListaRangosFecha = value; }
        }
    }
}
