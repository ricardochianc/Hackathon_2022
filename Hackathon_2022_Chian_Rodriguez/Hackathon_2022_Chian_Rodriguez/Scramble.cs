using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_2022_Chian_Rodriguez
{
    public class Scramble
    {
        public Dictionary<char, int> PalabraOriginal { get; set; }

        public Scramble(string palabraOriginal)
        {
            PalabraOriginal = new Dictionary<char, int>();

            foreach (var letra in palabraOriginal.ToUpper())
            {
                if (!PalabraOriginal.ContainsKey(letra))
                {
                    PalabraOriginal.Add(letra, palabraOriginal.Count(c => (c == letra)));
                }
            }
        }

        public bool verificarSimilar(string palabraComparar)
        {
            var esCorrecto = true;
            
            foreach (var letra in palabraComparar.ToUpper())
            {
                esCorrecto = PalabraOriginal.ContainsKey(letra);

                if (!esCorrecto)
                {
                    return esCorrecto;
                }
            }
            return esCorrecto;
        }
    }
}
