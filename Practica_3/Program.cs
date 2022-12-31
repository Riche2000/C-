using System;

namespace PRACTICA_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola usuario.");
            int a=5, b=3, c=-2, i=7;
            float f=5.5f;
            char g='w';

            bool r1 = ((a+b)==8) && ((a-b) == 2);
            bool r2 = !(c<-3);
            bool r3 = ((a+b)==8) || ((a-b) == 6);
            bool r4 = (i>=6) && (g=='w');
            bool r5 = (f>6) || (g!='w');

            Console.WriteLine("Valor 1: " + r1);
            Console.WriteLine("Valor 2: " + r2);
            Console.WriteLine("Valor 3: " + r3);
            Console.WriteLine("Valor 4: " + r4);
            Console.WriteLine("Valor 5: " + r5);
        }
    }
}