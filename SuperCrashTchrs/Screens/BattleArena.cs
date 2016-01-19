///Super Crash Teachers Battle Arena
///By Cayla, Hannah, Justin
///WOW!!! ;)
/// ding dangs guys this is cool
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

        public static Random randNum = new Random();

        #region Global Variables

        bool p1move1 = false;
        bool p1move2 = false;
        bool p1move3 = false;
        bool p1move4 = false;
        
        bool p2move1 = false;
        bool p2move2 = false;
        bool p2move3 = false;
        bool p2move4 = false;

        bool p1moveSelect = false;
        bool p2moveSelect = false;

        #region Player Stats
        //Bond
        int bondHP = 150;
        int bondAtk = 125;
        int bondDef = 75;
        int bondSpd = 150;
        //Bradshaw
        int bradHP = 150;
        int bradAtk = 75;
        int bradDef = 125;
        int bradSpd = 125;
        //Leitch
        int leitchHP = 200;
        int leitchAtk = 75;
        int leitchDef = 150;
        int leitchSpd = 50;
        int leitchSleep = 0;
        //McCutcheon
        int cutchHP = 100;
        int cutchAtk = 150;
        int cutchDef = 100;
        int cutchSpd = 125;
        //Ortelli
        int ortHP = 175;
        int ortAtk = 100;
        int ortDef = 125;
        int ortSpd = 75;
        int ortSleep = 0;
        //Steel
        int steelHP = 150;
        int steelAtk = 75;
        int steelDef = 175;
        int steelSpd = 75;

        #endregion

        #endregion

        private void BattleArena_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //player 1
                case Keys.N:
                      p1moveSelect = true;
                      p1move1 = true;
                    p1move2 = false;
                    p1move3 = false;
                    p1move4 = false;
                    break;
                case Keys.B:
                      p1moveSelect = true;
                    p1move1 = false;
                      p1move2 = true;
                    p1move3 = false;
                    p1move4 = false;
                    break;
                case Keys.M:
                      p1moveSelect = true;
                    p1move1 = false;
                    p1move2 = false;
                      p1move3 = true;
                    p1move4 = false;
                    break;
                case Keys.Space:
                      p1moveSelect = true;
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
                      p2moveSelect = true;
                      p2move1 = true;
                    p2move2 = false;
                    p2move3 = false;
                    p2move4 = false;
                    break;
                case Keys.C:
                      p2moveSelect = true;
                    p2move1 = false;
                      p2move2 = true;
                    p2move3 = false;
                    p2move4 = false;
                    break;
                case Keys.X:
                      p2moveSelect = true;
                    p2move1 = false;
                    p2move2 = false;
                      p2move3 = true;
                    p2move4 = false;
                    break;
                case Keys.Z:
                      p2moveSelect = true;
                    p2move1 = false;
                    p2move2 = false;
                    p2move3 = false;
                      p2move4 = true;
                    break;
                default:
                    break;
            }
        }


        //public double damageCalc(int userPower, int userAtk, int opponentDef)
        //{
        //    double damage;
        //    damage = 0;
        //    return damage;
        //}

        public double attackBot()
        {

        }

        public int clarinetSqueak(int opponentDef) //Justin got this
        {
            opponentDef = opponentDef - 25;
            //print to text "Defence was lowered by 1 stage"
            
            if (opponentDef <= 0)
        {
                opponentDef = 1;
                //print to text "defence cannot go any lower"
            }

            return opponentDef;
        }

        public double ComplainBout() //Cayla is programming
        {
            //know if player's move continues out sucessfully
            int accuracyHit = randNum.Next(1, 101);

            if (accuracyHit > 10)
            {
                //show animation
                //play sound(s)
                //calculate damage opponent takes
                
                //calculate amount of HP opponent has left
                //display opponent's new HP
                if (//opponent's HP not deplenished
                    )
                {
                    //set to opponent's turn
                }
                else
                {
                    //go to game over screen
                    ScreenControl.changeScreen(this, "MultiEndScreen");
                }

            }
            else
            {
                //set to opponent's turn
            }
        }

        public double criteriaChart()
        {

        }

        public double defenderBot() //Justin got this
        {

        }

        public double Dissection()//Cayla is programming
        {
            //know if player's move continues out sucessfully
            int accuracyHit = randNum.Next(1,101);

            if (accuracyHit <= 95)
            {
                //show animation
                //play sound(s)
                //calculate damage opponent takes
                //calculate amount of HP opponent has left
                //display opponent's new HP
                if (//opponent's HP not deplenished
                    )
                {
                    //set to opponent's turn
                }
                else
                {
                    //go to game over screen
                }

            }
            else
            {
                //set to opponent's turn
            }
        }

        public double Dodgeball(double playerAtk, double opponentDef, double opponentHP) //Justin got this
        {
            //know if player's move continues out sucessfully
            int accuracyHit = randNum.Next(1,101);
            double damage;

            if (accuracyHit <= 90)
            {
                //show animation
                //play sound(s)
                damage = (((42 * playerAtk * 100 / opponentDef) / 50) + 2) 
                    * randNum.Next(1,101) / 100;
                opponentHP = opponentHP - damage;
                
                if (//opponent's HP not deplenished
                    )
                {
                    //set to opponent's turn
                }
                else
                {
                    //go to game over screen
                }

            }
            else
            {
                //set to opponent's turn
            }
        }

        public double DunkOn()//Cayla is programming
        {
            //know if player's move continues out sucessfully
            int accuracyHit;//make random number between 0-100? or 0-10?

            if (accuracyHit > 30)
            {
                //show animation
                //play sound(s)
                //calculate damage opponent takes
                //calculate amount of HP opponent has left
                //display opponent's new HP
                if (//opponent's HP not deplenished
                    )
                {
                    //set to opponent's turn
                }
                else
                {
                    //go to game over screen
                }

            }
            else
            {
                //set to opponent's turn
            }
        }

        public double essayQuestion() //Justin got this
        {
            //know if player's move continues out sucessfully
            int accuracyHit;//make random number between 0-100? or 0-10?

            if (accuracyHit > 30)
            {
                //show animation
                //play sound(s)
                //calculate damage opponent takes
                //calculate amount of HP opponent has left
                //display opponent's new HP
                if (//opponent's HP not deplenished
                    )
                {
                    //set to opponent's turn
                }
                else
                {
                    //go to game over screen
                }

            }
            else
            {
                //set to opponent's turn
            }
        }

        public double FullBandFF()//Cayla is programming
        {
            if (ortSleep = 0)
            {
                //know if player's move continues out sucessfully
                int accuracyHit;//make random number between 0-100? or 0-10?

                if (accuracyHit > 10)
                {
                    //show animation
                    //play sound(s)
                    //calculate damage opponent takes
                    //calculate amount of HP opponent has left
                    //display opponent's new HP
                    if (//opponent's HP not deplenished
                    )
                    {
                        //set to opponent's turn
        }
                    else
                    {
                        //go to game over screen
                    }
                }
            else
            {
                //switch to opponent's turn
            }
        }
        public double MadExperiment()//Cayla is programming
        {
            //know if player's move continues out sucessfully
            int accuracyHit;//make random number between 0-100? or 0-10?

            if (accuracyHit > 30)
            {
                //show animation
                //play sound(s)
                //calculate damage opponent takes
                //calculate amount of HP opponent has left
                //display opponent's new HP
                if (//opponent's HP not deplenished
                    )
                {
                    //set to opponent's turn
                }
                else
                {
                    //go to game over screen
                }
            }
            else
            {
                //opponent's turn
            }
        }

        public double MultiQuestion() //Justin got this
        {

        }

        public double PinkPaper()//Cayla is programming
        {
            int accuracyHit;//make random number between 0-100? or 0-10?

            if (accuracyHit > 20)
            {
                //show animation/ slight difference in images
                //play sound(s)
                //calculate damage opponent takes
                //multiply by 0.5
                //use half the damage as addition to player's health
                //calculate amount of HP opponent has left
                //display opponent's and player's new HP
                if (//opponent's HP not deplenished
                    )
                {
                    //set to opponent's turn
                }
                else
                {
                    //go to game over screen
                }
            }
            else
            {
                //opponent's turn
            }
        }

        public double quadraticAttack() //Justin got this
        {

        }

        public double TalkAboutFamily()//Cayla is programming
        {
            //increase player's current defence by one stage
        }

        public double tuning() //Justin got this
        {

        }
        public double VideoFriday()//Cayla is programming
        {
            //add 1/2 of Bradshaw's max HP to HP remaining
        }
    }
}
