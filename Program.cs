using PracticaPOO.Enums;
using System;


namespace PracticaPOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Instancias de las clases con los parámetros
            ProdVegetal vegetal = new ProdVegetal("Café", 500, 4);
            Console.WriteLine(vegetal.Nombre);
           

            ProdAnimal animal = new ProdAnimal("leche", 100, 1);
            Console.WriteLine(animal.Precio);

           

            /*var granja = new Granja("Lecheria Familia Duran", TipoGranja.Lechería, TipoProducto.Leche, 3,3);
            Console.WriteLine(granja.NombreGranja);
            Console.ReadLine();*/

           

        }  
    }


}

