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
        bool leftDown, rightDown, upDown, downDown;
        int lCount, rCount, uCount, dCount;

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
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftDown = true;
                    lCount++;
                    break;
                case Keys.Right:
                    rightDown = true;
                    rCount++;
                    break;
                case Keys.Up:
                    upDown = true;
                    uCount++;
                    break;
                case Keys.Down:
                    downDown = true;
                    dCount++;
                    break;
            }
        }

        private void CharacterSelection_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Up:
                    upDown = false;
                    break;
                case Keys.Down:
                    downDown = false;
                    break;
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
            }
        }
    }
}


