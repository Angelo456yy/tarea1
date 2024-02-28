using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nu1 = 10;
            int NU2 = 15;
            double Nu3 = 20;
            double Nu4 = 25;

            int suma = Nu1 + NU2;
            double resta = Nu1 - Nu4;
            double multi = Nu3 * Nu3;
            double divi = NU2 / Nu3;

            Console.WriteLine(suma);
            Console.WriteLine(resta);
            Console.WriteLine(multi);
            Console.WriteLine(divi);
            Console.WriteLine("hola que hace? 🤔 ");
        }

    }
}