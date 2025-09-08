namespace service
{
    partial class frmArticulos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTituloArticulos = new System.Windows.Forms.Label();
            this.dgvTablaArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtbBuscador = new System.Windows.Forms.TextBox();
            this.lblBuscador = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cbFiltroMarca = new System.Windows.Forms.ComboBox();
            this.cbFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.lblMarcaFiltro = new System.Windows.Forms.Label();
            this.lblCategoriaFiltro = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloArticulos
            // 
            this.lblTituloArticulos.AutoSize = true;
            this.lblTituloArticulos.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloArticulos.Location = new System.Drawing.Point(293, 9);
            this.lblTituloArticulos.Name = "lblTituloArticulos";
            this.lblTituloArticulos.Size = new System.Drawing.Size(229, 42);
            this.lblTituloArticulos.TabIndex = 0;
            this.lblTituloArticulos.Text = "Tus Articulos";
            // 
            // dgvTablaArticulos
            // 
            this.dgvTablaArticulos.AllowUserToAddRows = false;
            this.dgvTablaArticulos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTablaArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTablaArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTablaArticulos.BackgroundColor = System.Drawing.Color.White;
            this.dgvTablaArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTablaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaArticulos.Location = new System.Drawing.Point(183, 105);
            this.dgvTablaArticulos.MultiSelect = false;
            this.dgvTablaArticulos.Name = "dgvTablaArticulos";
            this.dgvTablaArticulos.ReadOnly = true;
            this.dgvTablaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablaArticulos.Size = new System.Drawing.Size(597, 190);
            this.dgvTablaArticulos.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(253, 362);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(397, 362);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(546, 361);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtbBuscador
            // 
            this.txtbBuscador.Location = new System.Drawing.Point(372, 69);
            this.txtbBuscador.Name = "txtbBuscador";
            this.txtbBuscador.Size = new System.Drawing.Size(100, 20);
            this.txtbBuscador.TabIndex = 5;
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscador.Location = new System.Drawing.Point(316, 68);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(53, 19);
            this.lblBuscador.TabIndex = 6;
            this.lblBuscador.Text = "Buscar:";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(12, 105);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(49, 21);
            this.lblFiltro.TabIndex = 7;
            this.lblFiltro.Text = "Filtro";
            // 
            // cbFiltroMarca
            // 
            this.cbFiltroMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroMarca.FormattingEnabled = true;
            this.cbFiltroMarca.Items.AddRange(new object[] {
            "Ninguno"});
            this.cbFiltroMarca.Location = new System.Drawing.Point(16, 157);
            this.cbFiltroMarca.Name = "cbFiltroMarca";
            this.cbFiltroMarca.Size = new System.Drawing.Size(121, 21);
            this.cbFiltroMarca.TabIndex = 8;
            this.cbFiltroMarca.SelectedIndexChanged += new System.EventHandler(this.cbFiltroMarca_SelectedIndexChanged);
            // 
            // cbFiltroCategoria
            // 
            this.cbFiltroCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroCategoria.FormattingEnabled = true;
            this.cbFiltroCategoria.Location = new System.Drawing.Point(16, 204);
            this.cbFiltroCategoria.Name = "cbFiltroCategoria";
            this.cbFiltroCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbFiltroCategoria.TabIndex = 9;
            this.cbFiltroCategoria.SelectedIndexChanged += new System.EventHandler(this.cbFiltroCategoria_SelectedIndexChanged);
            // 
            // lblMarcaFiltro
            // 
            this.lblMarcaFiltro.AutoSize = true;
            this.lblMarcaFiltro.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaFiltro.Location = new System.Drawing.Point(13, 137);
            this.lblMarcaFiltro.Name = "lblMarcaFiltro";
            this.lblMarcaFiltro.Size = new System.Drawing.Size(45, 17);
            this.lblMarcaFiltro.TabIndex = 10;
            this.lblMarcaFiltro.Text = "Marca";
            // 
            // lblCategoriaFiltro
            // 
            this.lblCategoriaFiltro.AutoSize = true;
            this.lblCategoriaFiltro.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaFiltro.Location = new System.Drawing.Point(13, 188);
            this.lblCategoriaFiltro.Name = "lblCategoriaFiltro";
            this.lblCategoriaFiltro.Size = new System.Drawing.Size(57, 16);
            this.lblCategoriaFiltro.TabIndex = 11;
            this.lblCategoriaFiltro.Text = "Categoria";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(478, 68);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 516);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCategoriaFiltro);
            this.Controls.Add(this.lblMarcaFiltro);
            this.Controls.Add(this.cbFiltroCategoria);
            this.Controls.Add(this.cbFiltroMarca);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblBuscador);
            this.Controls.Add(this.txtbBuscador);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvTablaArticulos);
            this.Controls.Add(this.lblTituloArticulos);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloArticulos;
        private System.Windows.Forms.DataGridView dgvTablaArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtbBuscador;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cbFiltroMarca;
        private System.Windows.Forms.ComboBox cbFiltroCategoria;
        private System.Windows.Forms.Label lblMarcaFiltro;
        private System.Windows.Forms.Label lblCategoriaFiltro;
        private System.Windows.Forms.Button btnBuscar;
    }
}