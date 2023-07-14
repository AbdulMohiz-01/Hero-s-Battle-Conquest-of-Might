using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossGame
{
    public class Grunt : Character
    {
        public static int gruntID = 1;
        private int id;
        private int _maxAttack = 5;

        public Grunt()
        {
            Name = $"Grunt {gruntID}";
            HitPoints = 100;
            id = gruntID++;
        }

        public override int Attack()
        {
            Random random = new Random();
            int damage = random.Next(0, _maxAttack);
            Console.WriteLine($"{Name} attacks you inflicting {damage} damage");
            return damage;
        }
    }
}
