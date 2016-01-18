using System;

namespace Modelo
{
    class RSS : ITexto
    {
        private string iURL;

        /// <summary>
        /// Constructor del RSS
        /// </summary>
        /// <param name="pURL">Texto propio</param>
        public RSS(string pURL)
        {
            this.iURL = pURL;
        }


        /// <summary>
        /// Get de la URL del RSS
        /// </summary>
        public string URL
        {
            get { return this.iURL; }
        }

        public string Texto()
        {
            throw new NotImplementedException();
        }
    }
}
