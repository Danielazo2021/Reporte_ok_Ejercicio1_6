using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Reportes_Ejercicio_1_6.Dominio;
using Reportes_Ejercicio_1_6.Datos;



namespace Reportes_Ejercicio_1_6.Datos
{
    internal class Acceso_Datos
    {
        SqlConnection conexion = new SqlConnection(@"Data Source =laptop-sjp45n95; Initial Catalog = ejercicio_1_6_camiones; Integrated Security = True");
        SqlCommand comando = new SqlCommand();


        public DataTable consultarBD(string pa)
        {
            SqlCommand comando = new SqlCommand(pa, conexion);
            DataTable tabla = new DataTable();
            try
            {
                conexion.Open();
                comando.CommandType = CommandType.StoredProcedure;
                tabla.Load(comando.ExecuteReader());
                return tabla;

            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public void guardarMaestro(string pa, Camion Ocamion)
        {



            try
            {
                SqlCommand cmdMaestro = new SqlCommand(pa, conexion);
                conexion.Open();

                cmdMaestro.CommandType = CommandType.StoredProcedure;

                cmdMaestro.Parameters.AddWithValue("@Patente", Ocamion.patente);
                cmdMaestro.Parameters.AddWithValue("@Id_estado", Ocamion.estado);
                cmdMaestro.Parameters.AddWithValue("@PesoMaximo", Ocamion.pesoMaximo);

                cmdMaestro.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

        }





        public bool actualizarBD(string pa, string identificador)
        {
            bool confirmacion = true;
            SqlCommand comando = new SqlCommand(pa, conexion);


            ///
            try
            {
                conexion.Open();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@patente", identificador);
                comando.ExecuteNonQuery();



            }
            catch (SqlException)
            {
                confirmacion = false;

            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();

                }

            }
            return confirmacion;
        }








        internal bool GuardarMestro_Detalle(string pa_camion, Camion ocamion, string pa_carga, DetalleCarga oCarga)
        {
            bool confirmacion = true;
            SqlTransaction t = null;

            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand cmdMaestro = new SqlCommand(pa_camion, conexion, t);
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.Parameters.AddWithValue("@Patente", ocamion.patente);
                cmdMaestro.Parameters.AddWithValue("@Id_estado", ocamion.estado);
                cmdMaestro.Parameters.AddWithValue("@PesoMaximo", ocamion.pesoMaximo);

                cmdMaestro.ExecuteNonQuery();

                foreach (DetalleCarga det in ocamion.Detalles)
                {
                    SqlCommand cmdDetalle = new SqlCommand(pa_carga, conexion, t);

                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@Patente", oCarga.patente);
                    cmdDetalle.Parameters.AddWithValue("@Codigo_tipoCarga", oCarga.tipo_carga);
                    cmdDetalle.Parameters.AddWithValue("@PesoCarga", oCarga.peso);

                    cmdDetalle.ExecuteNonQuery();

                }
                t.Commit();

            }
            catch (Exception)
            {

                confirmacion = false;
                t.Rollback();
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }




            return confirmacion;

        }









        internal void guardarDetalle(string pa, DetalleCarga oCarga)
        {

            try
            {
                SqlCommand cmdDetalle = new SqlCommand(pa, conexion);

                conexion.Open();

                cmdDetalle.CommandType = CommandType.StoredProcedure;

                cmdDetalle.Parameters.AddWithValue("@Patente", oCarga.patente);  // modifique el constructor
                cmdDetalle.Parameters.AddWithValue("@Codigo_tipoCarga", oCarga.tipo_carga);
                cmdDetalle.Parameters.AddWithValue("@PesoCarga", oCarga.peso);

                cmdDetalle.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

        }
    }
}
