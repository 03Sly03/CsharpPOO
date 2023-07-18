using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices.Classes
{
    internal static class WordGenerator
    {
        private static readonly string[] _wordList =
        {
            "avion",
            "tarte",
            "xénomorphe",
            "tulipe",
            "fournisseur",
            "internet",
            "lion",
            "viande",
            "crapule",
            "clip",
            "ide",
            "compilation",
            "execption"
        };

        public static string GenerateWord()
        {
            Random rnd = new Random();
            int numb = rnd.Next(0, _wordList.Length - 1);
            return _wordList[numb];

            // on peut le faire en une seule ligne

            //return _wordList[new Random().Next(_wordList.Length)];
        }
    }
}
