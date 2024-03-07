using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_s_Journey_Game
{
    internal class Character // Base character class
    {
        public string Description { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Mana {  get; set; }
        // ... other shared properties (strength, defense, mana, etc.)
        public string Weapon { get; set; } 
        public int weaponDamage { get; set; }
        public int Armor { get; set; } //not sure if we want armor as an int or string
        public int Level { get; set; }

        
    }

    internal class Warrior : Character
    {
        // Warrior-specific properties and methods
        public Warrior()
        {
            Description = "A brave fighter who relies on their overpowering brawn.";
            Strength = 25;
            Mana = 0;
            Speed = 0;
            Weapon = "";
            weaponDamage = 20; //subject to change
        }
        
    }

    internal class Mage : Character
    {
        // Mage-specific properties and methods
        public Mage()
        {
            Description =  "A magic user who relies on their sharp mind.";
            Strength = 5;
            Mana = 50;
        }
    }
}
