using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaAgenda.AccesoDatos
{
    internal class AccesoBD
    {
        private string cadenaConexion;
        public SqlConnection con {  get; set; }
        public AccesoBD()
        {
            cadenaConexion = @"Data Source=localhost;Initial Catalog=agenda;User ID=agenda_admin;Password=admin123";
        }
        public void conectarBD(){
            try
            {
                con = new SqlConnection(cadenaConexion);
                con.Open();
            }catch(Exception ex) {
                MessageBox.Show("Error al conectar la BD: "+ex.Message);
            }
        }
        public void cerrarBD()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la BD: " + ex.Message);
            }
        }

    }
}
