using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace UI
{
    class Banner
    {
        private int iCodigo;
        private string iNombre;
        private ITexto iTexto;
        private List<RangoFecha> iListaRangosFecha;
        private int iCodigoRangoFecha;

        /// <summary>
        /// Constructor del Banner
        /// </summary>
        public Banner()
        {
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
    }
}
