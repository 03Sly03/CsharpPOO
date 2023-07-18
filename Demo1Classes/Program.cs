using Demo01Classes.Classes;

// Instanciation -> appel au constructeur
Dinosaur dinoDefaut = new Dinosaur(); // Constructeur par défaut
Dinosaur dinoDefaut2 = new Dinosaur(); // Constructeur par défaut

Dinosaur myDino = new Dinosaur("Azert", 78, "Carn", false); // Constructeur personnalisé

// Accéder aux propriétés

Console.WriteLine(dinoDefaut.Nom);
Console.WriteLine(myDino.Nom);

// Définir

dinoDefaut.Age = 90;
Console.WriteLine(dinoDefaut.Age);
dinoDefaut.Poids = 500;
Console.WriteLine(dinoDefaut.Poids);


dinoDefaut.Poids = 99;

Console.WriteLine(dinoDefaut.Poids);

dinoDefaut.Afficher();
dinoDefaut2.Afficher();
dinoDefaut2.PeutVoler = true;
myDino.Afficher();
myDino.Cirer();

dinoDefaut.SEnvoler();
dinoDefaut2.SEnvoler();
