using System.Drawing;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("PersistenciaTesting")]
namespace Servicios
{
    class ImagenServices
    {
        /// <summary>
        /// Transforma la imagen a un array de bytes
        /// </summary>
        /// <param name="imageIn">Imagen de entrada que se transformará en un array de bytes</param>
        /// <returns>Tipo de dato Array de bytes que representa la imagen transformada</returns>
        public static byte[] ImageToByteArray(Image imageIn)
        {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Transforma un array de bytes a una imagen
        /// </summary>
        /// <param name="byteArrayIn">Array de bytes de entrada que se transformará en una imagen</param>
        /// <returns></returns>
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

    }
}
