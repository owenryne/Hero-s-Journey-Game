using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace Hero_s_Journey_Game {
    public class GameWorld
    {
        public Zone[,] World { get; set; }
        private int characterX;
        private int characterY;

        private Form1 form;

        private Random randomEnemy = new Random(); // Random object to determine if an enemy is encountered
        public Character player; // The player's character

        public GameWorld(int x, int y, Form1 form)
        {
            World = new Zone[x, y];
            characterX = 0;
            characterY = 0;
            this.form = form;
            InitializeWorld();
        }

        public string GetPlayerCoords() // Method to get the player's coordinates and zone for the playerCoords text box
        {
            Zone currentZone = World[characterX, characterY];
            return $"({characterX}, {characterY}) in {currentZone.ZoneName}";
        }

        public class Enemy // Base enemy class
        {
            public string EnemyName { get; set; }
            public string EnemyDescription { get; set; }
            public int EnemyHealth { get; set; }
            public int EnemyMaxHealth { get; set; }
            public int EnemyDamage { get; set; }

            public int EnemyEXP { get; set; } // The amount of EXP the player gains for defeating the enemy
        }

        public class Zone // Base zone class
        {
            public string ZoneName { get; set; }
            public string ZoneDescription { get; set; }
            public List<Enemy> Enemies { get; set; } // List of enemies that can be found in the zone
            public double EncounterRate { get; set; } // Chance of encountering an enemy in the zone

            public Zone() //Initializes the list of enemies so exceptions are not thrown for zones without enemies
            {
                Enemies = new List<Enemy>();
            }
        }
        //(Need to add more zones)
        public class Forest : Zone
        {
            public Forest()
            {
                ZoneName = "Forest"; // Need to add zone-specific properties and methods (e.g. enemies, etc.)
                ZoneDescription = "A dense forest with towering trees that block out most sunlight.";
                EncounterRate = 0.5;
                Enemies = new List<Enemy>
                {
                    new Enemy
                    {
                        EnemyName = "Goblin",
                        EnemyDescription = "A small, green creature with a large nose, pointy ears, and a mischevious grin.",
                        EnemyHealth = 40,
                        EnemyMaxHealth = 40,
                        EnemyDamage = 5,
                        EnemyEXP = 15
                    },
                    new Enemy
                    {
                        EnemyName = "Wolf",
                        EnemyDescription = "A large, grey wolf with sharp teeth, a menacing growl, and a deep hunger in it's eyes.",
                        EnemyHealth = 50,
                        EnemyMaxHealth = 50,
                        EnemyDamage = 7,
                        EnemyEXP = 20
                    },
                    new Enemy
                    {
                        EnemyName = "Bear",
                        EnemyDescription = "A massive, grizzly bear with sharp claws and a deafening roar.",
                        EnemyHealth = 75,
                        EnemyMaxHealth = 75,
                        EnemyDamage = 10,
                        EnemyEXP = 25
                    }
                };
            }
        }

        public class Plain : Zone
        {
            public Plain()
            {
                ZoneName = "Plain";
                ZoneDescription = "A vast open plain with little to no cover.";
                EncounterRate = 0.40;

                Enemies = new List<Enemy>
                {
                    new Enemy
                    {
                        EnemyName = "Bandit",
                        EnemyDescription = "A criminal outlaw armed with a knife and who's face is obscured by a mask.",
                        EnemyHealth = 30,
                        EnemyMaxHealth = 30,
                        EnemyDamage = 5,
                        EnemyEXP = 15
                    },
                    new Enemy
                    {
                        EnemyName = "Giant Rat",
                        EnemyDescription = "A large rat with sharp teeth and a long tail.",
                        EnemyHealth = 25,
                        EnemyMaxHealth = 25,
                        EnemyDamage = 10,
                        EnemyEXP = 10
                    },
                    new Enemy
                    {
                        EnemyName = "Boar",
                        EnemyDescription = "A large angry boar with two large tusks",
                        EnemyHealth = 50,
                        EnemyMaxHealth = 50,
                        EnemyDamage = 10,
                        EnemyEXP = 20
                    }
                };
            }
        }

        public class Cave : Zone
        {
            public Cave()
            {
                ZoneName = "Cave";
                ZoneDescription = "A dark, damp cave with a musty smell.";
                EncounterRate = 0.60;

                Enemies = new List<Enemy>
                {
                    new Enemy
                    {
                        EnemyName = "Bat",
                        EnemyDescription = "A small, flying creature with sharp teeth.",
                        EnemyHealth = 20,
                        EnemyMaxHealth = 20,
                        EnemyDamage = 5,
                        EnemyEXP = 10
                    },
                    new Enemy
                    {
                        EnemyName = "Spider",
                        EnemyDescription = "A large, hairy spider with eight large legs and a venomous fangs.",
                        EnemyHealth = 30,
                        EnemyMaxHealth = 30,
                        EnemyDamage = 7,
                        EnemyEXP = 15
                    },
                    new Enemy
                    {
                        EnemyName = "Orc",
                        EnemyDescription = "A giant hulking orc wielding a massive club.",
                        EnemyHealth = 80,
                        EnemyMaxHealth = 80,
                        EnemyDamage = 20,
                        EnemyEXP = 20
                    }
                };
            }
        }

        public class Town : Zone
        {
            public Town()
            {
                ZoneName = "Town";
                ZoneDescription = "A bustling town with many people and shops.";
            }
        }

        private void InitializeWorld()
        {
            Random randomZone = new Random();
            for (int i = 0; i < World.GetLength(0); i++)
            {
                for (int j = 0; j < World.GetLength(1); j++)
                {
                    // Randomly assigns a zone to each coordinate/positon in the array (Not sure if we want to do random assignment or not)
                    switch (randomZone.Next(4))
                    {
                        case 0:
                            World[i, j] = new Forest();
                            break;
                        case 1:
                            World[i, j] = new Plain();
                            break;
                        case 2:
                            World[i, j] = new Town();
                            break;
                        case 3:
                            World[i, j] = new Cave();
                            break;
                    }
                }
            }
        }

        public void MoveCharacter(int dx, int dy)
        {
            // Calculate characters position
            int newX = characterX + dx;
            int newY = characterY + dy;

            if (newX >= 0 && newX < World.GetLength(0) && newY >= 0 && newY < World.GetLength(1))
            {
                characterX = newX;
                characterY = newY;

                Zone newZone = World[characterX, characterY];
                form.ClearUpdateBox();
                form.AddUpdate("You have entered the " + newZone.ZoneName + ".");
                form.AddUpdate(newZone.ZoneDescription);

                if (newZone is Town) // If the zone is a town, the player will heal to full health
                {
                    player.Health = player.MaxHealth;
                    form.AddUpdate("You find respite in town and have recovered your health.");
                    form.UpdateHealth(player.Health);
                }


                if (newZone.Enemies.Count > 0) // If there are enemies in the zone, there is a chance to encounter one
                {
                    if (randomEnemy.NextDouble() < newZone.EncounterRate) // Randomly determines if an enemy is encountered
                    {
                        Enemy enemy = newZone.Enemies[randomEnemy.Next(newZone.Enemies.Count)]; // Randomly selects an enemy from the list of enemies in the zone
                        form.AddUpdate("You have encountered a " + enemy.EnemyName + "!"); 

                        form.Battle(player,enemy); // Starts a battle with the enemy
                    }
                }
            }
            else
            {
                form.AddUpdate("Your travel is impeded you cannot continue in this direction!"); //Handles if the character tries to move out of bounds
            }
        }


        public class Item // Base item class
        {
            public string ItemName { get; set; }
            public string ItemDescription { get; set; }
            public int ItemValue { get; set; }
            //other shared properties
        }

        public class Weapon : Item // Weapons derived from Item
        {
            public int WeaponDamage { get; set; }
            public double StrengthModifier { get; set; } // Could use this to let the weapon scale with the player's strength
            public double DexterityModifier { get; set; }
        }
    }
}
