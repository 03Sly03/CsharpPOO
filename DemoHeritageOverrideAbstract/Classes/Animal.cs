using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeritageOverrideAbstract.Classes
{
    internal abstract class Animal
    {
        public string Nom { get; set; }
        public bool EstVivant { get; set; }
        public Animal(string nom, bool estVivant)
        {
            Nom = nom;
            EstVivant = estVivant;
        }
        public abstract void Respirer();

        public abstract void Crier();

        public virtual void SeDeplacer()
        {
            Console.WriteLine("l'animale se déplace");
        }
    }
}
