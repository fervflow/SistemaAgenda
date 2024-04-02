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
    internal class UsuarioDAO
    {
        AccesoBD bd = null;
        public UsuarioDAO() {
            bd = new AccesoBD();
        }

        /*
         * Funcion insertarUsuario()
         * Parametro Usuario
         * Detalle: Recibe un usuario y lo inserta en la base de datos
         * retorne el id_contacto del usuario insertado
         */
        public int insertarUsuario(Usuario u)
        {
            try
            {
                bd.conectarBD();
                string sql = "INSERT INTO usuario(nombre, apellido, fecha_nacimiento, usuario, pin)" +
                    "OUTPUT Inserted.id_usuario VALUES(@NOMBRE, @APELLIDO, @FECHAN, @USUARIO, @PIN)";
                SqlCommand comandosql = new SqlCommand(sql, bd.con);
                comandosql.Parameters.AddWithValue("@NOMBRE",u.nombre);
                comandosql.Parameters.AddWithValue("@APELLIDO",u.apellido);
                comandosql.Parameters.AddWithValue("@FECHAN",u.fecha_nacimiento);
                comandosql.Parameters.AddWithValue("@USUARIO",u.usuario);
                comandosql.Parameters.AddWithValue("@PIN", u.pin);
                int id_insertado = Convert.ToInt32(comandosql.ExecuteScalar());
                comandosql.Dispose();
                bd.cerrarBD();
                return id_insertado;
            }
            catch(Exception ex)
            {
                bd.cerrarBD();
                MessageBox.Show("Error al insertar en la BD:"+ex.Message);
                return -1;
            }
        }

        public Usuario iniciarSesionUsuario(string us, int pin)
        {
            Usuario obj = new Usuario();
            try
            {
                bd.conectarBD();
                string sql = "SELECT id_usuario, nombre, apellido, fecha_nacimiento, usuario, pin FROM usuario WHERE usuario LIKE @USUARIO AND pin = @PIN";
                SqlCommand comandosql = new SqlCommand(sql,bd.con);
                comandosql.Parameters.AddWithValue("@USUARIO", us);
                comandosql.Parameters.AddWithValue("@PIN", pin);
                SqlDataReader resultado = comandosql.ExecuteReader();
                if (resultado.HasRows)
                {
                    resultado.Read();
                    obj.id_usuario = resultado.GetInt32(0);
                    obj.nombre = resultado.GetString(1);
                    obj.apellido = resultado.GetString(2);
                    obj.fecha_nacimiento = resultado.GetDateTime(3);
                    obj.usuario = resultado.GetString(4);
                    obj.pin = resultado.GetInt32(5);
                    comandosql.Dispose();
                    bd.cerrarBD();
                    return obj;
                }
                else
                {
                    comandosql.Dispose();
                    bd.cerrarBD();
                    return null;
                }

            } 
            catch(Exception ex)
            {
                bd.cerrarBD();
                MessageBox.Show("Error al insertar en la BD:"+ex.Message);
                return null;
            }
}

    }
}
