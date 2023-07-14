using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossGame
{
    public class Boss : Character
    {
        private int _maxAttack = 10;

        public Boss()
        {
            Name = "Boss";
            HitPoints = 200;
        }
        
        public override int Attack()
        {
            Random random = new Random();
            int damage = random.Next(1, _maxAttack);
            Console.WriteLine($"{Name} mega attacks you inflicting {damage} damage");
            return damage;
        }


    }
}
