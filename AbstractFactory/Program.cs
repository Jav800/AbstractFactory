using System;
using System.Threading;
using Heros;
namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Archer archer = new Archer();
            archer.Attacked += (sender, arg) => Console.WriteLine($"Я {(sender as Hero).Name} атаковал {arg.Hero.Name} и нанёс урон {arg.Damage}");
            archer.Defenced+=(sender,arg) => Console.WriteLine($"Я {(sender as Hero).Name} защитился и получил {arg.Damage} урона");
            archer.Dead += (sender, arg) => Console.WriteLine("Лучник погиб");
            archer.Weapon.Used += (sender, arg) => Console.WriteLine($"Использовано оружие {sender.ToString()} на {arg.Used}");
            archer.Armor.Used += (sender, arg) => Console.WriteLine($"Использована броня {sender.ToString()} на {arg.Used}");
            Warrior warrior = new Warrior();
            warrior.Attacked += (sender, arg) => Console.WriteLine($"Я атаковал {arg.Hero.Name} и нанёс урон {arg.Damage}");
            warrior.Defenced += (sender, arg) => Console.WriteLine($"Я {(sender as Hero).Name} защитился и получил {arg.Damage} урона");
            warrior.Dead += (sedner, arg) => Console.WriteLine("Воин пал смертью храбрых");
            warrior.Weapon.Used += (sender, arg) => Console.WriteLine($"Использовано оружие {sender.ToString()} на {arg.Used}");
            warrior.Armor.Used += (sender, arg) => Console.WriteLine($"Использована броня {sender.ToString()} на {arg.Used}");
            while (archer.HP > 0 && warrior.HP > 0)
            {
                Console.WriteLine(archer);
                archer.Attack(warrior);
                Console.WriteLine(warrior);
                warrior.Attack(archer);
                Thread.Sleep(3000);
            }
            Console.ReadKey();
        }
    }
}