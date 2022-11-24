using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX31
{
    class Cat : Character
    {
        public Cat(string name, float hp, float power,bool animal) : base(name, hp, power,animal) { }
        public override void Attack(Character destination)
        {
            Console.WriteLine($"{this.name}は{destination.name}を爪でひっかいた！");
            Console.WriteLine($"{destination.name}は傷を負った！");
            Console.WriteLine($"{destination.name}は{this.power}のダメージ");
            destination.hp -= this.power;
            Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
        }
    }
}
