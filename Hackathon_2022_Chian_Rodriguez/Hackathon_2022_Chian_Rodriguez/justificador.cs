using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_2022_Chian_Rodriguez
{
    public class justificador
    {
        public int CaracteresLinea { get; set; }

        public List<string> Palabras { get; set; }

        public List<string> LineasParrafo { get; set; }

        public string TextoJustificado { get; set; }

        public bool CantidadCorrecta { get; set; }

        public justificador(int caracteresLinea, string oracion)
        {
            CaracteresLinea = caracteresLinea;
            Palabras = oracion.Split(" ").ToList();
            CantidadCorrecta = true;

            foreach (var palabra in Palabras)
            {
                if (palabra.Length > CaracteresLinea)
                {
                    CantidadCorrecta = false;
                    CaracteresLinea = palabra.Length + 1;
                }
            }

            LineasParrafo = new List<string>();
            TextoJustificado = "";
        }

        public void justificar()
        {
            var lineaActual = ""; //

            while (Palabras.Count > 0)
            {
                var top = Palabras.ElementAt(0); //Palabra en el top de la lista

                if ((lineaActual.Length < CaracteresLinea) && ((top.Length + lineaActual.Length) < CaracteresLinea))
                {
                    lineaActual += top + " ";
                    Palabras.RemoveAt(0);
                }
                else
                {
                    LineasParrafo.Add(rellenar(lineaActual));
                    lineaActual = "";
                }
            }

            LineasParrafo.Add(rellenar(lineaActual));
            TextoJustificado = String.Join("\n", LineasParrafo);
        }

        public string rellenar(string linea)
        {
            if (linea != "")
            {
                var lineaActual = "";
                var palabras = linea.Split(" ").ToList(); //This is an
                var posicion = 0;

                palabras.RemoveAt(palabras.Count - 1);

                while (lineaActual.Length < CaracteresLinea)
                {
                    lineaActual = "";

                    var p = palabras.ElementAt(posicion);
                    p += " ";
                    palabras[posicion] = p;
                    posicion++;

                    if ((posicion + 1) >= palabras.Count)
                    {
                        posicion = 0;
                    }

                    lineaActual = String.Join("", palabras);
                }
                return lineaActual;
            }

            return "";
        }
    }
}
