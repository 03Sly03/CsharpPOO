using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices.Classes;

internal class Chaise
{
    // Les attributs
    private int _nbPieds;
    private string _materiau;
    private string _couleur;

    public int NbPieds { get => _nbPieds; set => _nbPieds = value; }
    public string Materiau { get => _materiau; set => _materiau = value; }
    public string Couleur { get => _couleur; set => _couleur = value; }

    public Chaise()
    {
        NbPieds = 4;
        Materiau = "bois";
        Couleur = "Marron";
    }

    public void Afficher()
    {
        //Console.WriteLine($"La chaise a {NbPieds} pieds, est en {Materiau}, et est de couleur {Couleur}");
        Console.WriteLine(this); // appelle le ToString implicitment pour write la representation textuelle de la chaise
    }

    public override string ToString() // override remplace le comportement de base de la méthode ToString()
    {
        return $"La chaise a {NbPieds} pieds, est en {Materiau}, et est de couleur {Couleur}";
    }
}
