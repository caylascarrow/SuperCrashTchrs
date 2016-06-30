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
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (teachNum > 0)
            {
                teachNum--;
            }
        }

        private void enterBttn_Click(object sender, EventArgs e)
        {
            //add in info for player select
            switch (teachNum)
            {
                case 0:
                    Teachers bond = new Teachers(Form1.bondHP, Form1.bondAtk, Form1.bondDef, Form1.bondSpd, "CriteriaChart", 
                        "Dissection", "MadExperiment", "TalkAboutFamily", "Bond");
                    Form1.teacher.Add(bond);
                    break;
                case 1:
                    Teachers brad = new Teachers(Form1.bradHP, Form1.bradAtk, Form1.bradDef, Form1.bradSpd, "AttackBot",
                        "ComplainAboutApple", "DefenderBot", "VideoFriday", "Bradshaw");
                    Form1.teacher.Add(brad);
                    break;
                case 2:
                    Teachers leitch = new Teachers(Form1.leitchHP, Form1.leitchAtk, Form1.leitchDef, Form1.leitchSpd, "Documentary",
                        "EssayQuestion", "HistoricWar", "MultipleChoice", "Leitch");
                    Form1.teacher.Add(leitch);
                    break;
                case 3:
                    Teachers cutch = new Teachers(Form1.cutchHP, Form1.cutchAtk, Form1.cutchDef, Form1.cutchSpd, "Dodgeball",
                        "DunkOn", "PushUps", "HealthClass", "McCutcheon");
                    Form1.teacher.Add(cutch);
                    break;
                case 4:
                    Teachers ort = new Teachers(Form1.ortHP, Form1.ortAtk, Form1.ortDef, Form1.ortSpd, "ClarinetSqueak",
                        "FullBandFortissimo", "MelodiousPassage", "Tuning", "Ortelli");
                    Form1.teacher.Add(ort);
                    break;
                case 5:
                    Teachers steel = new Teachers(Form1.steelHP, Form1.steelAtk, Form1.steelDef, Form1.steelSpd, "EqualSign",
                        "PinkPaper", "QuadraticAttack", "TextbookBarricade", "Steel");
                    Form1.teacher.Add(steel);
                    break;

            }
        }

        private void nextBttn_Click(object sender, EventArgs e)
        {
            if (teachNum < 5)
            {
                teachNum++;
            }
        }

        private void selectTime_Tick(object sender, EventArgs e)
        {
            //make sure buttons disappear so player can't go above or below a number
            if (teachNum == 0)
            {
                prevButton.Visible = false;
            }
            if (teachNum == 5)
            {
                nextBttn.Visible = false;
            }

            //check to see if both players have selected a character
            if (Form1.teacher.Count == 1)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                BattleArena bs = new BattleArena();

                f.Controls.Add(bs);
            }
        }

        private void CharacterSelection_Paint(object sender, PaintEventArgs e)
        {
            //draw teacher card
            e.Graphics.DrawImage(teachImage[teachNum], teachX, teachY);
        }


    }
}


