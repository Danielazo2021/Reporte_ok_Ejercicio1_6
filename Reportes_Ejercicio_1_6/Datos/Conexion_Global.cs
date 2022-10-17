using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportes_Ejercicio_1_6.Datos
{
    public class SingletonDao

    {
        private static SingletonDao instance;
        private string connectionString;


        private SingletonDao()
        {
            connectionString = @"Data Source =laptop-sjp45n95; Initial Catalog = ejercicio_1_6_camiones; Integrated Security = True";

        }
        public static SingletonDao ObtenerInstance()
        {

            if(instance == null)
            {
                instance = new SingletonDao();
            }
            return instance;
        }
    }
}
