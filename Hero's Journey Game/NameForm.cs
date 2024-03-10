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


    }
}
