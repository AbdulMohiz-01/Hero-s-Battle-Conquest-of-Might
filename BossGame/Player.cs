using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BossGame
{
    public class Player : Character
    {
        public Player()
        {
            Name = "Player 1";
            HitPoints = 100;
        }

        public override int Attack()
        {
            Random random = new Random();
            return random.Next(0, 30);
        }
        public override void DisplayYourself()
        {
            
           Console.WriteLine($"You are {Name} with {Health()} health");
            
        }
    }
    
}
