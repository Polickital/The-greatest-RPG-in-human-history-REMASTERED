using System;
using System.Collections.Generic;
using System.Text;

namespace The_greatest_RPG_in_human_history.Entities
{
    public class Player : Entity
    {


        public Player(int atk, int hp, string name) : base(atk, hp, name)
        {
            Console.WriteLine($"{atk} {hp} {name}");
        }

    }

}
