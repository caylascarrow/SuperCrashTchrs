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
        bool leftDown, rightDown, upDown, downDown, eDown;
        int teachX = 10;
        int teachY = 10;
        int teachCount = 0;
        string teachName = "";

        Image[] teachImage = {Properties.Resources.Bond_Select, Properties.Resources.Bradshaw_Select,
            Properties.Resources.Leitch_Select, Properties.Resources.Cutch_Select, Properties.Resources.Ortelli_Select,
            Properties.Resources.Steel_Select};
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


            Graphics g = this.CreateGraphics();

            Pen selectPen = new Pen(Color.DarkGoldenrod, 25);


            #region character selection

            //Bond select
            if (bondSelect.Checked == true && eDown == true)
            {
                g.DrawRectangle(selectPen, teachX, teachY, 156, 217);

                Teachers t = new Teachers(138, 125, 75, 150, "CriteriaChart", "Dissection", 
                    "MadExperiment", "TalkAboutFamily", "Bond");
                Form1.teacher.Add(t);
            }
            else if (bondSelect.Checked == true)
            {
                g.DrawRectangle(selectPen, teachX, teachY, 156, 217);
            }

            //Brad select
            if (bradSelect.Checked == true && eDown == true)
            {
                g.DrawRectangle(selectPen, teachX, teachY, 156, 217);

                Teachers t = new Teachers(150, 75, 125, 125, "AttackBot", "ComplainAboutApple", 
                    "DefenderBot", "VideoFriday", "Bradshaw");
                Form1.teacher.Add(t);
            }
            else if (bradSelect.Checked == true)
            {
                g.DrawRectangle(selectPen, teachX, teachY, 156, 217);
            }

            //Leitch select
            if (leitchSelect.Checked == true && eDown == true)
            {
                g.DrawRectangle(selectPen, teachX, teachY, 156, 217);

                Teachers t = new Teachers(200, 75, 150, 50, "Documentary", "EssayQuestion", 
                    "HistoricWar", "MulipleChoiceQuestion", "Leitch");
                Form1.teacher.Add(t);
            }
            else if (leitchSelect.Checked == true)
            {
                g.DrawRectangle(selectPen, teachX, teachY, 156, 217);
            }

            //Cutch select
            if (cutchSelect.Checked == true && eDown == true)
            {
                g.DrawRectangle(selectPen, teachX, teachY, 156, 217);

                Teachers t = new Teachers(100, 150, 100, 125, "DODGEBALL", "Dunk-On", "PushUps", "HealthClass", "McCutcheon");
                Form1.teacher.Add(t);
            }
            else if (cutchSelect.Checked == true)
            {
                g.DrawRectangle(selectPen, teachX, teachY, 156, 217);
            }

            //Ortelli select
            if (ortelliSelect.Checked == true && eDown == true)
            {
                g.DrawRectangle(selectPen, teachX, teachY, 156, 217);

                Teachers t = new Teachers(175, 100, 125, 75, "ClarinetSqueak", "FullBandFortissimo",
                    "MelodiousPassage", "Tuning", "Ortelli");
                Form1.teacher.Add(t);
            }
            else if (ortelliSelect.Checked == true)
            {
                g.DrawRectangle(selectPen, teachX, teachY, 156, 217);
            }

            //Steel select
            if (steelSelect.Checked == true && eDown == true)
            {
                g.DrawRectangle(selectPen, teachX, teachY, 156, 217);

                Teachers t = new Teachers(150, 75, 175, 75, "=", "PinkPaper", "QuadraticAttack", "TextbookBarricade", "Steel");
                Form1.teacher.Add(t);
            }
            else if (steelSelect.Checked == true)
            {
                g.DrawRectangle(selectPen, teachX, teachY, 156, 217);
            }
            #endregion
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
                case Keys.E:
                    eDown = true;
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
                case Keys.E:
                    eDown = false;
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
                    teachX = 10;
                }

                teachCount++;
            }
        }
    }
}


