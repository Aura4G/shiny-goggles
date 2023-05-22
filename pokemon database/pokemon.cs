using System;
using System.Collections.Generic;

namespace pokemon_database
{
    class pokemon
    {
       public int dexNum { get; set; }
       public string monName { get; set; }
       public string Type1 { get; set; }
       public string Type2 { get; set; }
       public int HP { get; set; }
       public int attack { get; set; }
       public int defence { get; set; }
       public int spAttack { get; set; }
       public int spDefence { get; set; }
       public int speed { get; set; }
       public string ability { get; set; }
       public static pokemon getPokemon()
       {
            Console.WriteLine("Enter the characteristics of the pokemon you wish to add. Add them in this order:");
            Console.WriteLine("Pokedex number");
            Console.WriteLine("Pokemon name");
            Console.WriteLine("Type 1");
            Console.WriteLine("Type 2");
            Console.WriteLine("HP");
            Console.WriteLine("Attack");
            Console.WriteLine("Defence");
            Console.WriteLine("Special Attack");
            Console.WriteLine("Special Defence");
            Console.WriteLine("Speed");
            Console.WriteLine("Ability");
            Console.WriteLine("");
            return new pokemon
            {
                dexNum = Convert.ToInt32(Console.ReadLine()),
                monName = Console.ReadLine(),
                Type1 = Console.ReadLine(),
                Type2 = Console.ReadLine(),
                HP = Convert.ToInt32(Console.ReadLine()),
                attack = Convert.ToInt32(Console.ReadLine()),
                defence = Convert.ToInt32(Console.ReadLine()),
                spAttack = Convert.ToInt32(Console.ReadLine()),
                spDefence = Convert.ToInt32(Console.ReadLine()),
                speed = Convert.ToInt32(Console.ReadLine()),
                ability = Console.ReadLine()
            };
       }
    }
}
