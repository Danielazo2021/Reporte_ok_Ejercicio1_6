using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Reportes_Ejercicio_1_6.Dominio;


namespace Reportes_Ejercicio_1_6.Datos.Intefaces
{
    interface ICamionesDao
    {
        DataTable consultarBD(string pa);
        void guardarMaestro(string pa, Camion Ocamion);

        bool actualizarBD(string pa, string identificador);

        bool GuardarMestro_Detalle(string pa_camion, Camion ocamion, string pa_carga, DetalleCarga oCarga);

        bool guardarDetalle(string pa, DetalleCarga oCarga);



    }
}