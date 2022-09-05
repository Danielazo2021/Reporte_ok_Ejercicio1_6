namespace Reportes_Ejercicio_1_6
{
    partial class Form1
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
            this.btnDarDeBajaCamion = new System.Windows.Forms.Button();
            this.btnAdicionarCarga = new System.Windows.Forms.Button();
            this.btnAgregarCarga = new System.Windows.Forms.Button();
            this.cboTipoCarga = new System.Windows.Forms.ComboBox();
            this.txtPesoMaximo = new System.Windows.Forms.TextBox();
            this.txtPesoCarga = new System.Windows.Forms.TextBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblEstadoCamion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPesoCarga = new System.Windows.Forms.Label();
            this.lblTipoCarga = new System.Windows.Forms.Label();
            this.lblPesoMaximo = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.btnReporte1 = new System.Windows.Forms.Button();
            this.dgvCamiones = new System.Windows.Forms.DataGridView();
            this.accActualizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.accEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnReport33 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamiones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDarDeBajaCamion
            // 
            this.btnDarDeBajaCamion.BackColor = System.Drawing.Color.Red;
            this.btnDarDeBajaCamion.ForeColor = System.Drawing.Color.White;
            this.btnDarDeBajaCamion.Location = new System.Drawing.Point(861, 28);
            this.btnDarDeBajaCamion.Name = "btnDarDeBajaCamion";
            this.btnDarDeBajaCamion.Size = new System.Drawing.Size(101, 73);
            this.btnDarDeBajaCamion.TabIndex = 32;
            this.btnDarDeBajaCamion.Text = "DAR DE BAJA CAMION";
            this.btnDarDeBajaCamion.UseVisualStyleBackColor = false;
            this.btnDarDeBajaCamion.Click += new System.EventHandler(this.btnDarDeBajaCamion_Click_1);
            // 
            // btnAdicionarCarga
            // 
            this.btnAdicionarCarga.BackColor = System.Drawing.Color.Olive;
            this.btnAdicionarCarga.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnAdicionarCarga.FlatAppearance.BorderSize = 10;
            this.btnAdicionarCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarCarga.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAdicionarCarga.Location = new System.Drawing.Point(749, 28);
            this.btnAdicionarCarga.Name = "btnAdicionarCarga";
            this.btnAdicionarCarga.Size = new System.Drawing.Size(97, 78);
            this.btnAdicionarCarga.TabIndex = 31;
            this.btnAdicionarCarga.Text = "Agregar Carga a camion existente";
            this.btnAdicionarCarga.UseVisualStyleBackColor = false;
            // 
            // btnAgregarCarga
            // 
            this.btnAgregarCarga.BackColor = System.Drawing.Color.LawnGreen;
            this.btnAgregarCarga.Location = new System.Drawing.Point(643, 33);
            this.btnAgregarCarga.Name = "btnAgregarCarga";
            this.btnAgregarCarga.Size = new System.Drawing.Size(85, 68);
            this.btnAgregarCarga.TabIndex = 30;
            this.btnAgregarCarga.Text = "Agregar Carga a camion Nuevo";
            this.btnAgregarCarga.UseVisualStyleBackColor = false;
            this.btnAgregarCarga.Click += new System.EventHandler(this.btnAgregarCarga_Click_1);
            // 
            // cboTipoCarga
            // 
            this.cboTipoCarga.FormattingEnabled = true;
            this.cboTipoCarga.Location = new System.Drawing.Point(482, 38);
            this.cboTipoCarga.Name = "cboTipoCarga";
            this.cboTipoCarga.Size = new System.Drawing.Size(121, 21);
            this.cboTipoCarga.TabIndex = 29;
            // 
            // txtPesoMaximo
            // 
            this.txtPesoMaximo.Location = new System.Drawing.Point(187, 72);
            this.txtPesoMaximo.Name = "txtPesoMaximo";
            this.txtPesoMaximo.Size = new System.Drawing.Size(100, 20);
            this.txtPesoMaximo.TabIndex = 28;
            // 
            // txtPesoCarga
            // 
            this.txtPesoCarga.Location = new System.Drawing.Point(482, 75);
            this.txtPesoCarga.Name = "txtPesoCarga";
            this.txtPesoCarga.Size = new System.Drawing.Size(100, 20);
            this.txtPesoCarga.TabIndex = 27;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(187, 46);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 20);
            this.txtPatente.TabIndex = 26;
            // 
            // lblEstadoCamion
            // 
            this.lblEstadoCamion.AutoSize = true;
            this.lblEstadoCamion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblEstadoCamion.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEstadoCamion.Location = new System.Drawing.Point(649, 12);
            this.lblEstadoCamion.Name = "lblEstadoCamion";
            this.lblEstadoCamion.Size = new System.Drawing.Size(28, 17);
            this.lblEstadoCamion.TabIndex = 25;
            this.lblEstadoCamion.Text = "\"\"\"\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(485, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Estado del Camion";
            // 
            // lblPesoCarga
            // 
            this.lblPesoCarga.AutoSize = true;
            this.lblPesoCarga.Location = new System.Drawing.Point(375, 78);
            this.lblPesoCarga.Name = "lblPesoCarga";
            this.lblPesoCarga.Size = new System.Drawing.Size(88, 13);
            this.lblPesoCarga.TabIndex = 23;
            this.lblPesoCarga.Text = "Peso de la Carga";
            // 
            // lblTipoCarga
            // 
            this.lblTipoCarga.AutoSize = true;
            this.lblTipoCarga.Location = new System.Drawing.Point(375, 46);
            this.lblTipoCarga.Name = "lblTipoCarga";
            this.lblTipoCarga.Size = new System.Drawing.Size(73, 13);
            this.lblTipoCarga.TabIndex = 22;
            this.lblTipoCarga.Text = "Tipo de carga";
            // 
            // lblPesoMaximo
            // 
            this.lblPesoMaximo.AutoSize = true;
            this.lblPesoMaximo.Location = new System.Drawing.Point(80, 79);
            this.lblPesoMaximo.Name = "lblPesoMaximo";
            this.lblPesoMaximo.Size = new System.Drawing.Size(70, 13);
            this.lblPesoMaximo.TabIndex = 21;
            this.lblPesoMaximo.Text = "Peso Máximo";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(80, 46);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(44, 13);
            this.lblPatente.TabIndex = 20;
            this.lblPatente.Text = "Patente";
            // 
            // btnReporte1
            // 
            this.btnReporte1.BackColor = System.Drawing.Color.Blue;
            this.btnReporte1.ForeColor = System.Drawing.Color.White;
            this.btnReporte1.Location = new System.Drawing.Point(842, 158);
            this.btnReporte1.Name = "btnReporte1";
            this.btnReporte1.Size = new System.Drawing.Size(76, 45);
            this.btnReporte1.TabIndex = 33;
            this.btnReporte1.Text = "REPORTE Simple";
            this.btnReporte1.UseVisualStyleBackColor = false;
            this.btnReporte1.Click += new System.EventHandler(this.btnReporte1_Click_1);
            // 
            // dgvCamiones
            // 
            this.dgvCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accActualizar,
            this.accEliminar});
            this.dgvCamiones.Location = new System.Drawing.Point(44, 141);
            this.dgvCamiones.Name = "dgvCamiones";
            this.dgvCamiones.Size = new System.Drawing.Size(766, 205);
            this.dgvCamiones.TabIndex = 34;
            // 
            // accActualizar
            // 
            this.accActualizar.HeaderText = "Actualizar";
            this.accActualizar.Name = "accActualizar";
            this.accActualizar.Text = "ACTUALIZAR";
            this.accActualizar.UseColumnTextForButtonValue = true;
            // 
            // accEliminar
            // 
            this.accEliminar.HeaderText = "Eliminar";
            this.accEliminar.Name = "accEliminar";
            this.accEliminar.Text = "Eliminar";
            this.accEliminar.UseColumnTextForButtonValue = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(730, 375);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 42);
            this.btnSalir.TabIndex = 39;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(603, 375);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 42);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(405, 375);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(99, 42);
            this.btnGrabar.TabIndex = 37;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.Location = new System.Drawing.Point(219, 375);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(89, 34);
            this.btnActualizar.TabIndex = 36;
            this.btnActualizar.Text = "Actualizar Grilla";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(82, 375);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(83, 42);
            this.btnNuevo.TabIndex = 35;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnReport33
            // 
            this.btnReport33.BackColor = System.Drawing.Color.Purple;
            this.btnReport33.ForeColor = System.Drawing.Color.White;
            this.btnReport33.Location = new System.Drawing.Point(842, 222);
            this.btnReport33.Name = "btnReport33";
            this.btnReport33.Size = new System.Drawing.Size(76, 60);
            this.btnReport33.TabIndex = 41;
            this.btnReport33.Text = "REPORTE Camiones y Cargas";
            this.btnReport33.UseVisualStyleBackColor = false;
            this.btnReport33.Click += new System.EventHandler(this.btnReport33_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 450);
            this.Controls.Add(this.btnReport33);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvCamiones);
            this.Controls.Add(this.btnReporte1);
            this.Controls.Add(this.btnDarDeBajaCamion);
            this.Controls.Add(this.btnAdicionarCarga);
            this.Controls.Add(this.btnAgregarCarga);
            this.Controls.Add(this.cboTipoCarga);
            this.Controls.Add(this.txtPesoMaximo);
            this.Controls.Add(this.txtPesoCarga);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.lblEstadoCamion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPesoCarga);
            this.Controls.Add(this.lblTipoCarga);
            this.Controls.Add(this.lblPesoMaximo);
            this.Controls.Add(this.lblPatente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDarDeBajaCamion;
        private System.Windows.Forms.Button btnAdicionarCarga;
        private System.Windows.Forms.Button btnAgregarCarga;
        private System.Windows.Forms.ComboBox cboTipoCarga;
        private System.Windows.Forms.TextBox txtPesoMaximo;
        private System.Windows.Forms.TextBox txtPesoCarga;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblEstadoCamion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPesoCarga;
        private System.Windows.Forms.Label lblTipoCarga;
        private System.Windows.Forms.Label lblPesoMaximo;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Button btnReporte1;
        private System.Windows.Forms.DataGridView dgvCamiones;
        private System.Windows.Forms.DataGridViewButtonColumn accActualizar;
        private System.Windows.Forms.DataGridViewButtonColumn accEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnReport33;
    }
}

