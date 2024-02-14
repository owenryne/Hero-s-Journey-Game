using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hero_s_Journey_Game
{
    public partial class Form1 : Form
    {

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
        //Left Button
        private void leftButton_Click(object sender, EventArgs e)
        {

        }
        //Forward Button
        private void forwardButt_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            NameForm name = new NameForm();
            string introMessage = "Welcome to Hero's Journey " + charNam.Text + "! \r";

            //Couldn't figure out a way to get this all on one line, so for the meantime ill leave it like this
            string gameExplain1 = "Hero's Journey is a game created by Ranta Industries. ";
            string gameExplain2 = "In the game, you will follow a path of your choice by directional arrows.";
            string gameExplain3 = "Players will start by choosing a Hero from the list of Hero's in Hero's Journey";
            string gameExplain4 = "While exploring on the path, the player will encounter enemies in which you will need to beat to get past.";
            string gameExplain5 = "To beat these enemies, there are buttons for two different attacks (related to your class choice), and a block.";
            string gameExplain6 = "Enjoy exploring throughout the world of Hero's Journey!";
            updateBox.Items.Add(introMessage);
            updateBox.Items.Add(gameExplain1);
            updateBox.Items.Add(gameExplain2);
            updateBox.Items.Add(gameExplain3);
            updateBox.Items.Add(gameExplain4);
            updateBox.Items.Add(gameExplain5);
            updateBox.Items.Add(gameExplain6);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Test comment to see if i can push changes

    }
}
