using System;

namespace Practica_3
{
    class Program
    {
        static void Main(string[] args)
        {  string nombre1;
           int cuenta1;
           double promedio1;

           string nombre2;
           int cuenta2;
           double promedio2;
           
           string nombre3;
           int cuenta3;
           double promedio3;
           
            Console.WriteLine(" Bienvenidos a nuestro programa");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ingresa tu nombre");
            nombre1 = Console.ReadLine();
            
            Console.WriteLine();
            Console.WriteLine ("Ingresa tu numero de cuenta: "); 
            cuenta1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine ("Ingresa tu Promedio de la preparatoria: ");
            promedio1= Convert.ToDouble(Console.ReadLine());
//------------------- Alumno 2
            Console.WriteLine();
            Console.WriteLine("Ingresa tu nombre: ");
            nombre2 = Console.ReadLine();
            
            Console.WriteLine();
            Console.WriteLine ("Ingresa tu numero de cuenta: "); 
            cuenta2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine ("Ingresa tu Promedio de la preparatoria: ");
            promedio2= Convert.ToDouble(Console.ReadLine());
            //----------------- Alumno 3
            Console.WriteLine();
            Console.WriteLine("Ingresa tu nombre");
            nombre3 = Console.ReadLine();
            
            Console.WriteLine();
            Console.WriteLine ("Ingresa tu numero de cuenta: "); 
            cuenta3 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine ("Ingresa tu Promedio de la preparatoria: ");
            promedio3= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Los datos que ingresaste son: "); 
            Console.WriteLine();
            Console.WriteLine("Nombre de alumno: " + nombre1+ " Numero de cuenta: " + cuenta1+ " Promedio: "+ promedio1); 
            Console.WriteLine();
            Console.WriteLine("Nombre de alumno: " + nombre2+ " Numero de cuenta: " + cuenta2+ " Promedio: "+ promedio2); 
            Console.WriteLine();
            Console.WriteLine("Nombre de alumno: " + nombre3+ " Numero de cuenta: " + cuenta3+ " Promedio: "+ promedio3); 

        }
    }
}