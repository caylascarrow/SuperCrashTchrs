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



            //check to see if both players have selected a character
            if (Form1.teacher.Count == 1)
            {
                ScreenControl.changeScreen(this, "BattleArena");
            }
        }

        private void CharacterSelection_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}


