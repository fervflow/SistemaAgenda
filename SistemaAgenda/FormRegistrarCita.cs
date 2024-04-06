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
    public partial class FormRegistrarCita : Form
    {
        private int current_user_id;
        private ContactoDAO contactoDAO;
        private CitaDAO citaDAO;
        private List<Contacto> contactos;
        public FormRegistrarCita(int id_user)
        {
            InitializeComponent();
            current_user_id = id_user;
            contactoDAO = new ContactoDAO();
            citaDAO = new CitaDAO();
            contactos = contactoDAO.listaContactos(id_user);
            FillComboBox();
        }

        private void FormRegistrarCita_Load(object sender, EventArgs e)
        {
            for (int hour = 0; hour <= 23; hour++)
            {
                cbxHoras.Items.Add(hour.ToString("00"));
            }
            for (int minute = 0; minute <= 59; minute++)
            {
                cbxMinutos.Items.Add(minute.ToString("00"));
            }
            cbxHoras.SelectedIndex = cbxMinutos.SelectedIndex = 0;
        }
        private void FillComboBox()
        {
            foreach (Contacto contacto in contactos)
            {
                cbxContactos.Items.Add(contacto.telefono + " " + contacto.nombre_completo);
            }
        }
        private void btRegistrarCita_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cbxContactos.Text))
            {
                MessageBox.Show("Por favor seleccione un contacto.");
            }
            else if (String.IsNullOrWhiteSpace(tbMotivo.Text))
            {
                MessageBox.Show("Por favor escriba un motivo.");
            }
            else
            {
                string horas = cbxHoras.SelectedItem?.ToString();
                string minutos = cbxMinutos.SelectedItem?.ToString();

                if (horas != null && minutos != null)
                {
                    string horaCita = $"{horas}:{minutos}";
                    int temp_id_contacto = cbxContactos.SelectedIndex;
                    Contacto c = new Contacto();
                    c = contactos.ElementAt(temp_id_contacto);
                    
                    string fechaHora = dtpFechaHora.Value.ToString("yyyy-MM-dd") + " " + horaCita;
                    string motivo = tbMotivo.Text;
                    int result = citaDAO.registrarCita(current_user_id, c, fechaHora, motivo);

                    if (result == 1)
                    {
                        MessageBox.Show("Cita registrada exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar la cita.");
                    }
                }
                else
                {
                    MessageBox.Show("por favor establezca la hora de su cita.");
                }
            }
        }
    }
}
