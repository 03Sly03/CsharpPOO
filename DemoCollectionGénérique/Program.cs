/*
// LIST

List<string> mesChaines = new List<string>()
{
    "chaine1",
    "chaine2",
    "chaine3",
    "chaine4",
    "chaine5",
    "chaine6",
};

Console.WriteLine("-------------------- List --------------------");

foreach (string chaine in mesChaines)
{
    Console.WriteLine(chaine);
}
Console.WriteLine("--------------------");

mesChaines.Remove("chaine2");
mesChaines.RemoveAt(0);
mesChaines.Add("chaine7");

foreach (string chaine in mesChaines)
{
    Console.WriteLine(chaine);
}
Console.WriteLine("--------------------");

mesChaines.Clear();
foreach (string chaine in mesChaines)
{
    Console.WriteLine(chaine);
}
Console.WriteLine("--------------------");

// DICTIONARY

Dictionary<string, int> participationAuCours = new Dictionary<string, int>()
{
    {"Remy", 25},
    {"Greg", 26},
    {"Gaëtan", 27},
};

Console.WriteLine("-------------------- Dictionary --------------------");
Console.WriteLine(participationAuCours["Remy"]); // -> 25

participationAuCours["Remy"]++;

Console.WriteLine(participationAuCours["Remy"]); // -> 26
Console.WriteLine("--------------------");

participationAuCours.Add("Aicha", 28);
participationAuCours.Add("Moi", int.MaxValue);
participationAuCours["Moi"] = 42;
participationAuCours.Remove("Remy");

foreach (KeyValuePair<string, int> participation in participationAuCours)
{
    Console.WriteLine(participation.Key + " " + participation.Value);
}

// QUEUE

Queue<string> myQ = new Queue<string>();

myQ.Enqueue("Hello");
myQ.Enqueue("World !");

Console.WriteLine("-------------------- Queue --------------------");
Console.WriteLine(myQ.Count);

myQ.Dequeue();
Console.WriteLine(myQ.Count);
*/

using DemoCollectionGenerique.Classes;

Demarreur<Ordinateur> demarreurDOrdinateur = new Demarreur<Ordinateur>();
demarreurDOrdinateur.DemareCetteChose(new Ordinateur());
Demarreur<Tronconeuse> demarreurTronconeuse = new Demarreur<Tronconeuse>();
demarreurTronconeuse.DemareCetteChose(new Tronconeuse());
//demarreurDOrdinateur.DemareCetteChose(new Scribe()); 