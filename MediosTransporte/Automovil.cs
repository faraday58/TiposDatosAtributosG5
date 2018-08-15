using System;

namespace MediosTransporte
{
    class Automovil
    {

        public string marca;
        public string color;
        public float peso;
        public float costo;
        public short modelo;
        public const short llantas = 4;
        public static string gasolina;



        public void Encender()
        {
            Console.WriteLine("Automovil encendido");
        }
        public void Apagar()
        {
            Console.WriteLine("Automovil apagado");
        }

    }
}
