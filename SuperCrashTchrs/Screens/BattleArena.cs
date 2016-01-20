///Super Crash Teachers Battle Arena
///By Cayla, Hannah, Justin
/// 25 January 2016
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

        string p1character, p2character;
        int p1hp, p1Atk, p1Def, p1Spd, p2hp, p2Atk, p2Def, p2Spd;

        #region Player Stats
        //Should these be constants?
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

        public BattleArena()
        {
            InitializeComponent();
            moveSelectTimer.Enabled = true;
            p1character = "Bond";
            p2character = "Brad";

            #region Stat Switchs 
            switch (p1character)
            {
                case "Bond":
                    p1hp = bondHP;
                    p1Atk = bondAtk;
                    p1Def = bondDef;
                    p1Spd = bondSpd;
                    break;
                case "Brad":
                    p1hp = bradHP;
                    p1Atk = bradAtk;
                    p1Def = bradDef;
                    p1Spd = bradSpd;
                    break;
                case "Leitch":
                    p1hp = leitchHP;
                    p1Atk = leitchAtk;
                    p1Def = leitchDef;
                    p1Spd = leitchSpd;
                    break;
                case "Cutch":
                    p1hp = cutchHP;
                    p1Atk = cutchAtk;
                    p1Def = cutchDef;
                    p1Spd = cutchSpd;
                    break;
                case "Ort":
                    p1hp = ortHP;
                    p1Atk = ortAtk;
                    p1Def = ortDef;
                    p1Spd = ortSpd;
                    break;
                case "Steel":
                    p1hp = steelHP;
                    p1Atk = steelAtk;
                    p1Def = steelDef;
                    p1Spd = steelSpd;
                    break;
                default:
                    break;
            }
            switch (p2character)
            {
                case "Bond":
                    p2hp = bondHP;
                    p2Atk = bondAtk;
                    p2Def = bondDef;
                    p2Spd = bondSpd;
                    break;
                case "Brad":
                    p2hp = bradHP;
                    p2Atk = bradAtk;
                    p2Def = bradDef;
                    p2Spd = bradSpd;
                    break;
                case "Leitch":
                    p2hp = leitchHP;
                    p2Atk = leitchAtk;
                    p2Def = leitchDef;
                    p2Spd = leitchSpd;
                    break;
                case "Cutch":
                    p2hp = cutchHP;
                    p2Atk = cutchAtk;
                    p2Def = cutchDef;
                    p2Spd = cutchSpd;
                    break;
                case "Ort":
                    p2hp = ortHP;
                    p2Atk = ortAtk;
                    p2Def = ortDef;
                    p2Spd = ortSpd;
                    break;
                case "Steel":
                    p2hp = steelHP;
                    p2Atk = steelAtk;
                    p2Def = steelDef;
                    p2Spd = steelSpd;
                    break;
                default:
                    break;
            }
            #endregion
        }
        
        public static Random randNum = new Random();


      

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

        public double AttackBot() //Hannah has this one
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

        public double ComplainAbout() //Cayla is programming
        {
            //know if player's move continues out sucessfully
            int accuracyHit = randNum.Next(1, 101);

            //

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

        public double criteriaChart() //Hannah ftw
        {
            //display message
            //increase Bond's attack by 25
            bondAtk += 25;
            //increase Bond's speed by 25
            bondSpd += 25;
            if (bondAtk > 250 || bondSpd > 250)
            {
                bondAtk = 250;
                bondSpd = 250;
                return bondAtk;
                return bondSpd;
            } else
            {
                return bondAtk;
                return bondSpd;
            }
        }

        public double defenderBot() //Justin got this
        {

        }

        public double Dissection(double playerAtk, double opponentDef, double opponentHP)//Cayla is programming
        {
            //local variables called
            double damage;

            //know if player's move continues out sucessfully
            int accuracyHit = randNum.Next(1,101);

            if (accuracyHit <= 95)
            {
                //show animation
                //play sound(s)
                //calculate damage opponent takes
                damage = (((42 * playerAtk * 30 / opponentDef) / 50) + 2)
                  * randNum.Next(1, 101) / 100;

                //calculate amount of HP opponent has left
                opponentHP = opponentHP - damage;
                
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

        public double Documentary() //Hannah McSwag
        {
            //check if leitch is asleep
            if (leitchSleep != 0)
            {
                //if asleep pass the turn
                leitchSleep--;
                return leitchSleep;
                //display sleep message
            }
            else //leitch is awake
            {
                //little text message description
                //restore leitch's HP to full
                leitchHP = 200;
                return leitchHP;
                //display HP at full
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
            int accuracyHit = randNum.Next(1,101);

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
                    ScreenControl.changeScreen(this, "MultiEndScreen");
                }

            }
            else
            {
                //set to opponent's turn
            }
        }

        public double EqualSign() //Hannah ftw
        {
            double splitHP = (steelHP + ) / 2;

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
            if (ortSleep == 0)
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
                    if ( /*opponent's HP not deplenished*/)
                    {

                    }
                    else
                    {
                        //go to game over screen
                        ScreenControl.changeScreen(this, "MultiEndScreen");
                    }
                }
            }
            else
            {
                //switch to opponent's turn
            }
        }

        public double HealthClass()
        {

        }

        public double MadExperiment(double playerAtk, double opponentDef, double opponentHP)//Cayla is programming
        {
            //local variables called
            double damage;

            //know if player's move continues out sucessfully
            int accuracyHit = randNum.Next(1,101);

            if (accuracyHit > 30)
            {
                //show animation
                //play sound(s)
                //calculate damage opponent takes
                damage = (((42 * playerAtk * 100 / opponentDef) / 50) + 2)
                  * randNum.Next(1, 101) / 100;
                //calculate amount of HP opponent has left
                opponentHP = opponentHP - damage;
                
                //display opponent's new HP
                if (/*opponent's HP not deplenished*/)
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
                //opponent's turn
            }
        }

        public double MelodiousPassage()
        {

        }

        public double MultiQuestion() //Justin got this
        {
            

        }

        public double PinkPaper()//Cayla is programming
        {
            int accuracyHit = randNum.Next(1, 101);

            if (accuracyHit > 20)
            {
                //show animation/ slight difference in images
                //play sound(s)
                //calculate damage opponent takes
                //multiply by 0.5
                //use half the damage as addition to player's health
                //calculate amount of HP opponent has left
                //display opponent's and player's new HP
                if (/*opponent's HP not deplenished*/)
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
                //opponent's turn
            }
        }

        public int PushUps()
        {
            //display status message
            //add 25 to mccutcheons attack stat
            cutchAtk += 25;
            //make sure it doesn't exceed
            if (cutchAtk > 250)
            {
                //set to max attack stat
                cutchAtk = 250;
                return cutchAtk;
                //display message 
            }
            else {
                return cutchAtk;
            }
        }

        public double QuadraticAttack() //Justin got this
        {

        }

        public int TalkAboutFamily()//Cayla is programming
        {
            //message displayed
            //increase player's current defence by one stage
            bondDef += 25;
            
            if(bondDef >200)
                {
                //set to max defence
                bondDef = 200;
                return bondDef;
            }
            else
            {
                return bondDef;
            }
        }

        public int TextbookBarricade()
        {

        }

        public double Tuning() //Justin got this
        {
            //player one uses move
            if (p1character == "Ort")
            {
                p1hp = p1hp + 88;
                if (p1hp < 175)
                {
                    p1hp = 175;
                }
            }
            //player 2 uses move
            if (p2character == "Ort")
            {
                p2hp = p2hp + 88;
                if (p2hp < 175)
                {
                    p2hp = 175;
                }
            }
        }
        


        private void moveSelectTimer_Tick(object sender, EventArgs e)
        {
            if (p1moveSelect == true && p2moveSelect == true)
            {
                if (p1Spd > p2Spd)
                {
                    #region p1 Goes First
                    if (p1move1 == true)
                    {
                        switch (p1character)
                        {
                            case "Bond":
                                //CriteraChart
                                break;
                            case "Brad":
                                //AttackBot
                                break;
                            case "Leitch":
                                //Documentary
                                break;
                            case "Cutch":
                                //DODGEBALL
                                break;
                            case "Ort":
                                //ClairinetSqueak
                                break;
                            case "Steel":
                                //EqualSign
                                break;
                            default:
                                break;
                }
                    }
                    if (p1move2 == true)
                    {
                        switch (p1character)
                        {
                            case "Bond":
                                //Dissection
                                break;
                            case "Brad":
                                //ComplainBout
                                break;
                            case "Leitch":
                                //EssayQuestion
                                break;
                            case "Cutch":
                                //DunkOn
                                break;
                            case "Ort":
                                //FullBandFF
                                break;
                            case "Steel":
                                //PinkPaper
                                break;
                            default:
                                break;
                        }
                    }
                    if (p1move3 == true)
                    {
                        switch (p1character)
                        {
                            case "Bond":
                                //MadExperiment
                                break;
                            case "Brad":
                                //DefenderBot
                                break;
                            case "Leitch":
                                //HistoricWar
                                break;
                            case "Cutch":
                                //PushUps
                                break;
                            case "Ort":
                                //MelodiousPassage
                                break;
                            case "Steel":
                                //QuadraticAttack
                                break;
                            default:
                                break;
                        }
                    }
                    if (p1move4 == true)
                    {
                        switch (p1character)
                        {
                            case "Bond":
                                //TalkBoutFamily
                                break;
                            case "Brad":
                                //VideoFriday
                                break;
                            case "Leitch":
                                //MCQuestion
                                break;
                            case "Cutch":
                                //HealthClass
                                break;
                            case "Ort":
                                //Tuning
                                break;
                            case "Steel":
                                //TextbookBarricade
                                break;
                            default:
                                break;
                        }
                    }
                    # endregion

                    #region p2 Goes Second
                    if (p2move1 == true)
                    {
                        switch (p2character)
                        {
                            case "Bond":
                                //CriteraChart
                                break;
                            case "Brad":
                                //AttackBot
                                break;
                            case "Leitch":
                                //Documentary
                                break;
                            case "Cutch":
                                //DODGEBALL
                                break;
                            case "Ort":
                                //ClairinetSqueak
                                break;
                            case "Steel":
                                //EqualSign
                                break;
                            default:
                                break;
                        }
                    }
                    if (p2move2 == true)
                    {
                        switch (p2character)
                        {
                            case "Bond":
                                //Dissection
                                break;
                            case "Brad":
                                //ComplainBout
                                break;
                            case "Leitch":
                                //EssayQuestion
                                break;
                            case "Cutch":
                                //DunkOn
                                break;
                            case "Ort":
                                //FullBandFF
                                break;
                            case "Steel":
                                //PinkPaper
                                break;
                            default:
                                break;
                        }
                    }
                    if (p2move3 == true)
                    {
                        switch (p2character)
                        {
                            case "Bond":
                                //MadExperiment
                                break;
                            case "Brad":
                                //DefenderBot
                                break;
                            case "Leitch":
                                //HistoricWar
                                break;
                            case "Cutch":
                                //PushUps
                                break;
                            case "Ort":
                                //MelodiousPassage
                                break;
                            case "Steel":
                                //QuadraticAttack
                                break;
                            default:
                                break;
                        }
                    }
                    if (p2move4 == true)
                    {
                        switch (p2character)
                        {
                            case "Bond":
                                //TalkBoutFamily
                                break;
                            case "Brad":
                                //VideoFriday
                                break;
                            case "Leitch":
                                //MCQuestion
                                break;
                            case "Cutch":
                                //HealthClass
                                break;
                            case "Ort":
                                //Tuning
                                break;
                            case "Steel":
                                //TextbookBarricade
                                break;
                            default:
                                break;
                        }
                    }
                    # endregion
                }
                else if (p1Spd < p2Spd)
                {
                    #region p2 Goes First
                    if (p2move1 == true)
                    {
                        switch (p2character)
                        {
                            case "Bond":
                                //CriteraChart
                                break;
                            case "Brad":
                                //AttackBot
                                break;
                            case "Leitch":
                                //Documentary
                                break;
                            case "Cutch":
                                //DODGEBALL
                                break;
                            case "Ort":
                                //ClairinetSqueak
                                break;
                            case "Steel":
                                //EqualSign
                                break;
                            default:
                                break;
                        }
                    }
                    if (p2move2 == true)
                    {
                        switch (p2character)
                        {
                            case "Bond":
                                //Dissection
                                break;
                            case "Brad":
                                //ComplainBout
                                break;
                            case "Leitch":
                                //EssayQuestion
                                break;
                            case "Cutch":
                                //DunkOn
                                break;
                            case "Ort":
                                //FullBandFF
                                break;
                            case "Steel":
                                //PinkPaper
                                break;
                            default:
                                break;
                        }
                    }
                    if (p2move3 == true)
                    {
                        switch (p2character)
                        {
                            case "Bond":
                                //MadExperiment
                                break;
                            case "Brad":
                                //DefenderBot
                                break;
                            case "Leitch":
                                //HistoricWar
                                break;
                            case "Cutch":
                                //PushUps
                                break;
                            case "Ort":
                                //MelodiousPassage
                                break;
                            case "Steel":
                                //QuadraticAttack
                                break;
                            default:
                                break;
                        }
                    }
                    if (p2move4 == true)
                    {
                        switch (p2character)
                        {
                            case "Bond":
                                //TalkBoutFamily
                                break;
                            case "Brad":
                                //VideoFriday
                                break;
                            case "Leitch":
                                //MCQuestion
                                break;
                            case "Cutch":
                                //HealthClass
                                break;
                            case "Ort":
                                //Tuning
                                break;
                            case "Steel":
                                //TextbookBarricade
                                break;
                            default:
                                break;
                        }
                    }
                    # endregion

                    #region p1 Goes Second
                    if (p1move1 == true)
                    {
                        switch (p1character)
                        {
                            case "Bond":
                                //CriteraChart
                                break;
                            case "Brad":
                                //AttackBot
                                break;
                            case "Leitch":
                                //Documentary
                                break;
                            case "Cutch":
                                //DODGEBALL
                                break;
                            case "Ort":
                                //ClairinetSqueak
                                break;
                            case "Steel":
                                //EqualSign
                                break;
                            default:
                                break;
                        }
                    }
                    if (p1move2 == true)
                    {
                        switch (p1character)
                        {
                            case "Bond":
                                //Dissection
                                break;
                            case "Brad":
                                //ComplainBout
                                break;
                            case "Leitch":
                                //EssayQuestion
                                break;
                            case "Cutch":
                                //DunkOn
                                break;
                            case "Ort":
                                //FullBandFF
                                break;
                            case "Steel":
                                //PinkPaper
                                break;
                            default:
                                break;
                        }
                    }
                    if (p1move3 == true)
                    {
                        switch (p1character)
                        {
                            case "Bond":
                                //MadExperiment
                                break;
                            case "Brad":
                                //DefenderBot
                                break;
                            case "Leitch":
                                //HistoricWar
                                break;
                            case "Cutch":
                                //PushUps
                                break;
                            case "Ort":
                                //MelodiousPassage
                                break;
                            case "Steel":
                                //QuadraticAttack
                                break;
                            default:
                                break;
                        }
                    }
                    if (p1move4 == true)
                    {
                        switch (p1character)
                        {
                            case "Bond":
                                //TalkBoutFamily
                                break;
                            case "Brad":
                                //VideoFriday
                                break;
                            case "Leitch":
                                //MCQuestion
                                break;
                            case "Cutch":
                                //HealthClass
                                break;
                            case "Ort":
                                //Tuning
                                break;
                            case "Steel":
                                //TextbookBarricade
                                break;
                            default:
                                break;
                        }
                    }
                    # endregion
                }
                else if (p1Spd == p2Spd)
                {
                        #region p1 First Speed Tie
                                case "Bond":
                                    //CriteraChart
                                    break;
                                case "Brad":
                                    //AttackBot
                                    break;
                                case "Leitch":
                                    //Documentary
                                    break;
                                case "Cutch":
                                    //DODGEBALL
                                    break;
                                case "Ort":
                                    //ClairinetSqueak
                                    break;
                                case "Steel":
                                    //EqualSign
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (p1move2 == true)
                        {
                            switch (p1character)
                            {
                                case "Bond":
                                    //Dissection
                                    break;
                                case "Brad":
                                    //ComplainBout
                                    break;
                                case "Leitch":
                                    //EssayQuestion
                                    break;
                                case "Cutch":
                                    //DunkOn
                                    break;
                                case "Ort":
                                    //FullBandFF
                                    break;
                                case "Steel":
                                    //PinkPaper
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (p1move3 == true)
                        {
                            switch (p1character)
                            {
                                case "Bond":
                                    //MadExperiment
                                    break;
                                case "Brad":
                                    //DefenderBot
                                    break;
                                case "Leitch":
                                    //HistoricWar
                                    break;
                                case "Cutch":
                                    //PushUps
                                    break;
                                case "Ort":
                                    //MelodiousPassage
                                    break;
                                case "Steel":
                                    //QuadraticAttack
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (p1move4 == true)
                        {
                            switch (p1character)
                            {
                                case "Bond":
                                    //TalkBoutFamily
                                    break;
                                case "Brad":
                                    //VideoFriday
                                    break;
                                case "Leitch":
                                    //MCQuestion
                                    break;
                                case "Cutch":
                                    //HealthClass
                                    break;
                                case "Ort":
                                    //Tuning
                                    break;
                                case "Steel":
                                    //TextbookBarricade
                                    break;
                                default:
                                    break;
                            }
                        }
#endregion
                  
                        #region p2 Second Speed Tie
                        if (p2move1 == true)
                        {
                            switch (p2character)
                            {
                                case "Bond":
                                    //CriteraChart
                                    break;
                                case "Brad":
                                    //AttackBot
                                    break;
                                case "Leitch":
                                    //Documentary
                                    break;
                                case "Cutch":
                                    //DODGEBALL
                                    break;
                                case "Ort":
                                    //ClairinetSqueak
                                    break;
                                case "Steel":
                                    //EqualSign
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (p2move2 == true)
                        {
                            switch (p2character)
                            {
                                case "Bond":
                                    //Dissection
                                    break;
                                case "Brad":
                                    //ComplainBout
                                    break;
                                case "Leitch":
                                    //EssayQuestion
                                    break;
                                case "Cutch":
                                    //DunkOn
                                    break;
                                case "Ort":
                                    //FullBandFF
                                    break;
                                case "Steel":
                                    //PinkPaper
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (p2move3 == true)
                        {
                            switch (p2character)
                            {
                                case "Bond":
                                    //MadExperiment
                                    break;
                                case "Brad":
                                    //DefenderBot
                                    break;
                                case "Leitch":
                                    //HistoricWar
                                    break;
                                case "Cutch":
                                    //PushUps
                                    break;
                                case "Ort":
                                    //MelodiousPassage
                                    break;
                                case "Steel":
                                    //QuadraticAttack
                                    break;
                                default:
                                    break;
                }
            }
                        if (p2move4 == true)
                        {
                            switch (p2character)
                            {
                                case "Bond":
                                    //TalkBoutFamily
                                    break;
                                case "Brad":
                                    //VideoFriday
                                    break;
                                case "Leitch":
                                    //MCQuestion
                                    break;
                                case "Cutch":
                                    //HealthClass
                                    break;
                                case "Ort":
                                    //Tuning
                                    break;
                                case "Steel":
                                    //TextbookBarricade
                                    break;
                                default:
                                    break;
                            }
                        }
                        # endregion
                        #region p2 First Speed Tie
                        if (p2move1 == true)
                        {
                            switch (p2character)
                            {
                                case "Bond":
                                    //CriteraChart
                                    break;
                                case "Brad":
                                    //AttackBot
                                    break;
                                case "Leitch":
                                    //Documentary
                                    break;
                                case "Cutch":
                                    //DODGEBALL
                                    break;
                                case "Ort":
                                    //ClairinetSqueak
                                    break;
                                case "Steel":
                                    //EqualSign
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (p2move2 == true)
                        {
                            switch (p2character)
                            {
                                case "Bond":
                                    //Dissection
                                    break;
                                case "Brad":
                                    //ComplainBout
                                    break;
                                case "Leitch":
                                    //EssayQuestion
                                    break;
                                case "Cutch":
                                    //DunkOn
                                    break;
                                case "Ort":
                                    //FullBandFF
                                    break;
                                case "Steel":
                                    //PinkPaper
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (p2move3 == true)
                        {
                            switch (p2character)
                            {
                                case "Bond":
                                    //MadExperiment
                                    break;
                                case "Brad":
                                    //DefenderBot
                                    break;
                                case "Leitch":
                                    //HistoricWar
                                    break;
                                case "Cutch":
                                    //PushUps
                                    break;
                                case "Ort":
                                    //MelodiousPassage
                                    break;
                                case "Steel":
                                    //QuadraticAttack
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (p2move4 == true)
                        {
                            switch (p2character)
                            {
                                case "Bond":
                                    //TalkBoutFamily
                                    break;
                                case "Brad":
                                    //VideoFriday
                                    break;
                                case "Leitch":
                                    //MCQuestion
                                    break;
                                case "Cutch":
                                    //HealthClass
                                    break;
                                case "Ort":
                                    //Tuning
                                    break;
                                case "Steel":
                                    //TextbookBarricade
                                    break;
                                default:
                                    break;
                            }
                        }
                        # endregion
                  
                        #region p1 Second Speed Tie
                        //p1 goes first
                        if (p1move1 == true)
                        {
                            switch (p1character)
                            {
                                case "Bond":
                                    //CriteraChart
                                    break;
                                case "Brad":
                                    //AttackBot
                                    break;
                                case "Leitch":
                                    //Documentary
                                    break;
                                case "Cutch":
                                    //DODGEBALL
                                    break;
                                case "Ort":
                                    //ClairinetSqueak
                                    break;
                                case "Steel":
                                    //EqualSign
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (p1move2 == true)
                        {
                            switch (p1character)
                            {
                                case "Bond":
                                    //Dissection
                                    break;
                                case "Brad":
                                    //ComplainBout
                                    break;
                                case "Leitch":
                                    //EssayQuestion
                                    break;
                                case "Cutch":
                                    //DunkOn
                                    break;
                                case "Ort":
                                    //FullBandFF
                                    break;
                                case "Steel":
                                    //PinkPaper
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (p1move3 == true)
                        {
                            switch (p1character)
                            {
                                case "Bond":
                                    //MadExperiment
                                    break;
                                case "Brad":
                                    //DefenderBot
                                    break;
                                case "Leitch":
                                    //HistoricWar
                                    break;
                                case "Cutch":
                                    //PushUps
                                    break;
                                case "Ort":
                                    //MelodiousPassage
                                    break;
                                case "Steel":
                                    //QuadraticAttack
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (p1move4 == true)
                        {
                            switch (p1character)
                            {
                                case "Bond":
                                    //TalkBoutFamily
                                    break;
                                case "Brad":
                                    //VideoFriday
                                    break;
                                case "Leitch":
                                    //MCQuestion
                                    break;
                                case "Cutch":
                                    //HealthClass
                                    break;
                                case "Ort":
                                    //Tuning
                                    break;
                                case "Steel":
                                    //TextbookBarricade
                                    break;
                                default:
                                    break;
                }
            }
                        #endregion                                              
            else
            {

            }
        }
    }
}
