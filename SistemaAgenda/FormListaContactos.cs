using SistemaAgenda.AccesoDatos;
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

namespace SistemaAgenda
{
    public partial class FormListaContactos : Form
    {
        private int current_user_id;
        private ContactoDAO contactoDAO;
        public FormListaContactos(int current_user_id)
        {
            InitializeComponent();
            this.current_user_id = current_user_id;
            this.contactoDAO = new ContactoDAO();
            FillContactList();
        }

        private void FillContactList()
        {
            List<Contacto> contactos = contactoDAO.listaContactos(current_user_id);
            //dgvLista.DataSource = contactos;

            dgvLista.Rows.Clear();
            dgvLista.Columns.Clear();

            dgvLista.Columns.Add("ID", "ID");
            dgvLista.Columns.Add("NombreCompleto", "Nombre Completo");
            dgvLista.Columns.Add("Telefono", "Teléfono");
            dgvLista.Columns.Add("Genero", "Género");
            dgvLista.Columns.Add("Detalle", "Detalle");

            string gender = "";
            foreach (Contacto contacto in contactos)
            {
                gender = (contacto.genero_contacto == 1 ? "Varón" : "Mujer");
                dgvLista.Rows.Add(contacto.id_contacto, contacto.nombre_completo, contacto.telefono, gender, contacto.detalle);
            }
            SetColumnWidths();
        }
        private void SetColumnWidths()
        {
            dgvLista.Columns["ID"].Width = 40;
            dgvLista.Columns["NombreCompleto"].Width = 150;
            dgvLista.Columns["Telefono"].Width = 70;
            dgvLista.Columns["Genero"].Width = 50;
            dgvLista.Columns["Detalle"].Width = 200;
        }
    }
}
