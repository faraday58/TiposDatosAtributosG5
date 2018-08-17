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
            Console.WriteLine("Ingrese la marca de su automóvil");
            string marca = Console.ReadLine();
            Console.WriteLine("Ingrese el color del automovil");
            string color = Console.ReadLine();
            Console.WriteLine("Ingrese el modelo del automovil");
            short modelo = short.Parse(Console.ReadLine());
            Automovil suAutomovil = new Automovil(marca);
            Automovil elAutomovil = new Automovil(color, modelo);

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
