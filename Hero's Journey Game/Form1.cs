using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Hero_s_Journey_Game.GameWorld;

namespace Hero_s_Journey_Game
{
    public partial class Form1 : Form
    {
        //Variables for dialogue button. All this text can be interchangable. Will talk over after reading week.
        private int currentIndex = 0;
        private string[] gameExplain = new string[]
        {
            "Hero's Journey is a game created by Ranta Industries. \r",
            "In the game, you will follow a path of your choice by directional arrows. \r",
            "Players will start by choosing a Hero from the list of Hero's in Hero's Journey \r",
            "While exploring on the path, the player will encounter enemies in which you will need to beat to get past. \r",
            "To beat these enemies, there are buttons for two different attacks (related to your class choice), and a block. \r",
            "Enjoy exploring throughout the world of Hero's Journey!", 
            "Click Start begin your Journey!"
            
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            // Put your code here that should run when the form is loaded
        }

        private GameWorld gameWorld;
        private Enemy currentEnemy;
        public Form1()
        {
            InitializeComponent();
            //Test comment
            NameForm name = new NameForm();
            ListBox updateBox = new ListBox();
            if (name.ShowDialog() == DialogResult.OK ) 
            {
                charNam.Text = name.CharacterName;
                charGender.Text = name.Gender;
            }
            forwardButt.Enabled = false; //Disables the movement buttons until a class is chosen
            backButton.Enabled = false;
            leftButton.Enabled = false;
            rightButt.Enabled = false;
            attackButt.Enabled = false; //Disables the attack button until a battle is initiated
            blockButt.Enabled = false; //Disables the block button until a battle is initiated
        }

        public void AddUpdate(string update)
        {
            updateBox.Items.Add(update);
        }

        public void UpdateHealth(int health)
        {
            gameWorld.player.Health = health;
            playerHealth.Text = $"Health: {health}";
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentIndex < gameExplain.Length)
            {
                updateBox.Items.Add(gameExplain[currentIndex]);
                currentIndex++;
            }

        }

        private void clearBox_Click(object sender, EventArgs e)
        {
            updateBox.Items.Clear();
            updateBox.Items.Add("All text cleared.");
        }

        private void dialogueButton_Click(object sender, EventArgs e)
        {
            NameForm name = new NameForm();
            string introMessage = "Welcome to Hero's Journey " + charNam.Text + "! \r";
            string introMessage2 = "Click the Next button for more information!";

            updateBox.Items.Add(introMessage);
            updateBox.Items.Add(introMessage2);
            dialogueButton.Visible = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            updateBox.Items.Clear();
            updateBox.Items.Add("Pick your Class: "); //Not sure what classes we are going with yet. Waiting on next meeting.
            warriorButton.Visible = true;
            mageButton.Visible = true;
            classesText.Visible = true;
            progressBar.Value = 0;
            lvlBox.Text = "0";
            charRegion.Text = "";
        }



        private void warriorButton_Click(object sender, EventArgs e)
        {
            Warrior warrior = new Warrior();
            updateBox.Items.Add("You have chosen Warrior! " + warrior.Description);
            warriorButton.Visible = false;
            mageButton.Visible = false;
            classesText.Visible = false;
            dialogueButton.Visible = false;
            startButton.Visible = false;
            gameWorld = new GameWorld(10, 10, this);
            forwardButt.Enabled = true; //Enables the movement buttons after a class is chosen
            backButton.Enabled = true;
            leftButton.Enabled = true;
            rightButt.Enabled = true;
            gameWorld.player = warrior;
        }

        private void mageButton_Click(object sender, EventArgs e)
        {
            Mage mage = new Mage();
            updateBox.Items.Add("You have chosen Mage! " + mage.Description);
            warriorButton.Visible = false;
            mageButton.Visible = false;
            classesText.Visible = false;
            dialogueButton.Visible = false;
            startButton .Visible = false;
            gameWorld = new GameWorld(10, 10, this);
            forwardButt.Enabled = true;
            backButton.Enabled = true;
            leftButton.Enabled = true;
            rightButt.Enabled = true;
            gameWorld.player = mage;
        }
        private void forwardButt_Click(object sender, EventArgs e)
        {
            gameWorld.MoveCharacter(0, -1); // Move up
            playerCoords.Text = gameWorld.GetPlayerCoords();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            gameWorld.MoveCharacter(0, 1); // Move down
            playerCoords.Text = gameWorld.GetPlayerCoords();
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            gameWorld.MoveCharacter(-1, 0); // Move left
            playerCoords.Text = gameWorld.GetPlayerCoords();
        }

