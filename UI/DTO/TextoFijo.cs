using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class TextoFijo : ITexto
    {
        private string iTexto;


        /// <summary>
        /// Texto Fijo
        /// </summary>
        /// <returns>Tipo de dato string que representa el Texto Fijo</returns>
        public string Texto
        {
            get { return this.iTexto; }
            set { this.iTexto = value; }
        }

        string ITexto.Texto()
        {
            return this.iTexto;
        }
    }
}
