using System;

namespace Hackathon_2022_Chian_Rodriguez
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hackathon 2022 | Alex Rodriguez, Ricardo Chian");

            //PROBLEMA 1
            Console.WriteLine("\n\n");
            Console.WriteLine("Problema 1 -------------------------------");
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


            //PROBLEMA 2
            Console.WriteLine("\n\n");
            Console.WriteLine("Problema 2 -------------------------------");
            Console.WriteLine("Ingrese la longitud de las lineas");
            var longitudStr = Console.ReadLine();

            Console.WriteLine("Ingrese una oración:");
            var oracion = Console.ReadLine();

            var justificador = new justificador(Int32.Parse(longitudStr), oracion);
            justificador.justificar();

            if (justificador.CantidadCorrecta == false)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("La cantidad de caracteres permitidos en una linea es menor a una de las palabras ingresadas, la nueva longitud es de: " );
                Console.WriteLine(justificador.CaracteresLinea.ToString());
            }

            Console.WriteLine("\n\n");
            Console.WriteLine(justificador.TextoJustificado);



            Console.ReadKey();
        }
    }
}
