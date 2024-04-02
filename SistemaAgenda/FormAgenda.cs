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
    public partial class FormAgenda : Form
    {
        Usuario usuario = null;
        public FormAgenda(Usuario u)
        {
            InitializeComponent();
            this.usuario = u;
            this.Text = "Agenda - " + this.usuario.nombre + " " + this.usuario.apellido;
        }

        private void FormAgenda_Load(object sender, EventArgs e)
        {

        }

        private void btCrearContacto_Click(object sender, EventArgs e)
        {
            FormCrearContacto frm = new FormCrearContacto(usuario.id_usuario);
            frm.ShowDialog();
        }

        private void btListarContactos_Click(object sender, EventArgs e)
        {
            FormListaContactos frm = new FormListaContactos(usuario.id_usuario);
            frm.ShowDialog();
        }
    }
}
