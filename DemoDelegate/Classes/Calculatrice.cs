using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate.Classes
{
    /// <summary>
    /// Class servant à faire des calculs mathématique
    /// </summary>
    internal class Calculatrice
    {
        /// <summary>
        /// Méthode qui sert à faire la somme de 2 entiers !
        /// </summary>
        /// <param name="a">Un entier int</param>
        /// <param name="b">Un deuxième entier int</param>
        /// <returns>Un entier qui est la sommes de a + b en int</returns>
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Soustraction(int a, int b)
        {
            return a - b;
        }

        public void CalculerEtAfficher(int a, int b, Func<int, int, int> methodeDeCalcul)
        {
            int resultat = methodeDeCalcul(a, b);
            Console.WriteLine($"L'operation de calcul entre les entiers {a} et {b} donne {resultat}");
        }
    }
}
