using clas6.misclases;
using claseOOP1.misclases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clas6
{
    class Camion : vehiculos
    {
        private int CapacidadDeCarga;
        private int TamanioDeLaCabina;
        private int SistemaElectrico;
        private int CargaActual;
        public Camion(int anio, string model, string color) : base(anio, model, color)
        {

        }
        public void CargaDelCamion()
        {
            Console.WriteLine("la  capacidad de carga del camion es de: 20 quintales");
        }

        public int verCargaDelCmaion()
        {
            return 20;
        }
        public int verCargaActual()
        {
            return CargaActual;


        }
        public void Descargar()
        {
            CargaActual = 5;
            Console.WriteLine("el camion a sido descargado");


        }

    }
}