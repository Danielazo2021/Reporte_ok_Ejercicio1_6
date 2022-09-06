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
            this.cboTipoCarga = new System.Windows.Forms.ComboBox();
            this.txtPesoMaximo = new System.Windows.Forms.TextBox();
            this.txtPesoCarga = new System.Windows.Forms.TextBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblPesoCarga = new System.Windows.Forms.Label();
            this.lblTipoCarga = new System.Windows.Forms.Label();
            this.lblPesoMaximo = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.btnReporte1 = new System.Windows.Forms.Button();
            this.dgvCamiones = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnReport33 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamiones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDarDeBajaCamion
            // 
            this.btnDarDeBajaCamion.BackColor = System.Drawing.Color.Red;
            this.btnDarDeBajaCamion.ForeColor = System.Drawing.Color.White;
            this.btnDarDeBajaCamion.Location = new System.Drawing.Point(490, 15);
            this.btnDarDeBajaCamion.Name = "btnDarDeBajaCamion";
            this.btnDarDeBajaCamion.Size = new System.Drawing.Size(101, 73);
            this.btnDarDeBajaCamion.TabIndex = 32;
            this.btnDarDeBajaCamion.Text = "DAR DE BAJA CAMION";
            this.btnDarDeBajaCamion.UseVisualStyleBackColor = false;
            this.btnDarDeBajaCamion.Click += new System.EventHandler(this.btnDarDeBajaCamion_Click_1);
            // 
            // cboTipoCarga
            // 
            this.cboTipoCarga.FormattingEnabled = true;
            this.cboTipoCarga.Location = new System.Drawing.Point(363, 37);
            this.cboTipoCarga.Name = "cboTipoCarga";
            this.cboTipoCarga.Size = new System.Drawing.Size(121, 21);
            this.cboTipoCarga.TabIndex = 29;
            // 
            // txtPesoMaximo
            // 
            this.txtPesoMaximo.Location = new System.Drawing.Point(129, 68);
            this.txtPesoMaximo.Name = "txtPesoMaximo";
            this.txtPesoMaximo.Size = new System.Drawing.Size(100, 20);
            this.txtPesoMaximo.TabIndex = 28;
            // 
            // txtPesoCarga
            // 
            this.txtPesoCarga.Location = new System.Drawing.Point(363, 74);
            this.txtPesoCarga.Name = "txtPesoCarga";
            this.txtPesoCarga.Size = new System.Drawing.Size(100, 20);
            this.txtPesoCarga.TabIndex = 27;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(129, 42);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 20);
            this.txtPatente.TabIndex = 26;
            // 
            // lblPesoCarga
            // 
            this.lblPesoCarga.AutoSize = true;
            this.lblPesoCarga.Location = new System.Drawing.Point(256, 77);
            this.lblPesoCarga.Name = "lblPesoCarga";
            this.lblPesoCarga.Size = new System.Drawing.Size(88, 13);
            this.lblPesoCarga.TabIndex = 23;
            this.lblPesoCarga.Text = "Peso de la Carga";
            // 
            // lblTipoCarga
            // 
            this.lblTipoCarga.AutoSize = true;
            this.lblTipoCarga.Location = new System.Drawing.Point(256, 45);
            this.lblTipoCarga.Name = "lblTipoCarga";
            this.lblTipoCarga.Size = new System.Drawing.Size(73, 13);
            this.lblTipoCarga.TabIndex = 22;
            this.lblTipoCarga.Text = "Tipo de carga";
            // 
            // lblPesoMaximo
            // 
            this.lblPesoMaximo.AutoSize = true;
            this.lblPesoMaximo.Location = new System.Drawing.Point(22, 75);
            this.lblPesoMaximo.Name = "lblPesoMaximo";
            this.lblPesoMaximo.Size = new System.Drawing.Size(70, 13);
            this.lblPesoMaximo.TabIndex = 21;
            this.lblPesoMaximo.Text = "Peso Máximo";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(22, 42);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(44, 13);
            this.lblPatente.TabIndex = 20;
            this.lblPatente.Text = "Patente";
            // 
            // btnReporte1
            // 
            this.btnReporte1.BackColor = System.Drawing.Color.Blue;
            this.btnReporte1.ForeColor = System.Drawing.Color.White;
            this.btnReporte1.Location = new System.Drawing.Point(597, 20);
            this.btnReporte1.Name = "btnReporte1";
            this.btnReporte1.Size = new System.Drawing.Size(85, 62);
            this.btnReporte1.TabIndex = 33;
            this.btnReporte1.Text = "REPORTE Simple";
            this.btnReporte1.UseVisualStyleBackColor = false;
            this.btnReporte1.Click += new System.EventHandler(this.btnReporte1_Click_1);
            // 
            // dgvCamiones
            // 
            this.dgvCamiones.AllowUserToAddRows = false;
            this.dgvCamiones.AllowUserToDeleteRows = false;
            this.dgvCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCamiones.Location = new System.Drawing.Point(3, 16);
            this.dgvCamiones.Name = "dgvCamiones";
            this.dgvCamiones.ReadOnly = true;
            this.dgvCamiones.Size = new System.Drawing.Size(770, 234);
            this.dgvCamiones.TabIndex = 34;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(709, 385);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 42);
            this.btnSalir.TabIndex = 39;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(575, 385);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 42);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(395, 385);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(99, 42);
            this.btnGrabar.TabIndex = 37;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(70, 385);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(83, 42);
            this.btnNuevo.TabIndex = 35;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnReport33
            // 
            this.btnReport33.BackColor = System.Drawing.Color.Purple;
            this.btnReport33.ForeColor = System.Drawing.Color.White;
            this.btnReport33.Location = new System.Drawing.Point(709, 20);
            this.btnReport33.Name = "btnReport33";
            this.btnReport33.Size = new System.Drawing.Size(87, 63);
            this.btnReport33.TabIndex = 41;
            this.btnReport33.Text = "REPORTE Camiones y Cargas";
            this.btnReport33.UseVisualStyleBackColor = false;
            this.btnReport33.Click += new System.EventHandler(this.btnReport33_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCamiones);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 253);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(224, 385);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(83, 42);
            this.btnEditar.TabIndex = 43;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReport33);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnReporte1);
            this.Controls.Add(this.btnDarDeBajaCamion);
            this.Controls.Add(this.cboTipoCarga);
            this.Controls.Add(this.txtPesoMaximo);
            this.Controls.Add(this.txtPesoCarga);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.lblPesoCarga);
            this.Controls.Add(this.lblTipoCarga);
            this.Controls.Add(this.lblPesoMaximo);
            this.Controls.Add(this.lblPatente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamiones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDarDeBajaCamion;
        private System.Windows.Forms.ComboBox cboTipoCarga;
        private System.Windows.Forms.TextBox txtPesoMaximo;
        private System.Windows.Forms.TextBox txtPesoCarga;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblPesoCarga;
        private System.Windows.Forms.Label lblTipoCarga;
        private System.Windows.Forms.Label lblPesoMaximo;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Button btnReporte1;
        private System.Windows.Forms.DataGridView dgvCamiones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnReport33;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditar;
    }
}

