using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UI
{
    class Campaña
    {
        public int Codigo { get; set; }
        public int IntervaloTiempo { get; set; }
        public string Nombre { get; set; }
        public List<RangoFecha> RangosFecha { get; set; }
    }
}
