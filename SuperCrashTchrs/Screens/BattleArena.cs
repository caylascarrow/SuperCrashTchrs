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
    public partial class BattleArena : UserControl
    {
        public BattleArena()
        {
            InitializeComponent();
        }

        #region Global Variables

        bool p1move1 = false;
        bool p1move2 = false;
        bool p1move3 = false;
        bool p1move4 = false;
        
        bool p2move1 = false;
        bool p2move2 = false;
        bool p2move3 = false;
        bool p2move4 = false;

        #region Player Stats
        //Bond
        int BondHP = 150;
        int BondAtk = 125;
        int BondDef = 75;
        int BondSpd = 150;
        //Bradshaw
        int BradHP = 150;
        int BradAtk = 75;
        int BradDef = 125;
        int BradSpd = 125;
        //Leitch
        int LeitchHP = 200;
        int LeitchAtk = 75;
        int LeitchDef = 150;
        int LeitchSpd = 50;
        //McCutcheon
        int CutchHP = 100;
        int CutchAtk = 150;
        int CutchDef = 100;
        int CutchSpd = 125;
        //Ortelli
        int OrtHP = 175;
        int OrtAtk = 100;
        int OrtDef = 125;
        int OrtSpd = 75;
        //Steel
        int SteelHP = 150;
        int SteelAtk = 75;
        int SteelDef = 175;
        int SteelSpd = 75;

        #endregion

        #endregion

        private void BattleArena_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //player 1
                case Keys.N:
                      p1move1 = true;
                    p1move2 = false;
                    p1move3 = false;
                    p1move4 = false;
                    break;
                case Keys.B:
                    p1move1 = false;
                      p1move2 = true;
                    p1move3 = false;
                    p1move4 = false;
                    break;
                case Keys.M:
                    p1move1 = false;
                    p1move2 = false;
                      p1move3 = true;
                    p1move4 = false;
                    break;
                case Keys.Space:
                    p1move1 = false;
                    p1move2 = false;
                    p1move3 = false;
                      p1move4 = true;
                    break;
                default:
                    break;
            }
            switch (e.KeyCode)
            {
                //player 2
                case Keys.V:
                      p2move1 = true;
                    p2move2 = false;
                    p2move3 = false;
                    p2move4 = false;
                    break;
                case Keys.C:
                    p2move1 = false;
                      p2move2 = true;
                    p2move3 = false;
                    p2move4 = false;
                    break;
                case Keys.X:
                    p2move1 = false;
                    p2move2 = false;
                      p2move3 = true;
                    p2move4 = false;
                    break;
                case Keys.Z:
                    p2move1 = false;
                    p2move2 = false;
                    p2move3 = false;
                      p2move4 = true;
                    break;
                default:
                    break;
            }
        }
    }
}
