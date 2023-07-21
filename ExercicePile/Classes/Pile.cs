using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicePile.Classes
{
    internal class Pile<T>
    {
        private List<T> _elements = new List<T>();

        public List<T> Elements { get => _elements; set => _elements = value; }

        public void Empiler(T valeurAEmpiler)
        {
            Elements.Add(valeurAEmpiler);
            Console.WriteLine("\n------------------- Empile -------------------");
            Console.WriteLine($"L'élément \"{valeurAEmpiler}\" a été ajouté à la pile !\nLa Pile compte maintenant {Elements.Count} élément(s)");
        }

        public void Depiler()
        {
            Console.WriteLine("\n------------------- Dépile -------------------");
            Console.Write($"L'élément {Elements.ElementAt(Elements.Count - 1)} ");
            Elements.RemoveAt(Elements.Count - 1);
            Console.WriteLine($" a été dépilé\nLa Pile compte {Elements.Count} élément(s)");
        }
    }
}
