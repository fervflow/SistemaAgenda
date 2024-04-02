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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text;
            int pin = 0;
            if(usuario.Length == 0)
            {
                MessageBox.Show("Debes ingresar tu usuario","Mi Agenda",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if(int.TryParse(mtbPin.Text, out pin) == false)
            {
                MessageBox.Show("Revisa el pin", "Mi Agenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UsuarioDAO usuarioBD = new UsuarioDAO();
            Usuario usuarioObj = new Usuario();
            usuarioObj = usuarioBD.iniciarSesionUsuario(usuario, pin);
            if (usuarioObj == null)
            {
                MessageBox.Show("Datos invalidos", "Mi Agenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                FormAgenda formAgenda = new FormAgenda(usuarioObj);
                formAgenda.Show();
            }
            
        }

        private void lkbNuevaCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormNuevoUsuario formNuevoUsuario = new FormNuevoUsuario();
            formNuevoUsuario.ShowDialog();
        }
    }
}
