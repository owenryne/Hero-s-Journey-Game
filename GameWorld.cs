using System;

public class GameWorld
{
	public string[,] World { get; set; } //2D array for the game world | Don't know what size yet
	private int characterX; //Represents the characters row/x coordinate
	private int characterY; //Represents the character column/y coordinate


	public GameWorld(int x, int y)
	{
		World = new string[x, y];
		characterX = 0; //Initial Position (Could start somewhere else as 0,0 will be a corner)
		characterY = 0;
	}

	private void InitializeWorld() 
	{

	}
}
