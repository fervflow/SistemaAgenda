using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgenda.Modelo
{
    public class Cita
    {
        public int id_usuario { get; set; }
        public int id_contacto { get; set; }
        public string fecha_hora { get; set; }
        public string motivo { get; set; }

        public Cita()
        {
            id_usuario = 0;
            id_contacto = 0;
            fecha_hora = "";
            motivo = "";
        }
    }
}
