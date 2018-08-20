using System;

namespace MediosTransporte
{
    class Automovil
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
        public short Modelo {
            get => modelo;
            set
            {
                if ( value < 1899 || value > 2019  )
                {
                    modelo = 2018;
                }
                else
                {
                    modelo = value;
                }
                
            }
                
        }

        public float Peso {
            get => peso;
            set {
                if (peso <= 100 || peso > 10000)
                {
                    peso = 1000;
                }
                else {
                    peso = value;
                }
            } 
        }

        public byte Velocidad {
            get
            {
               return velocidad;
            }
            set {

                if( velocidad >= 254)
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



        #region Constructores
        public Automovil()
        {
            marca = "Ferrari";
            color = "Rojo";
            Peso = 1000;
            costo = 4_000_000;
            Modelo = 2019;
            Console.WriteLine("La marca de mi auto: {0}\n color: {1} \n peso: {2} kg \n costo: ${3} \n modelo: {4}  ",marca,color,Peso,costo,Modelo);
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
            Console.WriteLine("El automóvil que elegiste es de color {0} y de modelo {1}",this.color,this.Modelo);
        }
        #endregion

        #region Métodos

        public void Encender()
        {
            Console.WriteLine("Automovil encendido");
        }
        public void Apagar()
        {
            Console.WriteLine("Automovil apagado");
        }
        public void Acelerar()
        {
            Velocidad++; //Velocidad = Velocidad +1;
            Console.WriteLine(Velocidad + " km/h "  );
        }

        #endregion
    }
}
