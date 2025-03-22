using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseOOP1.misclases
{
    internal class vehiculos
    {
        public string Color { get; set; }
        public string Modelo { get; set; }
        public int Year { get; }

        private int velocidad = 0;


        //constructor 
        public vehiculos(int anio, string model, string elColor)
        {
            this.Year = anio;
            this.Modelo = model;
            this.Color = elColor;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color: {0}", this.Color);
            Console.WriteLine("Modelo: {0}", this.Modelo);
            Console.WriteLine("Año: {0}", this.Year);
        }

        public virtual void Acelerar(int cuanto)
        {
            velocidad = velocidad += cuanto;
            Console.WriteLine("vas a: {0} kms por hora", velocidad);
        }

        public virtual void Frenar(int cuanto)
        {
            velocidad = velocidad -= cuanto;
            Console.WriteLine("vas a: {0} kms por hora", velocidad);
        }

        public void encender()
        {
            Console.WriteLine("El vehículo ha sido encendido.");
        }

        public void apagar()
        {
            Console.WriteLine("El vehículo ha sido apagado.");
        }
    }
}