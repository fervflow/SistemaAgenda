namespace SistemaAgenda
{
    partial class FormListarCitas
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
            this.dgvListaCitas = new System.Windows.Forms.DataGridView();
            this.lbCitas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaCitas
            // 
            this.dgvListaCitas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCitas.Location = new System.Drawing.Point(11, 44);
            this.dgvListaCitas.Name = "dgvListaCitas";
            this.dgvListaCitas.Size = new System.Drawing.Size(512, 303);
            this.dgvListaCitas.TabIndex = 0;
            // 
            // lbCitas
            // 
            this.lbCitas.AutoSize = true;
            this.lbCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCitas.Location = new System.Drawing.Point(12, 15);
            this.lbCitas.Name = "lbCitas";
            this.lbCitas.Size = new System.Drawing.Size(141, 18);
            this.lbCitas.TabIndex = 1;
            this.lbCitas.Text = "Tus últimas citas:";
            // 
            // FormListarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.lbCitas);
            this.Controls.Add(this.dgvListaCitas);
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "FormListarCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de citas";
            this.Load += new System.EventHandler(this.FormListarCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaCitas;
        private System.Windows.Forms.Label lbCitas;
    }
}