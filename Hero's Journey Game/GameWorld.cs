using System;

namespace Hero_s_Journey_Game {
    public class GameWorld
    {
        public Zone[,] World { get; set; }
        private int characterX;
        private int characterY;

        private Form1 form;

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

        public class Zone // Base zone class
        {
            public string ZoneName { get; set; }
            public string ZoneDescription { get; set; }
        }
        //(Need to add more zones)
        public class Forest : Zone
        {
            public Forest()
            {
                ZoneName = "Forest"; // Need to add zone-specific properties and methods (e.g. enemies, etc.)
                ZoneDescription = "A dense forest with towering trees that block out most sunlight.";
            }
        }

        public class Plain : Zone
        {
            public Plain()
            {
                ZoneName = "Plain";
                ZoneDescription = "A vast open plain with little to no cover.";
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
            Random rand = new Random();
            for (int i = 0; i < World.GetLength(0); i++)
            {
                for (int j = 0; j < World.GetLength(1); j++)
                {
                    // Randomly assigns a zone to each coordinate/positon in the array (Not sure if we want to do random assignment or not)
                    switch (rand.Next(3))
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
                form.AddUpdate("You have entered the " + newZone.ZoneName + ".");
                form.AddUpdate(newZone.ZoneDescription);
            }
            else
            {
                form.AddUpdate("Your travel is impeded you cannot continue in this direction!"); //Handles if the character tries to move out of bounds
            }
        }
    }
}
