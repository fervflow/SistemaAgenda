namespace SistemaAgenda
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.mtbPin = new System.Windows.Forms.MaskedTextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lkbNuevaCuenta = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(52, 29);
            this.tbUsuario.MaxLength = 10;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(196, 26);
            this.tbUsuario.TabIndex = 0;
            // 
            // mtbPin
            // 
            this.mtbPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPin.Location = new System.Drawing.Point(148, 98);
            this.mtbPin.Mask = "0000";
            this.mtbPin.Name = "mtbPin";
            this.mtbPin.PasswordChar = '*';
            this.mtbPin.Size = new System.Drawing.Size(100, 24);
            this.mtbPin.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(100, 188);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(98, 34);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lkbNuevaCuenta
            // 
            this.lkbNuevaCuenta.AutoSize = true;
            this.lkbNuevaCuenta.Location = new System.Drawing.Point(66, 156);
            this.lkbNuevaCuenta.Name = "lkbNuevaCuenta";
            this.lkbNuevaCuenta.Size = new System.Drawing.Size(164, 13);
            this.lkbNuevaCuenta.TabIndex = 3;
            this.lkbNuevaCuenta.TabStop = true;
            this.lkbNuevaCuenta.Text = "¿No tienes cuenta? Haz clic aqui";
            this.lkbNuevaCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbNuevaCuenta_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PIN";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 257);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lkbNuevaCuenta);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.mtbPin);
            this.Controls.Add(this.tbUsuario);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.MaskedTextBox mtbPin;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.LinkLabel lkbNuevaCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

