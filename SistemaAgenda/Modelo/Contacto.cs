using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgenda.Modelo
{
    public class Contacto
    {
        public int id_contacto { get; set; }
        public string nombre_completo { get; set; }
        public int genero_contacto { get; set; }
        public string telefono { get; set; }
        public string detalle { get; set; }
        public int usuario_contacto { get; set; }

        public Contacto() {
            this.id_contacto = 0;
            this.nombre_completo = "";
            this.genero_contacto = 0;
            this.telefono = "";
            this.detalle = "";
            this.usuario_contacto = 0;
        }
    }
}
