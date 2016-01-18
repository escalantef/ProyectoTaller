namespace Modelo
{
    class Servidor
    {
        private string iFuente;
        private string iRuta;

        /// <summary>
        /// Constructor del Servidor
        /// </summary>
        /// <param name="pISOPais">Código ISO del país</param>
        /// <param name="pCodigoPostal">Código Postal de la ciudad</param>
        /// <param name="pRuta">Ruta del Archivo con la biblioteca DLL para tratamiento</param>
        public Servidor(string pISOPais, string pCodigoPostal, string pRuta)
        {
            this.iFuente = "";
            this.iRuta = pRuta;
        }

        /// <summary>
        /// Get/Set de la Fuente de información del Servidor
        /// </summary>
        public string Fuente
        {
            get { return this.iFuente; }
        }

        /// <summary>
        /// Trata la información de la fuente y así obtiene el valor esperado
        /// </summary>
        /// <returns>Tipo de dato String que representa lo que se obtiene de la fuente luego del tratamiento</returns>
        public string Valor()
        {
            return "";
        }
    }
}
