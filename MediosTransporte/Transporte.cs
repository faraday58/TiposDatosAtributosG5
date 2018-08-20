using System;

namespace MediosTransporte
{
    class Transporte
    {
        #region Atributos
        private string marca;
        private byte velocidad;
        private string color;
        private float peso;
        private float costo;
        private short modelo;
        private const short llantas = 4;
        private static string gasolina;

        #endregion
        #region Propiedades
        public short Modelo
        {
            get => modelo;
            set
            {
                if (value < 1899 || value > 2019)
                {
                    modelo = 2018;
                }
                else
                {
                    modelo = value;
                }

            }

        }

        public float Peso
        {
            get => peso;
            set
            {
                if (peso <= 100 || peso > 10000)
                {
                    peso = 1000;
                }
                else
                {
                    peso = value;
                }
            }
        }

        public byte Velocidad
        {
            get
            {
                return velocidad;
            }
            set
            {

                if (value >= 254)
                {
                    velocidad = 254;
                }
                else
                {
                    velocidad = value;
                }

            }
        }

        #endregion

        #region Métodos

        public void Encender()
        {
            Console.WriteLine("Medio de Transporte encendido");
        }
        public void Apagar()
        {
            Console.WriteLine("Medio de Transporte apagado");
        }
        public void Acelerar()
        {
            Velocidad++; //Velocidad = Velocidad +1;
            Console.WriteLine(Velocidad + " km/h ");
        }

        #endregion


    }
}
