namespace SistemaAgenda
{
    partial class FormListaContactos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.id_contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero_contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_contacto,
            this.nombre_completo,
            this.telefono,
            this.genero_contacto,
            this.detalle});
            this.dgvLista.Location = new System.Drawing.Point(12, 12);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.Size = new System.Drawing.Size(544, 385);
            this.dgvLista.TabIndex = 0;
            // 
            // id_contacto
            // 
            this.id_contacto.Frozen = true;
            this.id_contacto.HeaderText = "id_contacto";
            this.id_contacto.Name = "id_contacto";
            this.id_contacto.ReadOnly = true;
            this.id_contacto.Width = 30;
            // 
            // nombre_completo
            // 
            this.nombre_completo.Frozen = true;
            this.nombre_completo.HeaderText = "Nombre Comlpleto";
            this.nombre_completo.Name = "nombre_completo";
            this.nombre_completo.ReadOnly = true;
            this.nombre_completo.Width = 150;
            // 
            // telefono
            // 
            this.telefono.Frozen = true;
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // genero_contacto
            // 
            this.genero_contacto.Frozen = true;
            this.genero_contacto.HeaderText = "Género";
            this.genero_contacto.Name = "genero_contacto";
            this.genero_contacto.ReadOnly = true;
            this.genero_contacto.Width = 50;
            // 
            // detalle
            // 
            this.detalle.Frozen = true;
            this.detalle.HeaderText = "Detalle";
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.Width = 200;
            // 
            // FormListaContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 417);
            this.Controls.Add(this.dgvLista);
            this.Name = "FormListaContactos";
            this.Text = "Lista de Contactos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero_contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
    }
}