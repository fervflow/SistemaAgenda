using SistemaAgenda.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAgenda.AccesoDatos
{
    internal class CitaDAO
    {
        private AccesoBD bd;

        public CitaDAO()
        {
            bd = new AccesoBD();
        }

        public int registrarCita(int usuario_id, Contacto c, string fechaHora, string motivo)
        {
            try
            {
                bd.conectarBD();
                string sql = "INSERT INTO cita(fecha_hora, motivo, usuario_cita, contacto_cita) " +
                             "VALUES(@fecha_hora, @motivo, @id_usuario, @id_contacto)";
                SqlCommand cmd = new SqlCommand(sql, bd.con);
                cmd.Parameters.AddWithValue("@id_usuario", usuario_id);
                cmd.Parameters.AddWithValue("@id_contacto", c.id_contacto);
                cmd.Parameters.AddWithValue("@fecha_hora", fechaHora);
                cmd.Parameters.AddWithValue("@motivo", motivo);
                cmd.ExecuteNonQuery();

                
                // int id_cita = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.Dispose();
                bd.cerrarBD();
                return 1;
            }
            catch (Exception ex)
            {
                bd.cerrarBD();
                MessageBox.Show("Error al registrar la cita en la BD: " + ex.Message);
                return -1;
            }
        }
    }
}