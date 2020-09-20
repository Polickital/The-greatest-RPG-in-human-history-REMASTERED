using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace The_greatest_RPG_in_human_history
{
    public abstract class Entity
    {
        public int Atk;
        public int Hp;
        public string Name;

        public Entity (int atk, int hp, string name)
        {
            Atk = atk;
            Hp = hp;
            Name = name;
        }

        public void DealsDamage(Entity enemy){
            enemy.Hp -= Atk;
            Console.WriteLine($"{Name} spooned {enemy.Name}, Getting penetrated for {Atk} damage!");
        }
        public string Status()
        {
            return ($"{Name}'s HP is {Hp}");
        }
        public bool IsDead()
        {
            bool isDead = (Hp <= 0);
            if (isDead)
            {
                Console.WriteLine($"The spooning was too rough for {Name.ToLower()}, {Name.ToLower()} has fallen");

            }
            return isDead;
        }   
        public string PrintDeathMessage()
        {
            return "You are dead";
        }
    } 
}

    
    

