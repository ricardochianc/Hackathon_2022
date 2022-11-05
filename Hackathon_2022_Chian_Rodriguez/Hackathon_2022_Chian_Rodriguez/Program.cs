using System;

namespace Hackathon_2022_Chian_Rodriguez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hackathon 2022 | Alex Rodriguez, Ricardo Chian");

            Console.WriteLine("Ingrese una palabra: ");
            var palabraOriginal = Console.ReadLine();

            var Scramble = new Scramble(palabraOriginal);

            Console.WriteLine("Ingrese otra palabra: ");
            var palabraComparar = Console.ReadLine();

            if (Scramble.verificarSimilar(palabraComparar))
            {
                Console.WriteLine("La segunda cadena es una cadena desordenada de la primera");
            }
            else
            {
                Console.WriteLine("La segunda cadena NO es una cadena desordenada de la primera");
            }

            Console.ReadKey();
        }
    }
}
