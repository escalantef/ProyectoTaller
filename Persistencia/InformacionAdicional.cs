using System.ComponentModel.DataAnnotations;

namespace Persistencia
{
    class InformacionAdicional
    {
        [Key]
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int TiempoActualizacion { get; set; }
        public string Fuente { get; set; }
    }
}
