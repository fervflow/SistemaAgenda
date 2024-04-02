using SistemaAgenda.AccesoDatos;
using SistemaAgenda.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAgenda
{
    public partial class FormNuevoUsuario : Form
    {
        public FormNuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnAgregarDatos_Click(object sender, EventArgs e)
        {
            //Crear el usuario
            Usuario u = new Usuario();
            int pin = 0;
            u.nombre = tbNombre.Text;
            u.apellido = tbApellido.Text;
            u.fecha_nacimiento = dtFechaNacimiento.Value;
            u.usuario = tbUsuario.Text;
            if(int.TryParse(mtbPin1.Text, out pin))
            {
                u.pin = pin;
            }
            //Validar
            if (u.validarDatos() == false)
            {
                MessageBox.Show("Revisa los datos ingresados", "Mi Agenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(mtbPin1.Text != mtbPin2.Text)
            {
                MessageBox.Show("Los PIN ingresados no coinciden", "Mi Agenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Guardar en la BD
            UsuarioDAO usuarioBD = new UsuarioDAO();
            int r = usuarioBD.insertarUsuario(u);
            if (r == -1)
            {
                MessageBox.Show("No pude insertar en la BD", "Mi Agenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Bienvenido "+u.nombre+" ya puedes ingresar con tus datos", "Mi Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
    }
}
