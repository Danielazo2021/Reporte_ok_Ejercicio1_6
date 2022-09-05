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
    public partial class Reporte1 : Form
    {
        public Reporte1()
        {
            InitializeComponent();
        }

        private void Reporte1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.camiones' Puede moverla o quitarla según sea necesario.
            this.camionesTableAdapter.Fill(this.DataSet1.camiones);

            this.reportViewer1.RefreshReport();
        }
    }
}
