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
            "Click start again to begin your Journey!"
            
        };

        //Need to create an instance of the World in this form
        public Form1()
        {
            InitializeComponent();
            //Test comment
            NameForm name = new NameForm();
            ListBox updateBox = new ListBox();
            if (name.ShowDialog() == DialogResult.OK ) 
            {
                charNam.Text = name.CharacterName;
            }
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
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            updateBox.Items.Clear();
            updateBox.Items.Add("Pick your Class: "); //Not sure what classes we are going with yet. Waiting on next meeting.
            progressBar.Value = 0;
            lvlBox.Text = "0";
        }


        //Test comment to see if i can push changes

    }
}
