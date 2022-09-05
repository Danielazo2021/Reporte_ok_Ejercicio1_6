using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportes_Ejercicio_1_6.Dominio
{
    internal class DetalleCarga
    {
        public Camion camion { get; set; }
        public int peso { get; set; }
        public int tipo_carga { get; set; }

        public string patente { get; set; }

        public DetalleCarga(Camion miCamion, int pCarga, int tCarga)
        {
            camion = miCamion;
            peso = pCarga;
            tipo_carga = tCarga;
            patente = miCamion.patente;

        }


    }
}
