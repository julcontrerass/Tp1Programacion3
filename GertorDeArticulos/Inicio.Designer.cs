namespace GertorDeArticulos
{
    partial class Inicio
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
            this.lblTituloInicio = new System.Windows.Forms.Label();
            this.btnIrInicio = new System.Windows.Forms.Button();
            this.lbSubtituloInicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloInicio
            // 
            this.lblTituloInicio.AutoSize = true;
            this.lblTituloInicio.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInicio.Location = new System.Drawing.Point(337, 183);
            this.lblTituloInicio.Name = "lblTituloInicio";
            this.lblTituloInicio.Size = new System.Drawing.Size(279, 36);
            this.lblTituloInicio.TabIndex = 0;
            this.lblTituloInicio.Text = "Gestor De Articulos";
            this.lblTituloInicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnIrInicio
            // 
            this.btnIrInicio.Location = new System.Drawing.Point(437, 266);
            this.btnIrInicio.Name = "btnIrInicio";
            this.btnIrInicio.Size = new System.Drawing.Size(75, 23);
            this.btnIrInicio.TabIndex = 1;
            this.btnIrInicio.Text = "Ingresar";
            this.btnIrInicio.UseVisualStyleBackColor = true;
            this.btnIrInicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbSubtituloInicio
            // 
            this.lbSubtituloInicio.AutoSize = true;
            this.lbSubtituloInicio.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtituloInicio.Location = new System.Drawing.Point(363, 229);
            this.lbSubtituloInicio.Name = "lbSubtituloInicio";
            this.lbSubtituloInicio.Size = new System.Drawing.Size(226, 25);
            this.lbSubtituloInicio.TabIndex = 2;
            this.lbSubtituloInicio.Text = "Gestiona tus productos";
            this.lbSubtituloInicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 542);
            this.Controls.Add(this.lbSubtituloInicio);
            this.Controls.Add(this.btnIrInicio);
            this.Controls.Add(this.lblTituloInicio);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloInicio;
        private System.Windows.Forms.Button btnIrInicio;
        private System.Windows.Forms.Label lbSubtituloInicio;
    }
}

