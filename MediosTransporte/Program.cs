using System;

namespace MediosTransporte
{
    class Program
    {
        static void Main()
        {
            //miAutmovil es un objeto de la clase Automovil
            //Se conoce como una instancia de la clase
            Automovil miAutomovil = new Automovil();
            miAutomovil.Velocidad = 250;
            for(int i=0; i <  7; i++)
            {
                miAutomovil.Acelerar();
            }


            Console.WriteLine("Ingrese la marca de su automóvil");
            string marca = Console.ReadLine();
            miAutomovil = new Automovil(marca);
            Console.WriteLine("Ingrese el color del automovil");
            string color = Console.ReadLine();
            Console.WriteLine("Ingrese el modelo del automovil");
            short modelo = short.Parse(Console.ReadLine());
            Automovil suAutomovil = new Automovil(marca);
            suAutomovil.Modelo = modelo;
            Console.WriteLine("El modelo de suAutomóvil es : {0}", suAutomovil.Modelo);
            

            Automovil elAutomovil = new Automovil(color, modelo);

            Console.WriteLine("Ingrese el peso de su vehiculo: ");
            float peso = float.Parse(Console.ReadLine());
            suAutomovil.Peso = peso;
            Console.WriteLine("El peso de su Automovil es : {0}", suAutomovil.Peso);
            //suAutomovil = elAutomovil;


            /* Ya no es accesible por se private
             * 
            miAutomovil.marca = "Porsche";
            miAutomovil.modelo = 2017;
            miAutomovil.costo = 2.5f;
            miAutomovil.color = "Negro";
            miAutomovil.peso = 2000;


            Console.WriteLine("Mi automovil es:  {0}  \n modelo: {1} \n costo: ${2} millones \n color: {3} \n peso: {4} kg ",miAutomovil.marca,miAutomovil.modelo,miAutomovil.costo,miAutomovil.color,miAutomovil.peso);
            miAutomovil.Encender();
            miAutomovil.Apagar();
            Console.WriteLine("Mi automovil tiene {0} llantas como todos los demás",Automovil.llantas);
            // Los atributos estáticos no se requieren acceder desde un objeto.
            Automovil.gasolina = "Premium";
            Console.WriteLine( "En mi automovil ocupé la gasolina: {0} ",Automovil.gasolina );
            */



        }
    }
}
