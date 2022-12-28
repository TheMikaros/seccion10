using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Crea una Clase "Animal" que implemente la interfaz "IAnimal" ,
            //la interfaz "IAnimal" tendrá los métodos, Andar, es perro, saltar.
            //implementa estos métodos en la clase. y usa esa clase en un programa de consola.
            Animal animal = new Animal();
            animal.Andar(5);

            if(animal.EsPerro())
            {
                Console.WriteLine("El animal es un perro");
            }
            else
            {
                Console.WriteLine("El animal no es un perro");
            }

            animal.Saltar();


        }
    }
}
