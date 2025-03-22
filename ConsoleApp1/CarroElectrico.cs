using claseOOP1.misclases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clas6.misclases
{
    internal class carroElectrico : vehiculos
    {
        private int nivelBateria = 0;
        public carroElectrico(int anio, string model, string elColor) : base(anio, model, elColor)
        {

        }
        public void cargaBateria()
        {
            nivelBateria++;

        }
        public int verNivelBateria()
        {
            return nivelBateria;
        }

    }
}