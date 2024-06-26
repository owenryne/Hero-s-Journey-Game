﻿using System;
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
            // Make battle health updates invisible on game launch
            enemyHealthBar.Visible = false;
            enemyHealth.Visible = false;

            playerHealth.Visible = false;
            playerHealthBar.Visible = false;
            humanBtn.Visible = false;
            gnomeBtn.Visible = false;
            orcBtn.Visible = false;
            elfBtn.Visible = false;
            raceText.Visible = false;
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
                charType.Text = name.Gender;
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

        public void GameOver()
        {
            // Reset player's properties
            gameWorld.player.Health = gameWorld.player.MaxHealth;
            gameWorld.player.EXP = 0;
            progressBar.Value = 0;
            lvlBox.Text = "0";
            updateBox.Items.Clear();
            AddUpdate("Game Over! You have been defeated. Press Start to play again!");

            playerHealthBar.Visible = false;
            playerHealth.Visible = false;
            charDex.Text = "";
            charStr.Text = "";
            charHealth.Text = "";
            charType.Text = "";
            charRace.Text = "";

            // Reset enemy's properties
            currentEnemy = null;
            enemyHealth.Visible = false;
            enemyHealthBar.Visible = false;

            // Reset game world
            gameWorld = new GameWorld(10, 10, this);

            // Reset UI elements
            startButton.Visible = true;
            attackButt.Enabled = false;
            blockButt.Enabled = false;
            forwardButt.Enabled = false;
            backButton.Enabled = false;
            leftButton.Enabled = false;
            rightButt.Enabled = false;

        }

        public void UpdateHealtlhDisplay(int health, int maxhealth)
        {
            charHealth.Text = $"Health: {health}/{maxhealth}";
        }

        public void UpdateStrengthDisplay(int strength)
        {
            charStr.Text = $"Strength: {strength}";
        }

        public void UpdateDexterityDisplay(int dexterity)
        {
            charDex.Text = $"Dexterity: {dexterity}";
        }

        public void UpdateHealth(int health)
        {
            gameWorld.player.Health = health;
            playerHealthBar.Value = health; // Update the health bar with player's current HP
            //have to set healthbar to 100 when class is chosen.
            playerHealthBar.Maximum = gameWorld.player.MaxHealth; // Set the maximum value of the player's health bar to the player's max HP
        }

        public void ClearEnemyInfo() //Clears the enemy info when entering a new zone (needed in case player runs away from an encounter)
        {
            enemyHealthBar.Visible = false;
            enemyHealth.Visible = false;
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
            //Add Chracter Class
            updateBox.Items.Clear();
            updateBox.Items.Add("Pick your Class: "); //Not sure what classes we are going with yet. Waiting on next meeting.
            warriorButton.Visible = true;
            mageButton.Visible = true;
            rougeButton.Visible = true;
            classesText.Visible = true;
            progressBar.Value = 0;
            lvlBox.Text = "0";

           
        }



        private void warriorButton_Click(object sender, EventArgs e)
        {
            Warrior warrior = new Warrior();
            updateBox.Items.Add("You have chosen Warrior! " + warrior.Description);
            warriorButton.Visible = false;
            mageButton.Visible = false;
            rougeButton.Visible = false;
            classesText.Visible = false;
            dialogueButton.Visible = false;
            startButton.Visible = false;
            gameWorld = new GameWorld(10, 10, this);
            forwardButt.Enabled = true; //Enables the movement buttons after a class is chosen
            backButton.Enabled = true;
            leftButton.Enabled = true;
            rightButt.Enabled = true;
            gameWorld.player = warrior;
            
            //Set player HP to visible
            playerHealth.Visible = true;
            playerHealthBar.Visible = true;
            playerHealth.Text = charNam.Text;

            //Set player HP to 100
            playerHealthBar.Value = warrior.Health;
            playerHealthBar.Maximum = warrior.MaxHealth;

            //Set player strength to +5

            //Add character Race
            updateBox.Items.Add("Pick your character's race: ");
            raceText.Visible = true;
            humanBtn.Visible = true;
            elfBtn.Visible = true;
            orcBtn.Visible = true;
            gnomeBtn.Visible = true;

        }

        private void mageButton_Click(object sender, EventArgs e)
        {
            Mage mage = new Mage();
            updateBox.Items.Add("You have chosen Mage! " + mage.Description);
            warriorButton.Visible = false;
            mageButton.Visible = false;
            rougeButton.Visible = false;
            classesText.Visible = false;
            dialogueButton.Visible = false;
            startButton .Visible = false;
            gameWorld = new GameWorld(10, 10, this);
            forwardButt.Enabled = true;
            backButton.Enabled = true;
            leftButton.Enabled = true;
            rightButt.Enabled = true;
            gameWorld.player = mage;

            //Set player HP to visible
            playerHealth.Visible = true;
            playerHealthBar.Visible = true;
            playerHealth.Text = charNam.Text;

            //Set player HP to 80
            playerHealthBar.Value = mage.Health;
            playerHealthBar.Maximum = mage.MaxHealth;

            //Add char race
            updateBox.Items.Add("Pick your character's race: ");
            raceText.Visible = true;
            humanBtn.Visible = true;
            elfBtn.Visible = true;
            orcBtn.Visible = true;
            gnomeBtn.Visible = true;
        }

        private void rougeButton_Click(object sender, EventArgs e)
        {
            Rogue rogue = new Rogue();
            updateBox.Items.Add("You have chosen Rogue! " + rogue.Description);
            warriorButton.Visible = false;
            mageButton.Visible = false;
            rougeButton.Visible = false;
            classesText.Visible = false;
            dialogueButton.Visible = false;
            startButton.Visible = false;
            gameWorld = new GameWorld(10, 10, this);
            forwardButt.Enabled = true;
            backButton.Enabled = true;
            leftButton.Enabled = true;
            rightButt.Enabled = true;
            gameWorld.player = rogue;

            //Set player HP to visible
            playerHealth.Visible = true;
            playerHealthBar.Visible = true;
            playerHealth.Text = charNam.Text;

            //Set player HP to 100
            playerHealthBar.Value = rogue.Health;
            playerHealthBar.Maximum = rogue.MaxHealth;

            //Add char race
            updateBox.Items.Add("Pick your character's race: ");
            raceText.Visible = true;
            humanBtn.Visible = true;
            elfBtn.Visible = true;
            orcBtn.Visible = true;
            gnomeBtn.Visible = true;
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
            enemyHealth.Visible = true;
            enemyHealth.Text = enemy.EnemyName;
            enemyHealthBar.Visible = true;
            enemy.EnemyHealth = enemy.EnemyMaxHealth; // Reset the enemy's health to max HP at the start of the battle to prevent the glitch where you encountered a 0 hp enemy
            enemyHealthBar.Maximum = enemy.EnemyMaxHealth; // Set the maximum value of the enemy's health bar to the enemy's max HP
            enemyHealthBar.Value = enemy.EnemyMaxHealth; // Set the enemy's health bar to max hp at the start of the battle to prevent the weird glitch where the bar is empty at the start of the battle

        }

        private void attackButt_Click(object sender, EventArgs e)
        {
            if (currentEnemy == null) return; // Prevents exceptions if the enemy is null  (The button is supposed to be disabled after combat but sometimes I got exceptions by clicking to fast through combat encounters)


            // Player's turn
            currentEnemy.EnemyHealth -= gameWorld.player.Weapon.WeaponDamage + Convert.ToInt32((gameWorld.player.Strength * gameWorld.player.Weapon.StrengthModifier));
            AddUpdate($"You attack the {currentEnemy.EnemyName} for {gameWorld.player.Weapon.WeaponDamage} damage!");

            if (currentEnemy.EnemyHealth < 0) { currentEnemy.EnemyHealth = 0; } // Prevents the enemy health bar from going below 0
            else { enemyHealthBar.Value = currentEnemy.EnemyHealth; }

            if (currentEnemy.EnemyHealth <= 0)
            {
                AddUpdate($"{currentEnemy.EnemyName} has been defeated!");
                gameWorld.player.EXP += currentEnemy.EnemyEXP; // Gain EXP for defeating the enemy
                AddUpdate($"You gained {currentEnemy.EnemyEXP} EXP!");
                if (gameWorld.player.EXP >= 100)
                {
                    gameWorld.player.EXP = 0;
                    gameWorld.player.Health += 10; // Gain 10 health for leveling up
                    gameWorld.player.MaxHealth += 10; // Increase the player's max health
                    playerHealthBar.Maximum = gameWorld.player.MaxHealth; // Update the player's health bar with the new max HP
                    gameWorld.player.Weapon.WeaponDamage += 5; // Gain 5 damage for leveling up // I want to tie in stregth to this cause it doesnt make a lot of sense to lvl up weapon damage rather than a charachter attribute (mabye make stregnth work as a multiplier for weapon damage and then do something similar for magic and dex depending on the class)
                    gameWorld.player.Strength += 5; // Gain 5 strength for leveling up
                    gameWorld.player.Dexterity += 5; // Gain 5 dexterity for leveling up
                    progressBar.Value = 0; // Reset the progress bar
                    progressBar.Maximum += 50; // Increase the needed EXP for the next level
                    AddUpdate($"You have leveled up! You gained 10 health, 5 damage, and +5 to your stats!");
                    lvlBox.Text = (Convert.ToInt32(lvlBox.Text) + 1).ToString(); // Update the level box
                    UpdateDexterityDisplay(gameWorld.player.Dexterity);
                    UpdateStrengthDisplay(gameWorld.player.Strength);
                    UpdateHealtlhDisplay(gameWorld.player.Health, gameWorld.player.MaxHealth);
                }
                else
                {
                    progressBar.Value = gameWorld.player.EXP; // Update the progress bar with the player's current EXP
                }
                currentEnemy = null; // Reset the enemy
                enemyHealth.Visible = false;
                enemyHealthBar.Visible = false;
                attackButt.Enabled = false; // Disables the attack button until a new enemy is encountered to prevent exceptions
                blockButt.Enabled = false; // Disables the block button until a new enemy is encountered
                return;
            }

            // Enemy's turn

            gameWorld.player.Health -= currentEnemy.EnemyDamage;
            AddUpdate($"{currentEnemy.EnemyName} attacks you for {currentEnemy.EnemyDamage} damage!");
            UpdateHealtlhDisplay(gameWorld.player.Health, gameWorld.player.MaxHealth);


            if (gameWorld.player.Health > 0) { UpdateHealth(gameWorld.player.Health); }

            if (gameWorld.player.Health <= 0)
            {
                AddUpdate($"You have been defeated...");
                currentEnemy = null; // Reset the enemy
                enemyHealth.Visible = false;
                enemyHealthBar.Visible = false;
                attackButt.Enabled = false; // Disables the attack button until a new enemy is encountered to prevent exceptions
                blockButt.Enabled = false; // Disables the block button until a new enemy is encountered
                GameOver();
            }

            
        }



        private void blockButt_Click(object sender, EventArgs e)
        {
            if (currentEnemy == null) return; // Prevents exceptions if the enemy is null  (The button is supposed to be disabled after combat but sometimes I got exceptions by clicking to fast through combat encounters)

            AddUpdate($"{gameWorld.player.GetType().Name} is preparing to block the next attack!");

            gameWorld.player.Health -= currentEnemy.EnemyDamage / 2; // Take half damage when blocking
            AddUpdate($"{gameWorld.player.GetType().Name} blocks and takes {currentEnemy.EnemyDamage / 2} damage!");
            UpdateHealtlhDisplay(gameWorld.player.Health, gameWorld.player.MaxHealth);

            if (gameWorld.player.Health > 0) { UpdateHealth(gameWorld.player.Health); }

            if (gameWorld.player.Health <= 0)
            {
                AddUpdate($"{gameWorld.player.GetType().Name} has been defeated...");
                currentEnemy = null; // Reset the enemy
                enemyHealth.Visible = false;
                enemyHealthBar.Visible = false;
                attackButt.Enabled = false; // Disables the attack button until a new enemy is encountered to prevent exceptions
                blockButt.Enabled = false; // Disables the block button until a new enemy is encountered
                GameOver();
            }

            
        }

        private void humanBtn_Click(object sender, EventArgs e)
        {
            charRace.Text = "Human";
            updateBox.Items.Add("You've Chosen Human!");
            //Add stat modifiers


            humanBtn.Visible = false;
            gnomeBtn.Visible = false;
            orcBtn.Visible = false;
            elfBtn.Visible = false;
            raceText.Visible = false;
        }

        private void gnomeBtn_Click(object sender, EventArgs e)
        {
            charRace.Text = "Gnome";
            updateBox.Items.Add("You've Chosen Gnome!");
            //Add stat modifiers
            gameWorld.player.Strength -= 3;
            gameWorld.player.Dexterity -= 2;
            gameWorld.player.Mana += 5;


            humanBtn.Visible = false;
            gnomeBtn.Visible = false;
            orcBtn.Visible = false;
            elfBtn.Visible = false;
            raceText.Visible = false;
        }

        private void elfBtn_Click(object sender, EventArgs e)
        {
            charRace.Text = "Elf";
            updateBox.Items.Add("You've Chosen Elf!");
            //Add stat modifiers
            gameWorld.player.Dexterity += 5;
            gameWorld.player.Strength -= 2;


            humanBtn.Visible = false;
            gnomeBtn.Visible = false;
            orcBtn.Visible = false;
            elfBtn.Visible = false;
            raceText.Visible = false;
        }

        private void orcBtn_Click(object sender, EventArgs e)
        {
            charRace.Text = "Orc";
            updateBox.Items.Add("You've Chosen Orc!");
            //Add stat modifiers
            gameWorld.player.Strength += 5;
            gameWorld.player.Dexterity -= 3;
            gameWorld.player.Mana -= 5;


            humanBtn.Visible = false;
            gnomeBtn.Visible = false;
            orcBtn.Visible = false;
            elfBtn.Visible = false;
            raceText.Visible = false;
        }

        private void updateBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
