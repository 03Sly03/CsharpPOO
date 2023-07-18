using Demo02ClassesStatic.Classes;

Console.WriteLine(Dinosaur2.NombreDeDinosaure);

Dinosaur2 myDino1 = new Dinosaur2();
Dinosaur2 myDino2 = new Dinosaur2();
Dinosaur2 myDino3 = new Dinosaur2("monDino", 150, "Dino");
Dinosaur2 myDino4 = new Dinosaur2("monDino", 150, "Dino", true);

myDino2.Afficher();

Console.WriteLine(Dinosaur2.NombreDeDinosaure);

Dinosaur2.AfficherDinosaureVivant();