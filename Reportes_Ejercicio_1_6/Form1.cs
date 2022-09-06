using Reportes_Ejercicio_1_6.Datos;
using Reportes_Ejercicio_1_6.Dominio;
using Reportes_Ejercicio_1_6.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Reportes_Ejercicio_1_6
{
    public partial class Form1 : Form
    {
        Acceso_Datos oBD = new Acceso_Datos();
        List<DetalleCarga> Detalles = new List<DetalleCarga>();
        Camion CAM = new Camion();
        DetalleCarga OCarga;
        string accion = "nuevo";

        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDGV(dgvCamiones);
            CargarCombo("pa_cargarCombo");
            btnGrabar.Enabled = false;
            habilitarIngresarDatos(false);


        }

        private void habilitarIngresarDatos(bool v)
        {
            txtPatente.Enabled = v;
            txtPesoCarga.Enabled = v;
            txtPesoMaximo.Enabled = v;

        }

        private void CargarCombo(string pa)
        {
            DataTable tabla = oBD.consultarBD(pa);

            cboTipoCarga.DataSource = tabla;
            cboTipoCarga.ValueMember = tabla.Columns[0].ColumnName;
            cboTipoCarga.DisplayMember = tabla.Columns[1].ColumnName;
            cboTipoCarga.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarDGV(DataGridView dgvCamiones)
        {
            dgvCamiones.DataSource = oBD.consultarBD("pa_ConsultaCamiones"); // pa solo utilizado en el dgv. 
        }

       

        private void GrabarCarga()
        {
            /*Ocamion = new Camion();
            Ocamion.patente = txtPatente.Text;            
            Ocamion.estado = 1; // por defecto siempre que se cargue un camion va a estar disponible
                                // FALTARIA VER UN SWITCH PARA METER LOS ESTADOS CON UN SP TOTLIZADOR POR CARGA Y CAMION
                                // ya cree el sp para consultar los estados por patente falta vincularlo
            Ocamion.pesoMaximo = Convert.ToInt32(txtPesoMaximo.Text);

            */


            var tipo_carga = Convert.ToInt32(cboTipoCarga.SelectedValue);
            var pesoCarga = Convert.ToInt32(txtPesoCarga.Text);

            OCarga = new DetalleCarga(CAM, pesoCarga, tipo_carga);

            OCarga.patente = Convert.ToString(CAM.patente);
            OCarga.tipo_carga = tipo_carga;
            OCarga.peso = pesoCarga;


            if (accion == "nuevo")
            {
                if (oBD.GuardarMestro_Detalle("pa_cargarCamionNuevo", CAM, "pa_cargarCargaNueva", OCarga))
                {
                    MessageBox.Show("Carga registrada correctamente", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("ERROR. No se pudo registrar la carga", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
                if(accion == "actualizar") // ver el sp de actualizacion // cambiar maestro detalle
            {
                if (oBD.GuardarMestro_Detalle("[pa_modificarCamion]", CAM, "pa_ModificarCarga", OCarga))
                {
                    MessageBox.Show("Actualizacion registrada correctamente", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("ERROR. No se pudo Actualizar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }




        private void btnAgregarCarga_Click(object sender, EventArgs e)
        {

            if (cboTipoCarga.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar una carga!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtPesoCarga.Text == "" || Convert.ToInt32(txtPesoCarga.Text) <= 0)
            {
                MessageBox.Show("Debe ingresar el peso de la carga!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            string patente = (txtPatente.Text);
            int estado = 1;
            int pesoMaximo = Convert.ToInt32(txtPesoMaximo.Text);

            CAM = new Camion(patente, estado, pesoMaximo);

            int pesoCarga = Convert.ToInt32(txtPesoCarga.Text);
            int tipoCarga = Convert.ToInt32(cboTipoCarga.SelectedValue);

            DetalleCarga detalle = new DetalleCarga(CAM, pesoCarga, tipoCarga);

            CAM.AgregarDetalle(detalle);



            /// ver de meter en el dgv
            /*DataRowView item = (DataRowView)cboTipoCarga.SelectedItem;

            string patente = Convert.ToString(item.Row.ItemArray[2]);
            int estado = Convert.ToInt32(item.Row.ItemArray[3]);
            int pesoMaximo = Convert.ToInt32(item.Row.ItemArray[4]);


            Camion CAM = new Camion(patente, estado, pesoMaximo);  
            
            int pesoCarga = Convert.ToInt32(txtPesoCarga.Text);
            int tipoCarga = Convert.ToInt32(cboTipoCarga.SelectedValue);

            DetalleCarga detalle = new DetalleCarga(CAM, pesoCarga, tipoCarga);

            Ocamion.AgregarDetalle(detalle);

            //dgvCamiones.Rows.Add(new object[] { item.Row.ItemArray[0], item.Row.ItemArray[1], item.Row.ItemArray[2], nudCantidad.Text });
            */




        }

       

        private void dgvCamiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvCamiones.CurrentCell.ColumnIndex == 1)
            {
                CAM.QuitarDetalle(dgvCamiones.CurrentRow.Index);
                dgvCamiones.Rows.Remove(dgvCamiones.CurrentRow);

            }




        }

       
               
        private void btnDarDeBajaCamion_Click_1(object sender, EventArgs e)
        {
            string patente = txtPatente.Text;
            txtPatente.Enabled = true;
            if(patente=="")
            {
                MessageBox.Show("Debe ingresar la patente!!");
                    return;
            }
            if (MessageBox.Show("Seguro que desea dar de baja el camion: " + patente,
                "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)

            //respuesta = (MessageBox.Show("esta seguro que desea dar de baja el camion:  " + patente, "Alerta", MessageBoxButtons.YesNoCancel).ToString());
            //if(respuesta == yes)
            {
                if ((oBD.actualizarBD("pa_ActualizarEstadoCamion", patente)))
                {
                    MessageBox.Show("El camion:  " + patente + " se dio de baja correctamente ", "Alerta", MessageBoxButtons.OK);
                    CargarDGV(dgvCamiones);
                }
                else
                {
                    MessageBox.Show("El camion:  " + patente + " NO SE  dio de baja correctamente ", "Alerta", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("El camion:  " + patente + " NO SE  dio de baja correctamente ", "Alerta", MessageBoxButtons.OK);
            }
        }

        

        private void btnGrabar_Click_1(object sender, EventArgs e)
        {
            btnAgregarCarga_Click(sender, e);

            if (txtPatente.Text == "")
            {
                MessageBox.Show("Debe ingresar una patente");
                return;
            }
            if (txtPesoMaximo.Text == "")
            {
                MessageBox.Show("Debe ingresar el peso máximo");
                return;
            }

            GrabarCarga();
            CargarDGV(dgvCamiones);
            btnGrabar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            habilitarIngresarDatos(false);
            limpiarCampos();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de abandonar la aplicación ?",
               "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            
        }

        private void limpiarCampos()
        {
            txtPatente.Text = "";
            txtPesoCarga.Text = "";
            txtPesoMaximo.Text = "";
            cboTipoCarga.SelectedIndex = -1;
        }

        private void btnAgregarCarga_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReporte1_Click_1(object sender, EventArgs e)
        {
            new Reporte1().ShowDialog();

        }

       

        private void btnReport33_Click(object sender, EventArgs e)
        {
            new Reporte33().ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            accion = "nuevo";
            btnGrabar.Enabled = true;
            btnNuevo.Enabled = false;
            habilitarIngresarDatos(true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            accion = "actualizar";
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnGrabar.Enabled = true;
            habilitarIngresarDatos(true);
        }
    }
}
