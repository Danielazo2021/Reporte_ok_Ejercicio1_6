using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes_Ejercicio_1_6.Reportes
{
    public partial class Reporte33 : Form
    {
        public Reporte33()
        {
            InitializeComponent();
        }

        private void Reporte33_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet3.pa_ReporteCamionesyCargas' Puede moverla o quitarla según sea necesario.
            this.pa_ReporteCamionesyCargasTableAdapter.Fill(this.DataSet3.pa_ReporteCamionesyCargas);

            this.reportViewer1.RefreshReport();
        }
    }
}
