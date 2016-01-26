using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SuperCrashTchrs.Screens;

namespace SuperCrashTchrs.Screens
{
    class ScreenControl
    {
        // high score values
        public static List<int> highScores = new List<int>();

        //global variables
       
        public static string p1character;
        public static string p2character;
        #region Player Stats
        //Bond
        public static int bondHP = 150;
        public static int bondAtk = 125;
        public static int bondDef = 75;
        public static int bondSpd = 150;

        //Bradshaw
        public static int bradHP = 150;
        public static int bradAtk = 75;
        public static int bradDef = 125;
        public static int bradSpd = 125;

        //Leitch
        public static int leitchHP = 200;
        public static int leitchAtk = 75;
        public static int leitchDef = 150;
        public static int leitchSpd = 50;
        public static int leitchSleep = 0;

        //McCutcheon
        public static int cutchHP = 100;
        public static int cutchAtk = 150;
        public static int cutchDef = 100;
        public static int cutchSpd = 125;

        //Ortelli
        public static int ortHP = 175;
        public static int ortAtk = 100;
        public static int ortDef = 125;
        public static int ortSpd = 75;
        public static int ortSleep = 0;

        //Steel
        public static int steelHP = 150;
        public static int steelAtk = 75;
        public static int steelDef = 175;
        public static int steelSpd = 75;

        #endregion

        // screen and user control values
        public static int controlWidth = 800;
        public static int controlHeight = 800;
        
        public static int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
        public static int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
        
        public static Point startCentre = new Point(screenWidth / 2 - controlWidth / 2, screenHeight / 2 - controlHeight / 2);

        // button values
        public static Size buttonSize = new Size(180, 40);
        public static Color buttonBackColor = Color.White;
        public static Color buttonActiveColor = Color.Green;
        public static FlatStyle buttonFlatStyle = FlatStyle.Flat;
        public static Font buttonFont = new Font("Segoe UI", 10);

        public static Boolean firstTime = true;

        public static void buttonLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = buttonBackColor;
        }

        public static void buttonEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = buttonActiveColor;
        }

        public static void changeScreen(UserControl current, string next)
        {

            //tmp is set to the form that this control is on
            Form tmp = current.FindForm();
            tmp.Controls.Remove(current);
            UserControl ns = null;

            switch (next)
            {
                case "BattleArena":
                    ns = new BattleArena();
                    break;
                case "ModeSelection":
                    ns = new ModeSelection();
                    break;
                case "CharacterSelection":
                    ns = new CharacterSelection();
                    break;
                case "MultiEndScreen":
                    ns = new MultiEndScreen();
                    break;
                case "TallyScreen":
                    ns = new TallyScreen();
                    break;

            }

            ns.Size = new Size(controlWidth, controlHeight);
            ns.Location = startCentre;
            tmp.Controls.Add(ns);
            ns.Focus();
        }

        public static void setComponentValues(UserControl uc)
        {
            foreach (Control c in uc.Controls)
            {
                //will make the font of all components equal to buttonFont value
                c.Font = buttonFont;

                if (c is Button)
                {
                    Button b = new Button();
                    b = (Button)c;

                    b.Font = buttonFont;
                    b.BackColor = buttonBackColor;
                    b.Size = buttonSize;
                    b.FlatStyle = buttonFlatStyle;
                    b.Enter += buttonEnter;
                    b.Leave += buttonLeave;
                }

                // centre components on user control
                c.Location = new Point(controlWidth / 2 - c.Width / 2, c.Location.Y);
            }
        }

        public static void setComponentValues(Form f)
        {
            foreach (Control c in f.Controls)
            {
                //will make the font of all components equal to buttonFont value
                c.Font = buttonFont;

                if (c is Button)
                {
                    Button b = new Button();
                    b = (Button)c;

                    b.Font = buttonFont;
                    b.BackColor = buttonBackColor;
                    b.Size = buttonSize;
                    b.FlatStyle = buttonFlatStyle;
                }

                // centre components on user control
                c.Location = new Point(controlWidth / 2 - c.Width / 2, c.Location.Y);
            }
        }
    }
}
