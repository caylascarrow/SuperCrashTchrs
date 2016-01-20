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
using System.Threading;

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
        int p1hp, p1Atk, p1Def, p1Spd, p1Sprite, p2hp, p2Atk, p2Def, p2Spd, p2Sprite;
        int sleepTime = 1000;

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
                    p1Sprite = bondSprite;
                    break;
                case "Brad":
                    p1hp = bradHP;
                    p1Atk = bradAtk;
                    p1Def = bradDef;
                    p1Spd = bradSpd;
                    p1Sprite = bradSprite;
                    break;
                case "Leitch":
                    p1hp = leitchHP;
                    p1Atk = leitchAtk;
                    p1Def = leitchDef;
                    p1Spd = leitchSpd;
                    p1Sprite = leitchSprite;
                    break;
                case "Cutch":
                    p1hp = cutchHP;
                    p1Atk = cutchAtk;
                    p1Def = cutchDef;
                    p1Spd = cutchSpd;
                    p1Sprite = cutchSprite;
                    break;
                case "Ort":
                    p1hp = ortHP;
                    p1Atk = ortAtk;
                    p1Def = ortDef;
                    p1Spd = ortSpd;
                    p1Sprite = ortSprite;
                    break;
                case "Steel":
                    p1hp = steelHP;
                    p1Atk = steelAtk;
                    p1Def = steelDef;
                    p1Spd = steelSpd;
                    p1Sprite = steelSprtie;
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


      
        //Button Presses
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
        
        public double AttackBot() //Hannah has this one
        {

        }

        public void ClarinetSqueak() //Justin got this
        {
            int opponentDef = 0;
            if (p1character == "Ort")
            {
                opponentDef = p2Def;
            }
            else if (p2character == "Ort")
            {
                opponentDef = p1Def;
            }
            battleStatusOutput.Text = "Ortelli used Clairinet Squeak!";
            Thread.Sleep(sleepTime);
            opponentDef -= 25;
            battleStatusOutput.Text = "The opponents defence was lowered!";
            Thread.Sleep(sleepTime);
            
            if (opponentDef <= 0)
            {
                opponentDef = 1;
                battleStatusOutput.Text = "The opponents defence cannot go any lower!";
                Thread.Sleep(sleepTime);
            }

            if (p1character == "Ort")
            {
                p2Def = opponentDef;
            }
            else if (p2character == "Ort")
            {
                p1Def = opponentDef;
            }
        }

        public double ComplainAbout(double playerAtk, double opponentDef, double opponentHP) //Cayla is programming
        {
            //local variables called
            double damage;
            //know if player's move continues out sucessfully
            int accuracyHit = randNum.Next(1, 101);

            if (accuracyHit > 10)
            {
                //show animation
                //play sound(s)
                //calculate damage opponent takes
                damage = (((42 * playerAtk * 75 / opponentDef) / 50) + 2)
                * randNum.Next(1, 101) / 100;
                //calculate amount of HP opponent has left
                opponentHP = opponentHP - damage;
                //display opponent's new HP
                if (opponentHP > 0)
                {
                    return opponentHP;
                }
                else
                {
                    //go to game over screen
                    ScreenControl.changeScreen(this, "MultiEndScreen");
                }

            }
            else
            {
                //send move failed message
            }
        }

        public void CriteriaChart() //All DONE
        {
            int userAtk = 0; 
            int userSpd = 0;
            if (p1character == "Bond")
            {
                userAtk = p1Atk;
                userSpd = p1Spd;
            }
            else if (p2character == "Bond")
            {
                userAtk = p2Atk;
                userSpd = p2Spd;
            }            
            battleStatusOutput.Text = "Bond used Critera Chart!";
            Thread.Sleep(sleepTime);

            userAtk += 25;
            battleStatusOutput.Text = "Bonds Attack rose!";
            Thread.Sleep(sleepTime);
            if (userAtk > 250)
            {
                userAtk = 250;
                battleStatusOutput.Text = "Bonds Attack can't go any higher!";
                Thread.Sleep(sleepTime);
            }

            userSpd += 25;
            battleStatusOutput.Text = "Bonds Speed rose!";
            Thread.Sleep(sleepTime);
            if (userSpd > 250)
            {
                userSpd = 250;
                battleStatusOutput.Text = "Bonds Speed can't go any higher!";
                Thread.Sleep(sleepTime);
            }            
            if (p1character == "Bond")
            {
                p1Atk = userAtk;
                p1Spd = userSpd;
            }
            else if (p2character == "Bond")
            {
                userAtk = p2Atk;
                userSpd = p2Spd;
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

                if (opponentHP > 0)
                {
                    //display opponent's HP
                    return opponentHP;
                }
                else
                {
                    //go to game over screen
                    ScreenControl.changeScreen(this, "MultiEndScreen");
                }

            }
            else
            {
              //output attack failed message
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

        public double Dodgeball(double playerAtk, double playerDef, double opponentDef, double opponentHP) //Justin got this
        {     
            int accuracyHit = randNum.Next(1,101);
            double damage;
            //check accuracy
            if (accuracyHit <= 90)
            {
                //show animation
                
                damage = (((42 * playerAtk * 100 / opponentDef) / 50) + 2) 
                    * randNum.Next(1,101) / 100;
                opponentHP -= damage;
                //for (int i = 100/*oponents HPbar length*/; i == opponentHP; i--)
                //{
                //    p1HPBar.Size = (i, 10);
                //}
                //lower user atk
                playerAtk -= 25;
                if (playerAtk <= 0)
                {
                    playerAtk = 1;
                }
                //lower user def
                playerDef -= 25;
                if (playerDef <= 0)
                {
                    playerDef = 1;
                }
                

                if (opponentHP > 0)
                {
                    
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

        public double DunkOn(double playerAtk, double opponentDef, double opponentHP)//Cayla is programming
        {
            //local variables created
            double damage;
            //know if player's move continues out sucessfully
            int accuracyHit = randNum.Next(1,101);

            if (accuracyHit > 30)
            {
                //show animation
                //play sound(s)
                //calculate damage opponent takes
                damage = (((42 * playerAtk * 90 / opponentDef) / 50) + 2)
                 * randNum.Next(1, 101) / 100;

                //calculate amount of HP opponent has left
                opponentHP = opponentHP - damage;

                //display opponent's new HP
                if (opponentHP > 0)
                {
                    return opponentHP;
                }
                else
                {
                    //go to game over screen
                    ScreenControl.changeScreen(this, "MultiEndScreen");
                }

            }
            else
            {
                //send move failed message
            }
        }

        public double EqualSign() //Hannah ftw
        {
            if (p1character == "Steel")
            {

            }

        }

        public void EssayQuestion() //Justin got this
        {
            int opponentSpd = 0;
            if (p1character == "Leitch")
            {
                opponentSpd = p2Spd;
            }
            else if (p2character == "Leitch")
            {
                opponentSpd = p1Spd;
            }
            battleStatusOutput.Text = "Leitch Used Multiple Choice Question!";
            Thread.Sleep(sleepTime);
            //accuracy
            if (randNum.Next(1, 101) <= 80)
            {
                opponentSpd -= 50;
                battleStatusOutput.Text = "The Opponents Speed was lowered!";
                Thread.Sleep(sleepTime);

                if (opponentSpd <= 0)
                {
                    opponentSpd = 1;
                    battleStatusOutput.Text = "The Opponents Speed can't go any lower!";
                    Thread.Sleep(sleepTime);
                }
                else
                {
                    battleStatusOutput.Text = "But it missed!";
                    Thread.Sleep(sleepTime);
                }
            }
            if (p1character == "Leitch")
            {
                p2Spd = opponentSpd;
            }
            else if (p2character == "Leitch")
            {
                p1Spd = opponentSpd;
            }
        }

        public double FullBandFF(double playerAtk, double opponentDef, double opponentHP)//Cayla is programming
        {
            if (ortSleep == 0)
            {
                //local variables called
                double damage;
                //know if player's move continues out sucessfully
                int accuracyHit = randNum.Next(1, 101);

                if (accuracyHit > 10)
                {
                    //show animation
                    //play sound(s)
                    //calculate damage opponent takes
                    damage = (((42 * playerAtk * 120 / opponentDef) / 50) + 2)
                    * randNum.Next(1, 101) / 100;
                    //calculate amount of HP opponent has left
                    opponentHP = opponentHP - damage;
                    //display opponent's new HP
                    if (opponentHP > 0)
                    {
                        return opponentHP;
                    }
                    else
                    {
                        //go to game over screen
                        ScreenControl.changeScreen(this, "MultiEndScreen");
                    }
                }
                else
                {
                    //send move failed message
                }
            }
            else
            {
                //send ortelli is too tired message
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
               
                //check if opponent has been defeated
                if (opponentHP > 0)
                {
                    //display opponent's new HP
                    return opponentHP;

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
                //send move failed message 
            }
        }

        public double MelodiousPassage()
        {

        }

        public void MultiQuestion() //Justin got this
        {            
            
        }

        public double PinkPaper(double playerAtk, double playerHP, double opponentDef, double opponentHP)//Cayla is programming
        {
            // local variables called
            double damage;
            double playerHpUp;
            int accuracyHit = randNum.Next(1, 101);

            if (accuracyHit > 20)
            {
                //show animation/ slight difference in images
                //play sound(s)
                //calculate damage opponent takes
                damage = (((42 * playerAtk * 50 / opponentDef) / 50) + 2)
               * randNum.Next(1, 101) / 100;

                //multiply by 0.5
                playerHpUp = damage * 0.5;

                //use half the damage as addition to player's health
                playerHP = playerHpUp + damage;

                //calculate amount of HP opponent has left
                opponentHP = opponentHP - damage;

                //display opponent's and player's new HP
                if (opponentHP > 0)
                {
                    return opponentHP;
                }
                else
                {
                    //go to game over screen
                    ScreenControl.changeScreen(this, "MultiEndScreen");
                }
            }
            else
            {
                //send move failed message
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

        public int TalkAboutFamily(int bondDef)//Cayla is programming
        {
            //message displayed
            //increase player's current defence by one stage
            bondDef += 25;
            
            if(bondDef >250)
                {
                //set to max defence
                bondDef = 250;
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

        public int Tuning(int playerHP) //Justin got this
        {
            playerHP += 88;
            if (playerHP < 175)
            {
                playerHP = 175;
            }
            return playerHP;    
        }

        public int VideoFriday(int playerHP)//Cayla's programming
        {
            playerHP += 75;
            if (playerHP > 150)
            {
                playerHP = 150;
            }
            return playerHP;
        }

        private void moveSelectTimer_Tick(object sender, EventArgs e)
        {
            if (p1moveSelect == true && p2moveSelect == true)
            {
                moveSelectTimer.Enabled = false;
                if (p1Spd > p2Spd)
                {
                    ///make these the master copies
                    #region p1 Goes First
                    #region move 1
                    if (p1move1 == true)
                    {
                        switch (p1character)
                        {
                            case "Bond":
                                CriteriaChart();
                                break;
                            case "Brad":
                                //AttackBot
                                break;
                            case "Leitch":
                                //Documentary
                                break;
                            case "Cutch":
                                Dodgeball(p1Atk, p1Def, p2Def, p2hp);
                                break;
                            case "Ort":
                                ClarinetSqueak(p2Def);
                                break;
                            case "Steel":
                                //EqualSign
                                break;
                            default:
                                break;
                        }
                    }
                    #endregion

                    #region move 2
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
                                EssayQuestion();
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
                    #endregion

                    #region move 3
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
                    #endregion

                    #region move 4
                    if (p1move4 == true)
                    {
                        switch (p1character)
                        {
                            case "Bond":
                                //TalkBoutFamily
                                TalkAboutFamily(p1Def);
                                break;
                            case "Brad":
                                VideoFriday(p1hp);
                                break;
                            case "Leitch":
                                MultiQuestion(p2Spd);
                                break;
                            case "Cutch":
                                //HealthClass
                                break;
                            case "Ort":
                                Tuning(p1hp);
                                break;
                            case "Steel":
                                //TextbookBarricade
                                break;
                            default:
                                break;
                        }
                    }
                    #endregion
                    #endregion

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
                    if (randNum.Next(1, 3) == 1)
                    {
                        #region p1 First Speed Tie
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
                    }
                    else
                    {
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
                    }                    
                }
                moveSelectTimer.Enabled = true;
            }
            else
            {

            }
        }
    }
}
