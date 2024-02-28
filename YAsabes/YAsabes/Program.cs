using System;

namespace Ratacontinner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tienes una rata con tinner? ");

            string respuesta = Console.ReadLine();

            if (respuesta == "si")
            {
                Console.WriteLine("Man estas bien?");
                
            }
            else if (respuesta == "no")
            {
                Console.WriteLine("wtf tas bien? deberias tener una ");
            }
        }
    }
}