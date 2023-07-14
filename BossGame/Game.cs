using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossGame
{
    public class Game : Object
    {
        private List<Character>? badGuys;
        private Player? player;
        private int numGrunts;
        
        public Game()
        {
            badGuys = new List<Character>();
            numGrunts = new Random().Next(1, 3);
            Console.WriteLine($"You will be facing {numGrunts} Grunts");

            for (int i = 0; i < numGrunts; i++)
            {
                badGuys.Add(new Grunt());
            }
            badGuys.Add(new Boss());

            player = new Player();
            
        }
        
        public bool Win()
        {
            bool checkWin = true;
            // TODO: execption handling
            foreach (Character badGuy in badGuys)
            {
                if (badGuy.IsAlive())
                {
                    checkWin = false;
                }
            }
            return checkWin;
        }

        public bool Lose()
        {
            // TODO: execption handling
            if (player.IsAlive())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int ChooseWhoToAttack()
        {
            int response;
            Console.WriteLine("Who do you want to attack?");
            for (int i = 0; i < badGuys.Count; i++)
            {
                if (badGuys[i].IsAlive())
                {
                    Console.WriteLine($"{i}. {badGuys[i].Name}");
                }
            }

            // read response from the console 
            
            response = Convert.ToInt32(Console.ReadLine());

            return response;
        }

        public void PlayRound()
        {
           
            foreach (Character badGuy in badGuys)
            {
                if (badGuy.IsAlive())
                {
                    player.DisplayYourself();
                    badGuy.DisplayHealth();
                    int attack = badGuy.Attack();
                    player.TakeHit(attack);
                }
            }

            if (player.IsAlive())
            {
                int response = ChooseWhoToAttack();
                int attack = player.Attack();
                badGuys[response].TakeHit(attack);
                
            }
        }
    }
}

