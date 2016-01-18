using System.Drawing;

namespace Modelo
{
    class Imagen
    {
        private int iCodigo;
        private Image iPicture;
        private int iTiempo;

        /// <summary>
        /// Constructor de la Imagen
        /// </summary>
        /// <param name="pCodigo">Código de la Imagen</param>
        /// <param name="pTiempo">Tiempo de reproducción de la Imagen</param>
        /// <param name="pImagen">Imagen que se va a mostrar</param>
        public Imagen(int pCodigo,int pTiempo, Image pPicture)
        {
            this.iCodigo = pCodigo;
            this.iPicture = pPicture;
            this.iTiempo = pTiempo;
        }

        /// <summary>
        /// Get del Código de la Imagen
        /// </summary>
        public int Codigo
        {
            get { return this.iCodigo; }
        }

        /// <summary>
        /// Get/Set de la Imagen (Image)
        /// </summary>
        public Image Picture
        {
            get { return this.iPicture; }
            set { this.iPicture = value; }
        }

        /// <summary>
        /// Get/Set del Tiempo en el que se reproduce la Imagen
        /// </summary>
        public int Tiempo
        {
            get { return this.iTiempo; }
            set { this.iTiempo = value; }
        }
    }
}
