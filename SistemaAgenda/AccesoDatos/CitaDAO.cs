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

        public int registrarCita(int usuario_id, Contacto contacto, string fechaHora, string motivo)
        {
            try
            {
                bd.conectarBD();
                string sql = "INSERT INTO cita(fecha_hora, motivo, usuario_cita, contacto_cita) " +
                             "VALUES(@fecha_hora, @motivo, @usuario_cita, @contacto_cita)";
                SqlCommand cmd = new SqlCommand(sql, bd.con);
                cmd.Parameters.AddWithValue("@fecha_hora", fechaHora);
                cmd.Parameters.AddWithValue("@motivo", motivo);
                cmd.Parameters.AddWithValue("@usuario_cita", usuario_id);
                cmd.Parameters.AddWithValue("@contacto_cita", contacto.id_contacto);
                cmd.ExecuteNonQuery();

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

        public List<Cita> listaCitas(int usuario_id)
        {
            List<Cita> citas = new List<Cita>();
            try
            {
                bd.conectarBD();
                string sql = "SELECT ci.id_cita, ci.fecha_hora, ci.motivo," +
                    " CONCAT(co.telefono, ', ', co.nombre_completo) AS contacto" +
                    " FROM cita AS ci INNER JOIN contacto AS co" +
                    " ON ci.contacto_cita = co.id_contacto" +
                    " WHERE ci.usuario_cita = 1";
                SqlCommand cmd = new SqlCommand(sql, bd.con);
                cmd.Parameters.AddWithValue("@usuario_id", usuario_id);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Cita cita = new Cita();
                    cita.id_cita = Convert.ToInt32(reader["id_cita"]);
                    cita.fecha_hora = reader["fecha_hora"].ToString();
                    cita.motivo = reader["motivo"].ToString();
                    cita.id_usuario = usuario_id;
                    cita.contacto = reader["contacto"].ToString();

                    citas.Add(cita);
                }
                reader.Close();
                cmd.Dispose();
                bd.cerrarBD();
            }
            catch (Exception ex)
            {
                bd.cerrarBD();
                MessageBox.Show("Error al obtener la lista de citas: " + ex.Message);
            }
            return citas;
        }
    }
}