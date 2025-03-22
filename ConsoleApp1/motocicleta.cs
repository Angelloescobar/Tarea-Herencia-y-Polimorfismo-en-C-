using clas6.misclases;
using claseOOP1.misclases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace clas6
{
    class motocicleta : vehiculos
    {
        private string encendido = "patada";
        private string combustible = "super ";
        private int velocidad;

        public motocicleta(int anio, string model, string Color) : base(anio, model, Color)
        {
        }

        public int Velocidad
        {
            get { return velocidad; }
            private set { velocidad = value; }
        }

        public string verencendido()
        {
            return encendido;
        }

        public void Acelerar(int cuanto)
        {
            Velocidad += cuanto;
            Console.WriteLine($"El vehículo ha acelerado, su velocidad actual: {Velocidad} km/h");
        }

        public virtual void Frenar()
        {
            if (Velocidad > 0)
            {
                Velocidad -= 10; // Frenado genérico
                Console.WriteLine($"El vehículo ha frenado, su velocidad actual: {Velocidad} km/h");
            }
            else
            {
                Console.WriteLine("El vehículo ha sido detenido.");
            }
        }
    
}
}

