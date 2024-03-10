public class GameWorld
{
    public Zone[,] World { get; set; } // 2d array of zones to make up the world
    private int characterX;  // X position of the character
    private int characterY; // Y position of the character

    private Form1 form; // Reference to the main form

    public GameWorld(int x, int y)
    {
        World = new Zone[x, y];
        characterX = 0; // Set the character's starting position (Mabye make this random or at least not 0,0 as starting in a corner is a little awkward)
        characterY = 0;
        this.form = form; //
        InitializeWorld();
    }

    public class Zone
    {
        public string ZoneName { get; set; }
    }

    public class Forest : Zone
    {
        public Forest()
        {
            ZoneName = "Forest";
        }
    }

    public class Plain : Zone
    {
        public Plain()
        {
            ZoneName = "Plain";
        }
    }

    private void InitializeWorld()
    {
        Random rand = new Random();
        for (int i = 0; i < World.GetLength(0); i++)
        {
            for (int j = 0; j < World.GetLength(1); j++)
            {
                World[i, j] = rand.Next(2) == 0 ? new Forest() : new Plain();
            }
        }
    }

}
public class GameWorld
{
    public Zone[,] World { get; set; }
    private int characterX;
    private int characterY;

    public GameWorld(int x, int y)
    {
        World = new Zone[x, y];
        characterX = 0;
        characterY = 0;
        InitializeWorld();
    }

    public class Zone
    {
        public string ZoneName { get; set; }
    }

    public class Forest : Zone
    {
        public Forest()
        {
            ZoneName = "Forest"; // Need to add zone-specific properties and methods (e.g. enemies, etc.)
        }
    }

    public class Plain : Zone
    {
        public Plain()
        {
            ZoneName = "Plain";
        }
    }

    private void InitializeWorld()
    {
        Random rand = new Random();
        for (int i = 0; i < World.GetLength(0); i++)
        {
            for (int j = 0; j < World.GetLength(1); j++)
            {
                World[i, j] = rand.Next(2) == 0 ? new Forest() : new Plain(); // Randomly assign a zone (Need to add more zones)
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
            form.updateBox.Items.Add("You have entered the " + newZone.ZoneName + ".");
        }
        else 
        {
            form.updateBox.Items.Add("Your travel is impeded you cannot continue in this direction!"); //Handles if the character tries to move out of bounds
        }
    }
}