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
        int teachX = 10;
        int teachY = 10;
        int teachCount = 0;

        Image[] teachImage = {Properties.Resources.Bond_Select, Properties.Resources.Bradshaw_Select,
            Properties.Resources.Leitch_Select, Properties.Resources.Cutch_Select, Properties.Resources.Ortelli_Select,
            Properties.Resources.Steel_Select};

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
                case Keys.Up:
                    upDown = true;
                    break;
                case Keys.Down:
                    downDown = true;
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

        private void CharacterSelection_Paint(object sender, PaintEventArgs e)
        {
            foreach (Image teachImage in teachImage)
            {
                e.Graphics.DrawImage(teachImage, teachX, teachY);

                teachX = teachX + 250;

                if(teachCount > 3 && teachCount < 4)
                {
                    teachY = teachY + 200;
                }

                teachCount++;
            }
        }
    }
}


