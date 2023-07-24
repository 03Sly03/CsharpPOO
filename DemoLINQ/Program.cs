List<int> l1 = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

List<int> l2 = new List<int> { 120, 21, 672, 3, 6484, 15, 62, 777, 7898, 59, 101 };

// FirstOrDefault
var l3 = l1.FirstOrDefault(); // retourne le premier élément de la liste
Console.WriteLine(l3);
Console.WriteLine(l1.FirstOrDefault(entier => entier == 21)); // -> 0 (0 est le premier élément)
Console.WriteLine(l2.FirstOrDefault(entier => entier == 211)); // -> 21

// Find (pareil que FirstOrDefault, mais utilise pas LINQ
Console.WriteLine(l2.Find(entier => entier > 3)); // 120
Console.WriteLine(l2.Find(entier => entier == 211)); // -> 0 (0 est le premier élément)

// Pour une liste de résultat qui correspondent

var l4 = l1.Where(entier => entier < 3); // sort un enumerable
foreach (var numb in l4)
{
    Console.Write(numb + ", ");
}

// Ou pour afficher on peut aussi faire
Console.WriteLine("\nl4 = " + string.Join(", ", l4));

var l5 = l1.Where(entier => entier < 3).ToArray(); // sort un tableau
var l6 = l1.Where(entier => entier < 3).ToList(); // sort une liste

// Select (équivalent au .map dans d'autres langage)

// On veut une liste de double en partant de la liste de int l2
// avec linq on peut transformer la list.

// une fonction lambda pour transformer un int en double
Func<int, double> cast = i => (double)i;

List<double> l2Double = l2.Select(cast).ToList();
Console.WriteLine("\nl2Double = " + string.Join(", ", l2Double));


Console.Write("Saisissez votre age : ");
int age;
try // le programme essaye le bloc en dessous du try
{
   //throw new Exception("Ya un gros problyme..."); // si on décommente, le catch sera le 2ème qui s'affichera
   age = int.Parse(Console.ReadLine()!);
}
catch (FormatException err) // les exceptions attrapées ont un type.
{
    Console.WriteLine("Format exception :\n" + err.Message);
    throw;
}
catch (Exception err) // les exceptions attrapées ont un type.
{
    Console.WriteLine("Autre exception" + err.Message);
    throw;
}
finally // qu'on ai attrapé une exception ou pas, le bloc de code ci-dessous est exécuté
{
    Console.WriteLine("ça se déclenche quand même ici");
}

Console.WriteLine(age);
