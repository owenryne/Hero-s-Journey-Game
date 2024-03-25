using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_s_Journey_Game
{
    public class Character // Base character class
    {
        //Sample properties for a character nothing concrete
        public string Description { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Mana {  get; set; }
        public int Dexterity { get; set; }
        public GameWorld.Weapon Weapon { get; set; }
        
        public int EXP { get; set; }
        // ... other shared properties (strength, defense, mana, etc.)

        
    }

    internal class Warrior : Character
    {
        // Warrior-specific properties and methods
        public Warrior()
        {
            Description = "A brave fighter who relies on their overpowering brawn.";
            Health = 100;
            Strength = 25;
            Mana = 0;

            Weapon = new GameWorld.Weapon 
            { 
                ItemName = "Sword",
                ItemDescription = "A trusty blade that has seen many battles. Reliable if not a bit dull.",
                ItemValue = 5,
                WeaponDamage = 20
            };
        }
        
    }

    internal class Mage : Character
    {
        // Mage-specific properties and methods
        public Mage()
        {
            Description =  "A magic user who relies on their sharp mind.";
            Health = 100;
            Strength = 5;
            Mana = 50;
            
            Weapon = new GameWorld.Weapon
            {
                ItemName = "Staff",
                ItemDescription = "A magical staff that channels the user's power.",
                ItemValue = 5,
                WeaponDamage = 10
            };
        }
    }

    internal class Rogue : Character
    {
        // Rogue-specific properties and methods
        public Rogue()
        {
            Description = "A stealthy character who relies on their agility and cunning.";
            Health = 100;
            Strength = 10;
            Dexterity = 25;
            Mana = 0;
            
            Weapon = new GameWorld.Weapon
            {
                ItemName = "Dagger",
                ItemDescription = "A sharp blade that strikes quickly and silently.",
                ItemValue = 5,
                WeaponDamage = 15
            };
        }
    }
}
