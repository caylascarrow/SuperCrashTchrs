using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperCrashTchrs.Screens
{
    public partial class CharacterSelection : UserControl
    {
        public CharacterSelection()
        {
            InitializeComponent();

            //which character has each player chosen

            //check to see if both players have selected a character
            if ((ScreenControl.p1character) != "" && (ScreenControl.p2character) != "")
            {
                ScreenControl.changeScreen(this, "BattleArena");
            }

        }

        private void bradSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
