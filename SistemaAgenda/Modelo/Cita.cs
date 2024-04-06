using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgenda.Modelo
{
    public class Cita
    {
        public int id_cita { get; set; }
        public int id_usuario { get; set; }
        public string contacto { get; set; }
        public string fecha_hora { get; set; }
        public string motivo { get; set; }

        public Cita()
        {
            id_cita = 0;
            id_usuario = 0;
            contacto = "";
            fecha_hora = "";
            motivo = "";
        }
    }
}
