using System;

namespace Nombre
{
    class Program
    {
        static void Main(string[] args)
        {  string nombre1; //Para poner palabras
           int cuenta1; //Para poner números enteros
           double promedio1; //Para poner números con decimales

            Console.WriteLine(" Bienvenidos a nuestro programa");
            Console.WriteLine(); //Espacios de lineas
            Console.WriteLine();
            Console.WriteLine("Ingresa tu nombre");
            nombre1 = Console.ReadLine();
            
            Console.WriteLine();
            Console.WriteLine ("Ingresa tu numero de cuenta: "); 
            cuenta1 = Convert.ToInt32(Console.ReadLine()); //Tenemos que convertir a Int32
            
            Console.WriteLine();
            Console.WriteLine ("Ingresa tu Promedio de la preparatoria: ");
            promedio1= Convert.ToDouble(Console.ReadLine()); //Tenemos que convertir a double
            
            Console.WriteLine();
            Console.WriteLine("Usuario, estos son tus datos:");
            Console.WriteLine();
            Console.WriteLine("Nombre de alumno: " + nombre1+ " Numero de cuenta: " + cuenta1+ " Promedio: "+ promedio1); 
            Console.WriteLine();
            //Aquí imprimimos en pantalla
            Console.WriteLine("Hasta luego.");
        }
    }
}