using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceEmployeeHeritage.Classes
{
    internal class IHM
    {
        private static Entreprise _entreprise;

        public static void Start()
        {
            _entreprise = new Entreprise();
            _entreprise.AjouterSalarie(new Salarie("001", "Tonio", "Comptabilité", "S008", 24000));
            _entreprise.AjouterSalarie(new Commercial("004", "Bernardo", "Commercial", "Employé", 34000, 5000, 15));

            string choice = "";
            do
            {
                AffichageMenu();
                choice = Console.ReadLine()!;
                Console.WriteLine();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        AjoutEmployé();
                        break;
                    case "2":
                        Console.Clear();
                        AffichageEmployee();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("=== Recherche employé par nom ===");
                        string searchName;
                        do
                        {
                            Console.Write("Merci de saisir le nom : ");
                            searchName = Console.ReadLine()!;
                        } while (searchName.Length < 3);
                            Console.WriteLine(_entreprise.Find(searchName));
                        break;
                }
            } while (choice != "0");
            Console.WriteLine("A bientôt !");
        }
        private static void AffichageMenu()
        {
            Console.Write("===== Gestion des employés =====\n\n" +
                "1-- Ajouter un employé\n" +
                "2-- Afficher le salaire des employés\n" +
                "3-- Rechercher un employé\n" +
                "0-- Quitter\n\n" +
                "Entrez votre choix : ");
        }
        public static void AjoutEmployé()
        {
            Console.Write("===== Ajouté un employé =====\n\n" +
                "1-- Salarié\n" +
                "2-- Commercial\n" +
                "0-- Retour\n\n" +
                "Entrez votre choix : ");
            string choice = Console.ReadLine()!;
            Console.WriteLine();
            switch (choice)
            {
                case "0":
                    Console.Clear();
                    break;
                case "1":
                    SaisieEmploye("salarie");
                    Console.Clear();
                    break;
                case "2":
                    SaisieEmploye("commercial");
                    Console.Clear();
                    break;
            }
        }

        public static void SaisieEmploye(string typeofEmployee)
        {
            Console.Write("Merci de saisir le nom : ");
            string nom = Console.ReadLine()!;

            Console.Write("Merci de saisir le matricule : ");
            string matricule = Console.ReadLine()!;

            Console.Write("Merci de saisir la categorie : ");
            string categorie = Console.ReadLine()!;

            Console.Write("Merci de saisir le service : ");
            string service = Console.ReadLine()!;

            Console.Write("Merci de saisir le salaire : ");
            decimal salaire = decimal.Parse(Console.ReadLine()!);

            if (typeofEmployee == "commercial")
            {
                Console.Write("Merci de saisir le chiffre d'affaire du commercial : ");
                double chiffreDAffaire = double.Parse(Console.ReadLine()!);
                Console.Write("Merci de saisir la commission (en %) : ");
                double commission = double.Parse(Console.ReadLine()!);
                _entreprise.AjouterSalarie(new Commercial(matricule, nom, service, categorie, salaire, chiffreDAffaire, commission));
            }
            else
            {
                _entreprise.AjouterSalarie(new Salarie(matricule, nom, service, categorie, salaire));
            }
        }

        public static void AffichageEmployee()
        {
            Console.WriteLine("=== Salaire des employés ===");
            Console.WriteLine(_entreprise);
        }
    }
}
