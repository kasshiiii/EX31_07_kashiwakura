using System;

namespace EX31
{
    class Program
    {
        static void Main()
        {
            Character character1 = new Character("しむら人", 500, 2,true);
            Character character2 = new Character("ささっき", 1000, 25,true);
            Tank tank1 = new Tank("Tiger", 500000, 250,false);
            tank1.bullet = 10;
            Tank tank2 = new Tank("がんタンク", 10000, 125,false);
            tank2.bullet = 5;
            Cow cow1 = new Cow("うっしー", 700, 50,true);
            Cat cat1 = new Cat("ネッコ", 500, 30,true);
            Hornet hornet1 = new Hornet("ハッチー", 800, 20, true);

            Character[] characters = { character1, character2, tank1, tank2 ,cow1,cat1,hornet1};
            for (var i = 1; i < characters.Length; i++)
            {
                characters[i].Attack(character1);
            }
        }
    }
}