        private void rightButt_Click(object sender, EventArgs e)
        {
            gameWorld.MoveCharacter(1, 0); // Move right
            playerCoords.Text = gameWorld.GetPlayerCoords();
        }

        public void ClearUpdateBox() //Clears the update box when called (Call it when changing zones)
        {
            updateBox.Items.Clear();
        }


        public void Battle(Character character, Enemy enemy)
        {
            // Initialize the battle
            AddUpdate($"A battle has started between you and a {enemy.EnemyName}!");
            currentEnemy = enemy;
            attackButt.Enabled = true; // Enables the attack button when a battle is initiated
            blockButt.Enabled = true; // Enables the block button when a battle is initiated
        }

        private void attackButt_Click(object sender, EventArgs e)
        {
            if (currentEnemy == null) return; // Prevents exceptions if the enemy is null  (The button is supposed to be disabled after combat but sometimes I got exceptions by clicking to fast through combat encounters)


            // Player's turn
            currentEnemy.EnemyHealth -= gameWorld.player.WeaponDamage;
            AddUpdate($"You attack the {currentEnemy.EnemyName} for {gameWorld.player.WeaponDamage} damage!");

            if (currentEnemy.EnemyHealth <= 0)
            {
                AddUpdate($"{currentEnemy.EnemyName} has been defeated!");
                gameWorld.player.EXP += currentEnemy.EnemyEXP; // Gain EXP for defeating the enemy
                AddUpdate($"You gained {currentEnemy.EnemyEXP} EXP!");
                if (gameWorld.player.EXP >= 100)
                {
                    gameWorld.player.EXP = 0;
                    gameWorld.player.Health += 10; // Gain 10 health for leveling up
                    gameWorld.player.WeaponDamage += 5; // Gain 5 damage for leveling up
                    progressBar.Value = 0; // Reset the progress bar
                    progressBar.Maximum += 50; // Increase the needed EXP for the next level
                    AddUpdate($"You have leveled up! You gained 10 health and 5 damage!");
                    lvlBox.Text = (Convert.ToInt32(lvlBox.Text) + 1).ToString(); // Update the level box
                }
                else
                {
                    progressBar.Value = gameWorld.player.EXP; // Update the progress bar with the player's current EXP
                }
                currentEnemy = null; // Reset the enemy
                attackButt.Enabled = false; // Disables the attack button until a new enemy is encountered to prevent exceptions
                blockButt.Enabled = false; // Disables the block button until a new enemy is encountered
                return;
            }

            // Enemy's turn

            gameWorld.player.Health -= currentEnemy.EnemyDamage;
            AddUpdate($"{currentEnemy.EnemyName} attacks you for {currentEnemy.EnemyDamage} damage!");
            UpdateHealth(gameWorld.player.Health);


            if (gameWorld.player.Health <= 0)
            {
                AddUpdate($"You have been defeated...");
                currentEnemy = null; // Reset the enemy
            }
        }



        private void blockButt_Click(object sender, EventArgs e)
        {
            if (currentEnemy == null) return; // Prevents exceptions if the enemy is null  (The button is supposed to be disabled after combat but sometimes I got exceptions by clicking to fast through combat encounters)

            AddUpdate($"{gameWorld.player.GetType().Name} is preparing to block the next attack!");

            gameWorld.player.Health -= currentEnemy.EnemyDamage / 2; // Take half damage when blocking
            AddUpdate($"{gameWorld.player.GetType().Name} blocks and takes {currentEnemy.EnemyDamage / 2} damage!");
            UpdateHealth(gameWorld.player.Health);


            if (gameWorld.player.Health <= 0)
            {
                AddUpdate($"{gameWorld.player.GetType().Name} has been defeated...");
                currentEnemy = null; // Reset the enemy
            }
        }
    }
}
