using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeritage.Classes
{
    internal class Animal
    {
        public string Nom { get; set; }
        public bool EstVivant { get; set; }
        public Animal(string nom, bool estVivant)
        {
            Nom = nom;
            EstVivant = estVivant;
        }
        public void Respirer()
        {
            Console.WriteLine("L'animal respire !");
        }

        public void Crier()
        {
            Console.WriteLine("L'animal crie !");
        }
    }
}
