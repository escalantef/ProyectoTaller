using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class RSS : ITexto
    {
        private string iURL;

        /// <summary>
        /// Get de la URL del RSS
        /// </summary>
        public string URL
        {
            get { return this.iURL; }
            set { this.iURL = value; }
        }

        public string Texto()
        {
            return this.iURL;
        }
    }
}
