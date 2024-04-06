namespace SistemaAgenda
{
    partial class FormCrearContacto
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
            this.lbNombreCompleto = new System.Windows.Forms.Label();
            this.tbNombreCompleto = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.rbVaron = new System.Windows.Forms.RadioButton();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.tbDetalle = new System.Windows.Forms.TextBox();
            this.lbDetalle = new System.Windows.Forms.Label();
            this.btRegistrarContacto = new System.Windows.Forms.Button();
            this.gbGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNombreCompleto
            // 
            this.lbNombreCompleto.AutoSize = true;
            this.lbNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreCompleto.Location = new System.Drawing.Point(12, 18);
            this.lbNombreCompleto.Name = "lbNombreCompleto";
            this.lbNombreCompleto.Size = new System.Drawing.Size(125, 17);
            this.lbNombreCompleto.TabIndex = 0;
            this.lbNombreCompleto.Text = "Nombre Completo:";
            // 
            // tbNombreCompleto
            // 
            this.tbNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreCompleto.Location = new System.Drawing.Point(12, 38);
            this.tbNombreCompleto.MaxLength = 50;
            this.tbNombreCompleto.Name = "tbNombreCompleto";
            this.tbNombreCompleto.Size = new System.Drawing.Size(315, 23);
            this.tbNombreCompleto.TabIndex = 1;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(12, 154);
            this.tbTelefono.MaxLength = 50;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(205, 23);
            this.tbTelefono.TabIndex = 3;
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.Location = new System.Drawing.Point(12, 134);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(68, 17);
            this.lbTelefono.TabIndex = 2;
            this.lbTelefono.Text = "Telefono:";
            // 
            // rbVaron
            // 
            this.rbVaron.AutoSize = true;
            this.rbVaron.Location = new System.Drawing.Point(10, 18);
            this.rbVaron.Name = "rbVaron";
            this.rbVaron.Size = new System.Drawing.Size(65, 22);
            this.rbVaron.TabIndex = 7;
            this.rbVaron.TabStop = true;
            this.rbVaron.Text = "Varón";
            this.rbVaron.UseVisualStyleBackColor = true;
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Location = new System.Drawing.Point(101, 18);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(63, 22);
            this.rbMujer.TabIndex = 8;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.rbVaron);
            this.gbGenero.Controls.Add(this.rbMujer);
            this.gbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGenero.Location = new System.Drawing.Point(12, 74);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(177, 48);
            this.gbGenero.TabIndex = 9;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Género";
            // 
            // tbDetalle
            // 
            this.tbDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDetalle.Location = new System.Drawing.Point(12, 209);
            this.tbDetalle.MaxLength = 150;
            this.tbDetalle.Multiline = true;
            this.tbDetalle.Name = "tbDetalle";
            this.tbDetalle.Size = new System.Drawing.Size(313, 58);
            this.tbDetalle.TabIndex = 11;
            // 
            // lbDetalle
            // 
            this.lbDetalle.AutoSize = true;
            this.lbDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetalle.Location = new System.Drawing.Point(12, 189);
            this.lbDetalle.Name = "lbDetalle";
            this.lbDetalle.Size = new System.Drawing.Size(56, 17);
            this.lbDetalle.TabIndex = 10;
            this.lbDetalle.Text = "Detalle:";
            // 
            // btRegistrarContacto
            // 
            this.btRegistrarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarContacto.Location = new System.Drawing.Point(12, 285);
            this.btRegistrarContacto.Name = "btRegistrarContacto";
            this.btRegistrarContacto.Size = new System.Drawing.Size(313, 34);
            this.btRegistrarContacto.TabIndex = 12;
            this.btRegistrarContacto.Text = "Registrar Contacto";
            this.btRegistrarContacto.UseVisualStyleBackColor = true;
            this.btRegistrarContacto.Click += new System.EventHandler(this.btRegistrarContacto_Click);
            // 
            // FormCrearContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 331);
            this.Controls.Add(this.btRegistrarContacto);
            this.Controls.Add(this.tbDetalle);
            this.Controls.Add(this.lbDetalle);
            this.Controls.Add(this.gbGenero);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.tbNombreCompleto);
            this.Controls.Add(this.lbNombreCompleto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCrearContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Contacto";
            this.Load += new System.EventHandler(this.FormCrearContacto_Load);
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombreCompleto;
        private System.Windows.Forms.TextBox tbNombreCompleto;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.RadioButton rbVaron;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.TextBox tbDetalle;
        private System.Windows.Forms.Label lbDetalle;
        private System.Windows.Forms.Button btRegistrarContacto;
    }
}