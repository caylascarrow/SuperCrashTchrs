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
        #region variables and such
        bool leftDown, rightDown;
        int teachNum = 0;

        int teachX = 10;
        int teachY = 180;

        Image[] teachImage = {Properties.Resources.bondCharacterSelect, Properties.Resources.bradCharacterSelect,
            Properties.Resources.Leitch_Select,Properties.Resources.Cutch_L, Properties.Resources.Ortelli_L,
            Properties.Resources.Steel_L};

        #endregion

        public CharacterSelection()
        {
            InitializeComponent();

            //check to see if both players have selected a character
            if (Form1.teacher.Count == 1)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                BattleArena bs = new BattleArena();

                f.Controls.Add(bs);
            }
        }

        private void selectTime_Tick(object sender, EventArgs e)
        {
            //skim through cards
            if (leftDown == true && teachNum > 0)
            {
                teachNum--;
            }
            if (rightDown == true && teachNum < 5)
            {
                teachNum++;
            }
        }

        private void CharacterSelection_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
            }
        }

        private void CharacterSelection_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
            }
        }

        private void CharacterSelection_Paint(object sender, PaintEventArgs e)
        {
            //draw teacher card
            e.Graphics.DrawImage(teachImage[teachNum], teachX, teachY);
        }
    }
}


