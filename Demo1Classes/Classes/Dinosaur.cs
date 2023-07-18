using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01Classes.Classes
{
    internal class Dinosaur
    {
        // Les attributs
        // int age = 10; // Ici tous les dino créer aurons par défaut 10 ans;
        private int _age; // pour différencier que c'est bien un attribut;
        private string _espece;
        private int _nbPattes;
        private double _poids;
        private bool _peutVoler = false;

        // Les propriétés (pour accéder, modifier les attributs. Principe de l'encapsulation)
        public int Age
        {
            get => _age;
            set => _age = value;
        }
        public string Espece { get => _espece; set => _espece = value; }
        public int NbPattes { get => _nbPattes; set => _nbPattes = value; }
        public double Poids {
            get 
            {
                Console.WriteLine("_poid à été récupéré, il vaut " + _poids);
                return _poids;
            }
            set
            {
                if (value < 100)
                {
                    Console.WriteLine("La valeur passée au poids est invalide !!! Je le met donc à 100 kg");
                    _poids = 100;
                }
                else
                {
                    _poids = value;
                }
            }
        }
        public bool PeutVoler { get => _peutVoler; set => _peutVoler = value; }

        // 
        public string RegimeAlimentaire { get; set; } = "Herbivore";
        public string Nom { get; set; }

        public Dinosaur() // Si on ne créé pas un constructeur, C# le créé implicitement par défaut et il est vide.
        {
            Nom = "Dino Défaut";
            Espece = "Défaut";
            // _age = 10; // on définit l'age directement par l'attribut
            Age = 10; // on définit l'age par la propriété. par exemple si la proprété fait des choses en plus (vérifications, ...) il serait plus avantageux de passer par elle.
        }

        public Dinosaur(string nom, int age, string espece, bool peutVoler) // avec des paramètres d'entrées du constructeur.
        {
            this.Nom = nom; // On parle du dino en particulier qu'on cherche a créer. On peut ne pas le mettre -> Nom = nom;
            // _age = age; // utilisation de l'attribut (sans le passage par la propriété)
            Age = age;
            Espece = espece;
            PeutVoler = peutVoler;
        }

        public void Afficher()
        {
            Console.WriteLine($"Le dinosaure \"{Nom}\" est agé de {Age} ans. Et est de l'espéce \"{Espece}\"");
        }

        public void Cirer()
        {
            Console.WriteLine($"Le dinosaure {Nom} cris: CRIIIIIIIIS !!!");
        }

        public void SEnvoler()
        {
            if (PeutVoler)
            {
                Console.WriteLine($"Le dinosaure {Nom} s'envole majestueusement !");
                return;
            }
            Console.WriteLine($"Le dinosaure {Nom} s'est planté !");
        }
    }
}
