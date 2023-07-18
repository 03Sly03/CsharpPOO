using Exercices.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    internal class IHM
    {
        private static LePendu _lePendu;

        public static void Start()
        {
            Console.Write("Voulez-vous un nombre spécifique (10 par défaut) ? y/n ");
            string choice = Console.ReadLine()!.Trim().ToLower();
            if (choice == "y")
            {
                _lePendu.NbEssaiMax = int.Parse(choice);
                Console.Write("Combien voulez-vous d'essais ? ");
                int secondChoice = int.Parse(Console.ReadLine()!);
                _lePendu = new LePendu(secondChoice);
            }
            else
            {
                _lePendu = new LePendu();
            }
            Console.WriteLine($"Jeu du pendu généré ! Nombre d'essais : {_lePendu.NbTry}");

            bool win;
            do
            {
                win = AnotherTurn();
                Console.WriteLine("-----------------------------------------");
            } while (!win && _lePendu.NbTry != 0);
            Console.WriteLine(win ? "You have win !!!" : "You loooose !!!");
        }
        private static bool AnotherTurn()
        {
            Console.WriteLine("Le mot à trouver : " + _lePendu.Mask);
            Console.WriteLine($"Il vous reste {_lePendu.NbTry} essais");

            Console.Write("Veuillez saisir une lettre : ");
            Console.Write("Veuillez saisir une lettre : ");
            string userTry = Console.ReadLine()!;
            _lePendu.GenerateMask(userTry, _lePendu.TestChar(userTry));
            string play = _lePendu.TestWin();
            if (play == "win")
            {
                Console.WriteLine("Congratulation you have win !!!");
                return true;
            }
            else if (play == "loose")
            {
                Console.WriteLine("You loose !!!");
                return false;
            }
            IHM.AffichagePendu(_lePendu.NbTry, _lePendu.NbEssaiMax);
            return false;
        }
        public static void AffichagePendu(int noEssai, int nbEssaiMax)
        {
            string[,] penduAscii = {
                {"           ",
                "            ",
                "            ",
                "            ",
                "            ",
                "            ",
                "            "},
                {"           ",
                "            ",
                "            ",
                "            ",
                "            ",
                "            ",
                "--------    "},
                {"           ",
                "            ",
                "            ",
                " |          ",
                " |          ",
                " |          ",
                "--------    "},
                {"           ",
                " |          ",
                " |          ",
                " |          ",
                " |          ",
                " |          ",
                "--------    "},
                {"           ",
                " |/         ",
                " |          ",
                " |          ",
                " |          ",
                " |          ",
                "--------    "},
                {"_____      ",
                " |/         ",
                " |          ",
                " |          ",
                " |          ",
                " |          ",
                "--------    "},
                {"___________",
                " |/         ",
                " |          ",
                " |          ",
                " |          ",
                " |          ",
                "--------    "},
                {"___________ ",
                " |/       | ",
                " |          ",
                " |          ",
                " |          ",
                " |          ",
                "--------    "},
                {"___________ ",
                " |/       | ",
                " |        O ",
                " |       /|\\",
                " |       / \\",
                " |          ",
                "--------    "},
            };
            int noPendu = noEssai == 0 ? 0 : (noEssai * 8 / nbEssaiMax);
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(penduAscii[noPendu, i]);
            }
        }
    }
}
