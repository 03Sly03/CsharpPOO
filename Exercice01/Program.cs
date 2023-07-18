/* La chaise
 * 1. Créer une classe Chaise possédant comme variables d'instance le nombre de pieds, le matériaux et la couleur de l'objet
 * 2. Afficher ses informations en surchargeant une méthode de la classe Object
 * 3. La classe Chaise pourra être instanciée avec ou sans paramètres (Constructeur par défaut)
 * 4. Afficher toutes les chaises (Possibilité de simplifier avec une méthode ToString)
*/

using Exercices.Classes;
using System.Threading.Tasks;
using System.Xml.Linq;

/*Chaise chaiseDefaut = new Chaise();

Chaise[] chaisesArray = 
{
    new Chaise(),
    new Chaise(),
    new Chaise(),
};

List<Chaise> chaiseList = new List<Chaise>();
chaiseList.Add(new Chaise());
chaiseList.Add(new Chaise());
chaiseList.Add(new Chaise());

chaiseDefaut.Afficher();

Console.WriteLine("ici: " + chaiseDefaut.ToString());
*/


// SALAIRES

/*Employee employee1 = new Employee(123456, "Commercial", "salarié", "Chloé", 24000);
Employee employee2 = new Employee(223789, "Vendeur", "salarié", "Emma", 30000);
Employee employee3 = new Employee(333456, "Accueil", "salarié", "Geaorge", 26000);
Employee employee4 = new Employee();

employee1.DisplaySalary();
employee2.DisplaySalary();
employee3.DisplaySalary();
employee4.DisplaySalary();
Employee.Infos();

Console.WriteLine($"On change le salaire de {employee1.Name} à 500000.");
employee1.ChangerSalaire(500000);
Employee.Infos();

Employee.ReinitializeNbOfEmployee();

Employee.Infos();*/


// LE PENDU



LePendu game = new LePendu();
Console.WriteLine("essai avant : " + game.NbTry);

Console.Write("Voulez-vous un nombre spécifique (10 par défaut) ? y/n ");
string choice = Console.ReadLine()!.Trim().ToLower();
if (choice == "y")
{
    Console.WriteLine("Combien voulez-vous d'essais ? ");
    int secondChoice = int.Parse(Console.ReadLine()!);
    game = new LePendu(secondChoice);
}
else if (choice == "n")
{
    game = new LePendu();
}
else Console.WriteLine("Erreur de saisie");

Console.WriteLine($"Jeu du pendu généré ! Nombre d'essais : {game.NbTry}");
game.GenerateMask();
Console.WriteLine("Le mot à trouver : " + game.Mask);
int totalTry = game.NbTry;
string play;
for (int i = 0; i < totalTry; i++)
{
    Console.Write("Veuillez saisir une lettre : ");
    string userTry = Console.ReadLine()!;
    game.GenerateMask(userTry, game.TestChar(userTry));
    play = game.TestWin();
    if (play == "win")
    {
        Console.WriteLine("Congratulation you have win !!!");
        break;
    }
    else if (play == "loose")
    {
        Console.WriteLine("You loose !!!");
        break;
    }
    Console.WriteLine("Le mot à trouver : " + game.Mask);
    Console.WriteLine($"Il vous reste {game.NbTry} essais");
}


// CITERNE
/*
WaterTank citerne1 = new WaterTank(10, 10, 20);
WaterTank citerne2 = new WaterTank(5, 10, 10);

Console.WriteLine($"Poids total de la citerne 1 : {citerne1.TotalWeight}");
Console.WriteLine($"Poids total de la citerne 2 : {citerne2.TotalWeight}");

Console.WriteLine("---------------------------------------------------------");

Console.WriteLine($"Quantité d'eau dans la citerne 1 : {citerne1.FillingLevel}");
Console.WriteLine($"Quantité d'eau dans la citerne 2 : {citerne2.FillingLevel}");
Console.WriteLine($"Quantité d'eau dans toutes les citernes : {WaterTank.TotalWaterVolume}");

Console.WriteLine("---------------------------------------------------------");

double fillWater = citerne1.FillWater(11);
Console.WriteLine($"Quantité d'eau dans la citerne 1 après ajout de 11 litres : {citerne1.FillingLevel}/{citerne1.MaxCapacity}");
Console.WriteLine($"Exès d'eau récupéré : {fillWater}");
double emptyWater = citerne2.EmptyWater(11);
Console.WriteLine($"Quantité d'eau dans la citerne 2 après retrait de 11 litres : {citerne2.FillingLevel}/{citerne2.MaxCapacity}");
Console.WriteLine($"Quantité d'eau récupéré : {emptyWater}");


Console.WriteLine("---------------------------------------------------------");

Console.WriteLine($"Quantité d'eau dans la citerne 1 : {citerne1.FillingLevel}");
Console.WriteLine($"Quantité d'eau dans la citerne 2 : {citerne2.FillingLevel}");
Console.WriteLine($"Quantité d'eau dans toutes les citernes : {WaterTank.TotalWaterVolume}");*/
