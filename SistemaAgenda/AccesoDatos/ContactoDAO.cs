using SistemaAgenda.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaAgenda.AccesoDatos
{
    internal class ContactoDAO
    {
        private AccesoBD bd = null;
        public ContactoDAO()
        {
            bd = new AccesoBD();
        }

        public int insertarContacto(int user_id, Contacto c)
        {
            try
            {
                bd.conectarBD();
                string sql = "INSERT INTO contacto (nombre_completo, genero_contacto, telefono, detalle, usuario_contacto)" +
                    "OUTPUT Inserted.id_contacto VALUES (@nombre, @genero_contacto, @telefono, @detalle, @usuario)";
                SqlCommand cmd = new SqlCommand(sql, bd.con);
                cmd.Parameters.AddWithValue("@nombre", c.nombre_completo);
                cmd.Parameters.AddWithValue("@genero_contacto", c.genero_contacto);
                cmd.Parameters.AddWithValue("@telefono", c.telefono);
                cmd.Parameters.AddWithValue("@detalle", c.detalle);
                cmd.Parameters.AddWithValue("@usuario", c.usuario_contacto);

                int id_insertado = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                bd.cerrarBD();
                return id_insertado;
            } catch (Exception ex)
            {
                bd.cerrarBD();
                MessageBox.Show("Error al registrar el contacto en la BD: " + ex.Message);
                return -1;
            }
        }

        public List<Contacto> listaContactos(int user_id)
        {
            List<Contacto> contactos = new List<Contacto>();
            try
            {
                bd.conectarBD();
                string sql = "SELECT id_contacto, nombre_completo, telefono, genero_contacto, detalle FROM contacto WHERE usuario_contacto = @usuario";
                SqlCommand cmd = new SqlCommand(sql, bd.con);
                cmd.Parameters.AddWithValue("@usuario", user_id);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Contacto contacto = new Contacto();
                    contacto.id_contacto = Convert.ToInt32(reader["id_contacto"]);
                    contacto.nombre_completo = reader["nombre_completo"].ToString();
                    contacto.genero_contacto = Convert.ToInt32(reader["genero_contacto"]);
                    contacto.telefono = reader["telefono"].ToString();
                    contacto.detalle = reader["detalle"].ToString();
                    contacto.usuario_contacto = user_id;

                    contactos.Add(contacto);
                }
                reader.Close();
                cmd.Dispose();
                bd.cerrarBD();
            }
            catch (Exception ex)
            {
                bd.cerrarBD();
                MessageBox.Show("Error al obtener la lista de contactos: " + ex.Message);
            }
            return contactos;
        }

    }
}
