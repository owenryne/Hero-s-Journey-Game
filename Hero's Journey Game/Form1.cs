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
        //Test comment to see if i can push changes

    }
}
