using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportes_Ejercicio_1_6.Dominio
{
    internal class Camion
    {
        string nvoEstado;

        public Camion(string pat, int est, int pMax)
        {
            patente = pat;
            estado = est;
            pesoMaximo = pMax;
            Detalles = new List<DetalleCarga>();
        }
        public string patente { get; set; }

        public int estado { get; set; }

        public int pesoMaximo { get; set; }


        public List<DetalleCarga> Detalles { get; set; }

        public Camion()
        {
            Detalles = new List<DetalleCarga>();
        }
        public void AgregarDetalle(DetalleCarga detalle)
        {
            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int indice)
        {
            Detalles.RemoveAt(indice);
        }






        override public string ToString()
        {
            nvoEstado = Convert.ToString(estado);

            switch (nvoEstado)
            {
                case "1":
                    nvoEstado = "Disponible";
                    break;
                case "2":
                    nvoEstado = "Listo para partir";
                    break;
                case "3":
                    nvoEstado = "Saturado";
                    break;

            }


            return "Camion: " + patente + " - Estado: - " + nvoEstado;
        }

    }
}
