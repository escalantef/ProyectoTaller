namespace Modelo
{
    class InformacionAdicional
    {
        private int iCodigo;
        private string iNombre;
        private int iTiempoActualizacion;
        private string iValor;
        public string iFuente;

        /// <summary>
        /// Constructor de la Informacion Adicional
        /// </summary>
        /// <param name="pCodigo">Codigo de la Información Adicional</param>
        /// <param name="pNombre">Nombre de la Informacion Adicional</param>
        /// <param name="pTiempoActualizacion">Tiempo de Actualizacion de la Informacion Adicional</param>
        /// <param name="pFuente">Fuente de la Informacion Adicional</param>
        public InformacionAdicional(int pCodigo, string pNombre, int pTiempoActualizacion, string pFuente)
        {
            this.iCodigo = pCodigo;
            this.iNombre = pNombre;
            this.iTiempoActualizacion = pTiempoActualizacion;
            this.iFuente = pFuente;
        }

        /// <summary>
        /// Actualiza el valor de la Información Contextual
        /// </summary>
        public void Actualizar()
        {
        }

        /// <summary>
        /// Get del código de la Informacion Adicional
        /// </summary>
        public int Codigo
        {
            get { return this.iCodigo; }
        }

        /// <summary>
        /// Get/Set del nombre de la Información Adicional
        /// </summary>
        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }

        /// <summary>
        /// Get/Set del tiempo de actualizacion de la Información Adicional
        /// </summary>
        public int TiempoActualizacion
        {
            get { return this.iTiempoActualizacion; }
            set { this.iTiempoActualizacion = value; }
        }

        /// <summary>
        /// Get/Set de la Fuente de Informacion
        /// </summary>
        public string Fuente
        {
            get { return this.iFuente; }
            set { this.iFuente = value; }
        }

        /// <summary>
        /// Get del Valor de la Informacion Adicional
        /// </summary>
        public string Valor
        {
            get { return this.iValor; }
        }
    }
}
