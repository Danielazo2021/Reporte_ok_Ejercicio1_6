namespace Reportes_Ejercicio_1_6.Reportes
{
    partial class Reporte33
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet3 = new Reportes_Ejercicio_1_6.Reportes.DataSet3();
            this.pa_ReporteCamionesyCargasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pa_ReporteCamionesyCargasTableAdapter = new Reportes_Ejercicio_1_6.Reportes.DataSet3TableAdapters.pa_ReporteCamionesyCargasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pa_ReporteCamionesyCargasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet3";
            reportDataSource1.Value = this.pa_ReporteCamionesyCargasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reportes_Ejercicio_1_6.Reportes.Report33.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet3
            // 
            this.DataSet3.DataSetName = "DataSet3";
            this.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pa_ReporteCamionesyCargasBindingSource
            // 
            this.pa_ReporteCamionesyCargasBindingSource.DataMember = "pa_ReporteCamionesyCargas";
            this.pa_ReporteCamionesyCargasBindingSource.DataSource = this.DataSet3;
            // 
            // pa_ReporteCamionesyCargasTableAdapter
            // 
            this.pa_ReporteCamionesyCargasTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte33
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte33";
            this.Text = "Reporte33";
            this.Load += new System.EventHandler(this.Reporte33_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pa_ReporteCamionesyCargasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pa_ReporteCamionesyCargasBindingSource;
        private DataSet3 DataSet3;
        private DataSet3TableAdapters.pa_ReporteCamionesyCargasTableAdapter pa_ReporteCamionesyCargasTableAdapter;
    }
}