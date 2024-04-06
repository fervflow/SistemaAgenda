namespace SistemaAgenda
{
    partial class FormAgenda
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
            this.btCrearContacto = new System.Windows.Forms.Button();
            this.btListarContactos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCrearCita = new System.Windows.Forms.Button();
            this.btListarCitas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCrearContacto
            // 
            this.btCrearContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCrearContacto.Location = new System.Drawing.Point(11, 49);
            this.btCrearContacto.Name = "btCrearContacto";
            this.btCrearContacto.Size = new System.Drawing.Size(173, 96);
            this.btCrearContacto.TabIndex = 0;
            this.btCrearContacto.Text = "REGISTRAR NUEVO CONTACTO";
            this.btCrearContacto.UseVisualStyleBackColor = true;
            this.btCrearContacto.Click += new System.EventHandler(this.btCrearContacto_Click);
            // 
            // btListarContactos
            // 
            this.btListarContactos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarContactos.Location = new System.Drawing.Point(190, 49);
            this.btListarContactos.Name = "btListarContactos";
            this.btListarContactos.Size = new System.Drawing.Size(173, 96);
            this.btListarContactos.TabIndex = 1;
            this.btListarContactos.Text = "VER LISTA DE CONTACTOS";
            this.btListarContactos.UseVisualStyleBackColor = true;
            this.btListarContactos.Click += new System.EventHandler(this.btListarContactos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "CONTACTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "CITAS";
            // 
            // btCrearCita
            // 
            this.btCrearCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCrearCita.Location = new System.Drawing.Point(11, 191);
            this.btCrearCita.Name = "btCrearCita";
            this.btCrearCita.Size = new System.Drawing.Size(173, 96);
            this.btCrearCita.TabIndex = 6;
            this.btCrearCita.Text = "REGISTRAR UNA CITA";
            this.btCrearCita.UseVisualStyleBackColor = true;
            this.btCrearCita.Click += new System.EventHandler(this.btCrearCita_Click);
            // 
            // btListarCitas
            // 
            this.btListarCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarCitas.Location = new System.Drawing.Point(190, 191);
            this.btListarCitas.Name = "btListarCitas";
            this.btListarCitas.Size = new System.Drawing.Size(173, 96);
            this.btListarCitas.TabIndex = 7;
            this.btListarCitas.Text = "VER CITAS REGISTRADAS";
            this.btListarCitas.UseVisualStyleBackColor = true;
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 324);
            this.Controls.Add(this.btListarCitas);
            this.Controls.Add(this.btCrearCita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btListarContactos);
            this.Controls.Add(this.btCrearContacto);
            this.Name = "FormAgenda";
            this.Text = "FormAgenda";
            this.Load += new System.EventHandler(this.FormAgenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCrearContacto;
        private System.Windows.Forms.Button btListarContactos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCrearCita;
        private System.Windows.Forms.Button btListarCitas;
    }
}