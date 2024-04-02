using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAgenda.Modelo;
using SistemaAgenda.AccesoDatos;

namespace SistemaAgenda
{
    public partial class FormCrearContacto : Form
    {
        private int current_user_id;
        public FormCrearContacto(int current_user_id)
        {
            InitializeComponent();
            this.current_user_id = current_user_id;
        }
        private void FormCrearContacto_Load(object sender, EventArgs e)
        {
            rbVaron.Checked = true;
        }
        private void btRegistrarContacto_Click(object sender, EventArgs e)
        {
            Contacto c = new Contacto();
            c.nombre_completo = tbNombreCompleto.Text;
            c.genero_contacto = (rbVaron.Checked ? 1 : 2);
            c.telefono = tbTelefono.Text;
            c.detalle = tbDetalle.Text;
            c.usuario_contacto = this.current_user_id;

            ContactoDAO contactoBD = new ContactoDAO();
            int result = contactoBD.insertarContacto(current_user_id, c);
            if(result != -1)
            {
                MessageBox.Show("Contacto registrado exitosamente: " + c.nombre_completo + ", " + c.telefono);
            }
            Close();
        }
    }
}
