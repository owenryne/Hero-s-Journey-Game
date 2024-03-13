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

        public NameForm()
        {
            InitializeComponent();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            //Need to assign the text from txtBoxName to a player name variable
            CharacterName = txtboxName.Text;
            //MessageBox.Show($"Character's name is {name}");
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            charLabel1.Visible = false;
            charLabel2.Visible = false;
            txtboxName.Visible = false;
            btnName.Visible = false;
            orLabel.Visible = false;
            charLabel3.Visible = false;
            createBtn.Visible = false;
        }

        private void NameForm_Load(object sender, EventArgs e)
        {

        }

    }
}
