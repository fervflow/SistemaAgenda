using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgenda.Modelo
{
    public class Usuario
    {
		public int id_usuario { get; set; }
		public string nombre { get; set;}
		public string apellido { get; set;}
		public DateTime fecha_nacimiento { get; set; }
		public string usuario { get; set; }
		public int pin { get; set; }

		public Usuario()
		{
			id_usuario = 0;
			nombre = "";
			apellido = "";
			usuario = "";
			pin = 0;
		}
		public bool validarDatos()
		{
			if (nombre.Length == 0 || apellido.Length == 0 || usuario.Length == 0 || pin == 0)
				return false;
			else
				return true;
		}
        
    }
}
