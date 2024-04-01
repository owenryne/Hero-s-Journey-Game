using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hero_s_Journey_Game
{
    public partial class NameForm : Form
    {

        public string CharacterName { get; private set; }
        public string Gender {  get; private set; }
        public string Race { get; private set; }
        public GameWorld.Weapon Weapon { get; set; }
        

        public NameForm()
        {
            InitializeComponent();
        }


        private void btnName2_Click(object sender, EventArgs e)
        {
            //Need to assign the text from txtBoxName to a player name variable
            CharacterName = txtBoxName2.Text;
            //MessageBox.Show($"Character's name is {name}");
            DialogResult = DialogResult.OK;
            this.Close();
        }


        private void NameForm_Load(object sender, EventArgs e)
        {
            //Gender elements
            genderLabel.Visible = false;
            femaleBtn.Visible = false;
            maleBtn.Visible = false;
            preferBtn.Visible = false;

            //Name elements
            nameLabel.Visible = false;
            txtBoxName2.Visible = false;

            //Race Elements

            //Character Mod Btns

            //last label and submit btn
            btnName2.Visible = false;
            verifyLabel.Visible = false;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            //im not sure if theres an easier way to do this
            //just for making the UI look cleaner upon creating a character
            //gonna look real clunky but it works lol - Owen
            charLabel3.Visible = false;
            createBtn.Visible = false;

            //Make all create character buttons visible

            //Gender elements
            genderLabel.Visible = true;
            femaleBtn.Visible = true;
            maleBtn.Visible = true;
            preferBtn.Visible = true;

            //Name elements
            nameLabel.Visible = true;
            txtBoxName2.Visible = true;


            //last label and submit btn
            btnName2.Visible = true;
            verifyLabel.Visible = true;
        }

        //Gender Button Set-Up
        private void femaleBtn_Click(object sender, EventArgs e)
        {
            //Set gender to female
            Gender = "Female";
            
        }

        private void maleBtn_Click(object sender, EventArgs e)
        {
            //Set gender to male
            Gender = "Male";
            
        }

        private void preferBtn_Click(object sender, EventArgs e)
        {
            //Dont set gender
        }

        private void strengthBtn_Click(object sender, EventArgs e)
        {
            

        }


        private void manaBtn_Click(object sender, EventArgs e)
        {
            
        }

    }
}
