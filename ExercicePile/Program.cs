
using ExercicePile.Classes;

Pile<string> maPile = new Pile<string>();

maPile.Empiler("test");
maPile.Empiler("test2");
maPile.Empiler("test3");
maPile.Empiler("test4");
maPile.Empiler("test5");
maPile.Depiler();

Pile<int> maPile2 = new Pile<int>();

maPile2.Empiler(1);
maPile2.Empiler(2);
maPile2.Empiler(3);
maPile2.Empiler(4);
maPile2.Empiler(5);
maPile2.Depiler();