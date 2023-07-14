using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossGame
{
    public abstract class Character
    {
        protected int starting_hit_points;
        protected int current_hit_points;
        protected bool alive;
        protected string name;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Character()
        {
            alive = true;
        }

        public int HitPoints
        {
            set
            {
                starting_hit_points = value;
                current_hit_points = value;
            }
        }
        
       public int Health()
       {
            // find percentage of how much health the character has 
             return (current_hit_points * 100) / starting_hit_points;
       }

        public void TakeHit(int damage)
        {
            Console.WriteLine($"{Name} has been hit with {damage} damage");
            current_hit_points -= damage;
            if (current_hit_points <= 0)
            {
                current_hit_points = 0;
                Console.WriteLine($"{Name} has died");
                alive = false;
            }
            else
            {
                Console.WriteLine($"{Name} now has health of {Health()}");
            }
        }

        public bool IsAlive()
        {
            return alive;
        }
        
        public virtual void DisplayHealth()
        {
            int leftHealth = Health();
            Console.Write($"{Name} has health: ({leftHealth}) ");
            for (int i = 0; i < 9; i++)
            {
                if(i < leftHealth / 10)
                {
                    Console.Write("=");
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine();
        }

        public virtual void DisplayYourself() { }
        public abstract int Attack();

    }
}
