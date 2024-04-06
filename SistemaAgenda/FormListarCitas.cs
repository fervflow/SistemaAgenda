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
    public partial class FormListarCitas : Form
    {
        private readonly int current_user_id;
        private readonly CitaDAO citaDAO;
        public FormListarCitas(int current_user_id)
        {
            InitializeComponent();
            this.current_user_id = current_user_id;
            citaDAO = new CitaDAO();
            FillCitasList();
        }

        private void FillCitasList()
        {
            List<Cita> citas = citaDAO.listaCitas(current_user_id);

            dgvListaCitas.Rows.Clear();
            dgvListaCitas.Columns.Clear();

            dgvListaCitas.Columns.Add("id_cita", "ID");
            dgvListaCitas.Columns.Add("fecha_hora", "Fecha y hora");
            dgvListaCitas.Columns.Add("contacto_cita", "Contacto");
            dgvListaCitas.Columns.Add("motivo", "Motivo");

            foreach (Cita cita in citas)
            {
                dgvListaCitas.Rows.Add(cita.id_cita, cita.fecha_hora, cita.contacto, cita.motivo);
            }
            SetColumnWidths();
        }
        private void SetColumnWidths()
        {
            dgvListaCitas.Columns["id_cita"].Width = 40;
            dgvListaCitas.Columns["fecha_hora"].Width = 150;
            dgvListaCitas.Columns["contacto_cita"].Width = 220;
            dgvListaCitas.Columns["motivo"].Width = 150;
        }
        private void FormListarCitas_Load(object sender, EventArgs e)
        {

        }
    }
}
