using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculadora
{
    public class LaMevaCalculadora
    {
        public Int64 Sumar(Int64 v1, Int64 v2)
        {
            return (v1 + v2);
        }

        public Double Dividir(Double v1, Double v2)
        {
            return (Math.Round(v1 / v2,2));
        }
        
        public Int64 Restar(Int64 v1, Int64 v2)
        {
            return (v1 - v2);
        }
        
        public Int64 Multiplicar(Int64 v1, Int64 v2)
        {
            return (v1 * v2);
        }
        
        public int SumarVector(int[] vector)
        {
            int resultat = 0, i = 0;
            foreach (int element in vector)
            {
                resultat += vector[i];
                i++;
            }

            return (resultat);
        }

        public int ProducteCartesia(int[] vector1, int[] vector2)
        {
            int resultat = 0, x = 0;
            int[] resultado = new int[vector1.Length * vector2.Length];
            if (vector1.Length == vector2.Length)
            {
                for (int i = 0; i < vector1.Length; i++)
                {
                    for (int j = 0; j < vector2.Length; j++)
                    {
                        resultado[x] = vector1[i] + vector2[j];
                        x++;
                    }
                }

                resultat = SumarVector(resultado);
                return (resultat);
            } else
            {
                throw new ArgumentException("No tenen la mateixa longitud");
            }
        }

        public int[] InvertirVector(int[] vector1)
        {
            return (vector1.Reverse().ToArray());
        }

        public char[] OrdenarVector(char[] vector1)
        {
            Array.Sort(vector1);

            return (vector1);
        }

        public int Maxim(int[] vector1)
        {
            int resultat = 0, i = 0;

            foreach (int element in vector1)
            {
                if (element > resultat) resultat = element;
                i++;
            }

            return (resultat);
        }

        public int Minim(int[] vector1)
        {
            int resultat = vector1[0], i = 0;

            foreach (int element in vector1)
            {
                if (element < resultat) resultat = element;
                i++;
            }

            return (resultat);
        }
        
        public int QuantesVegades(string frase, char lletra)
        {
            int resultat = 0, i = 0;

            resultat = frase.Split(lletra).Length - 1;

            return (resultat);
        }

        public int[] OnEs(string frase, char lletra)
        {
            int i = 0, j = 0;
            int[] posicions = new int[3];

            for (i = 0; i < frase.Length; i++)
            {
                if (frase[i] == lletra)
                {
                    posicions[j] = i;
                    j++;
                }
            }

            return (posicions);
        }

        public int QuantesVocals(string frase)
        {
            int resultat = 0, i = 0, j = 0;
            char[] vocals = new char[10] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            for (i = 0; i < frase.Length; i++)
            {
                for (j = 0; j < vocals.Length; j++)
                {
                    if (char.IsLetter(frase[i]) && frase[i] == vocals[j]) resultat += 1;
                }
            }

            return (resultat);
        }

        public int QuantesConsonants(string frase)
        {
            int resultat = 0, i = 0, j = 0;
            char[] consonants = new char[40] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z', 
                'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Z' };

            for (i = 0; i < frase.Length; i++)
            {
                for (j = 0; j < consonants.Length; j++)
                {
                    if (char.IsLetter(frase[i]) && frase[i] == consonants[j]) resultat += 1 ;
                }
            }

            return (resultat);
        }

        public char[] ExtreuConsonants(string frase)
        {
            int i = 0, j = 0, x = 0;
            char[] consonantsQueApareixen = new char[9];
            char[] consonants = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z',
                'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Z' };

            for (i = 0; i < frase.Length; i++)
            {
                for (j = 0; j < consonants.Length; j++)
                {
                    if (char.IsLetter(frase[i]) && frase[i] == consonants[j])
                    {
                        consonantsQueApareixen[x] = frase[i];
                        x++;
                    }
                }
            }

            return (consonantsQueApareixen);
        }

        public bool EsPalindrom(string frase)
        {
            return frase.SequenceEqual(frase.Reverse());
        }
    }
}
