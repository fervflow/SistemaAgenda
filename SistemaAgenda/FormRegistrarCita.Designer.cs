namespace SistemaAgenda
{
    partial class FormRegistrarCita
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
            this.lbFechaHora = new System.Windows.Forms.Label();
            this.lbContacto = new System.Windows.Forms.Label();
            this.dtpFechaHora = new System.Windows.Forms.DateTimePicker();
            this.cbxContactos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMotivo = new System.Windows.Forms.TextBox();
            this.btRegistrarCita = new System.Windows.Forms.Button();
            this.cbxHoras = new System.Windows.Forms.ComboBox();
            this.cbxMinutos = new System.Windows.Forms.ComboBox();
            this.lbSeparator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbFechaHora
            // 
            this.lbFechaHora.AutoSize = true;
            this.lbFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaHora.Location = new System.Drawing.Point(12, 18);
            this.lbFechaHora.Name = "lbFechaHora";
            this.lbFechaHora.Size = new System.Drawing.Size(114, 18);
            this.lbFechaHora.TabIndex = 0;
            this.lbFechaHora.Text = "Fecha y Hora:";
            // 
            // lbContacto
            // 
            this.lbContacto.AutoSize = true;
            this.lbContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContacto.Location = new System.Drawing.Point(44, 59);
            this.lbContacto.Name = "lbContacto";
            this.lbContacto.Size = new System.Drawing.Size(82, 18);
            this.lbContacto.TabIndex = 1;
            this.lbContacto.Text = "Contacto:";
            // 
            // dtpFechaHora
            // 
            this.dtpFechaHora.Location = new System.Drawing.Point(140, 16);
            this.dtpFechaHora.Name = "dtpFechaHora";
            this.dtpFechaHora.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHora.TabIndex = 2;
            // 
            // cbxContactos
            // 
            this.cbxContactos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxContactos.FormattingEnabled = true;
            this.cbxContactos.Location = new System.Drawing.Point(140, 56);
            this.cbxContactos.Name = "cbxContactos";
            this.cbxContactos.Size = new System.Drawing.Size(330, 21);
            this.cbxContactos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Motivo:";
            // 
            // tbMotivo
            // 
            this.tbMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMotivo.Location = new System.Drawing.Point(15, 120);
            this.tbMotivo.Multiline = true;
            this.tbMotivo.Name = "tbMotivo";
            this.tbMotivo.Size = new System.Drawing.Size(455, 48);
            this.tbMotivo.TabIndex = 5;
            // 
            // btRegistrarCita
            // 
            this.btRegistrarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarCita.Location = new System.Drawing.Point(124, 182);
            this.btRegistrarCita.Name = "btRegistrarCita";
            this.btRegistrarCita.Size = new System.Drawing.Size(248, 27);
            this.btRegistrarCita.TabIndex = 6;
            this.btRegistrarCita.Text = "Registrar Cita";
            this.btRegistrarCita.UseVisualStyleBackColor = true;
            this.btRegistrarCita.Click += new System.EventHandler(this.btRegistrarCita_Click);
            // 
            // cbxHoras
            // 
            this.cbxHoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHoras.FormattingEnabled = true;
            this.cbxHoras.Location = new System.Drawing.Point(346, 15);
            this.cbxHoras.Name = "cbxHoras";
            this.cbxHoras.Size = new System.Drawing.Size(55, 21);
            this.cbxHoras.TabIndex = 7;
            // 
            // cbxMinutos
            // 
            this.cbxMinutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMinutos.FormattingEnabled = true;
            this.cbxMinutos.Location = new System.Drawing.Point(416, 15);
            this.cbxMinutos.Name = "cbxMinutos";
            this.cbxMinutos.Size = new System.Drawing.Size(55, 21);
            this.cbxMinutos.TabIndex = 8;
            // 
            // lbSeparator
            // 
            this.lbSeparator.AutoSize = true;
            this.lbSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeparator.Location = new System.Drawing.Point(402, 15);
            this.lbSeparator.Margin = new System.Windows.Forms.Padding(0);
            this.lbSeparator.Name = "lbSeparator";
            this.lbSeparator.Size = new System.Drawing.Size(14, 20);
            this.lbSeparator.TabIndex = 9;
            this.lbSeparator.Text = ":";
            // 
            // FormRegistrarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 220);
            this.Controls.Add(this.lbSeparator);
            this.Controls.Add(this.cbxMinutos);
            this.Controls.Add(this.cbxHoras);
            this.Controls.Add(this.btRegistrarCita);
            this.Controls.Add(this.tbMotivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxContactos);
            this.Controls.Add(this.dtpFechaHora);
            this.Controls.Add(this.lbContacto);
            this.Controls.Add(this.lbFechaHora);
            this.Name = "FormRegistrarCita";
            this.Text = "Registrar una cita";
            this.Load += new System.EventHandler(this.FormRegistrarCita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFechaHora;
        private System.Windows.Forms.Label lbContacto;
        private System.Windows.Forms.DateTimePicker dtpFechaHora;
        private System.Windows.Forms.ComboBox cbxContactos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMotivo;
        private System.Windows.Forms.Button btRegistrarCita;
        private System.Windows.Forms.ComboBox cbxHoras;
        private System.Windows.Forms.ComboBox cbxMinutos;
        private System.Windows.Forms.Label lbSeparator;
    }
}