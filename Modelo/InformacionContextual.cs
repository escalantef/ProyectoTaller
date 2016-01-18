using System;
using System.Collections.Generic;

namespace Modelo
{
    class InformacionContextual
    {
        private DateTime iFechaHoraActualizacion;
        private string iISOPais;
        private string iCodigoPostal;
        private List<InformacionAdicional> iListaInformacionAdicional;

        /// <summary>
        /// Constructor de la Informacion Contextual
        /// </summary>
        /// <param name="pFechaHoraActualizacion">Fecha y Hora de la Última Actualizacion General </param>
        public InformacionContextual(DateTime pFechaHoraActualizacion, string pISOPais, string pCodigoPostal)
        {
            this.iFechaHoraActualizacion = pFechaHoraActualizacion;
            this.iISOPais = pISOPais;
            this.iCodigoPostal = pCodigoPostal;
        }
        
        /// <summary>
        /// Actualiza todas las Informaciones Adicionales
        /// </summary>
        public void Actualizar()
        {
            this.iFechaHoraActualizacion = DateTime.Now;
        }

        /// <summary>
        /// Get/Set de la FechaHora de Actualizacion
        /// </summary>
        public DateTime FechaHoraActualizacion
        {
            get { return this.iFechaHoraActualizacion; }
            set { this.iFechaHoraActualizacion = value; }
        }

        /// <summary>
        /// Get/Set de la Lista de Informacion Adicional
        /// </summary>
        public List<InformacionAdicional> ListaInformacionAdicional
        {
            get { return this.iListaInformacionAdicional; }
            set { this.iListaInformacionAdicional = value; }
        }

        /// <summary>
        /// Get/Set del código ISO del Pais
        /// </summary>
        public string ISOPais
        {
            get { return this.iISOPais; }
            set { this.iISOPais = value; }
        }

        /// <summary>
        /// Get/Set del Código Postal de la ciudad
        /// </summary>
        public string CodigoPostal
        {
            get { return this.iCodigoPostal; }
            set { this.iCodigoPostal = value; }
        }
    }
}
