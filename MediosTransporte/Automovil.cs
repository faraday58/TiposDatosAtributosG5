using System;

namespace MediosTransporte
{
    class Automovil
    {

        private string marca;
        private string color;
        private float peso;
        private float costo;
        private short modelo;
        private const short llantas = 4;
        private static string gasolina;

        public Automovil()
        {
            marca = "Ferrari";
            color = "Rojo";
            peso = 1000;
            costo = 4_000_000;
            modelo = 2019;
            Console.WriteLine("La marca de mi auto: {0}\n color: {1} \n peso: {2} kg \n costo: ${3} \n modelo: {4}  ",marca,color,peso,costo,modelo);
            Encender();

        }

        public Automovil(string marca)
        {
            this.marca = marca;
            Console.WriteLine("El automóvil que elegiste es de marca {0}", this.marca);

        }

        public Automovil(string color, short modelo)
        {
            this.color = color;
            this.modelo = modelo;
            Console.WriteLine("El automóvil que elegiste es de color {0} y de modelo {1}",this.color,this.modelo);
        }



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
