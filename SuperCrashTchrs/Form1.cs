using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperCrashTchrs.Screens;

namespace SuperCrashTchrs
{
    public partial class Form1 : Form
    {
        #region Player Stats
        //Bond
        public static int bondHP = 1;
        public static int bondAtk = 125;
        public static int bondDef = 75;
        public static int bondSpd = 150;

        //Bradshaw
        public static int bradHP = 1;
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

        public static List<Teachers> teacher = new List<Teachers>();

        List<Teachers> temp = new List<Teachers>();

        public Form1()
        {
            InitializeComponent();

                 // display the main menu
            MainScreen mm = new MainScreen();

            // set the menu to display centre screen based on screen size defaults
            mm.Location = new Point((this.Width - mm.Width) / 2, (this.Height - mm.Height) / 2);

            // add main menu screen to form
            this.Controls.Add(mm);
        }
    }
}
