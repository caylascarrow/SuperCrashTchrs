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


        string p1character, p2character;
        int p1hp, p1Atk, p1Def, p1Spd, p2hp, p2Atk, p2Def, p2Spd;
        int sleepTime = 1000;

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
                    p1hp = (ScreenControl.bondHP);
                    p1Atk = (ScreenControl.bondAtk);
                    p1Def = (ScreenControl.bondDef);
                    p1Spd = (ScreenControl.bondSpd);
                    p1Sprite.Image = /*add bond's image name here*/ ;
                    break;
                case "Brad":
                    p1hp = (ScreenControl.bradHP);
                    p1Atk = (ScreenControl.bradAtk);
                    p1Def = (ScreenControl.bradDef);
                    p1Spd = (ScreenControl.bradSpd);
                    p1Sprite.Image = /*add brad's image name here*/;
                    break;
                case "Leitch":
                    p1hp = (ScreenControl.leitchHP);
                    p1Atk = (ScreenControl.leitchAtk);
                    p1Def = (ScreenControl.leitchDef);
                    p1Spd = (ScreenControl.leitchSpd);
                    p1Sprite.Image = /*add leitch's image name here*/;
                    break;
                case "Cutch":
                    p1hp = (ScreenControl.cutchHP);
                    p1Atk = (ScreenControl.cutchAtk);
                    p1Def = (ScreenControl.cutchDef);
                    p1Spd = (ScreenControl.cutchSpd);
                    p1Sprite.Image = /*add cutch's image name here*/;
                    break;
                case "Ort":
                    p1hp = (ScreenControl.ortHP);
                    p1Atk = (ScreenControl.ortAtk);
                    p1Def = (ScreenControl.ortDef);
                    p1Spd = (ScreenControl.ortSpd);
                    p1Sprite.Image = /*add ortelli's image name here*/;
                    break;
                case "Steel":
                    p1hp = (ScreenControl.steelHP);
                    p1Atk = (ScreenControl.steelAtk);
                    p1Def = (ScreenControl.steelDef);
                    p1Spd = (ScreenControl.steelSpd);
                    p1Sprite.Image = /*add steel's image name here*/;
                    break;
                default:
                    break;
            }
            switch (p2character)
            {
                case "Bond":
                    p2hp = (ScreenControl.bondHP);
                    p2Atk = (ScreenControl.bondAtk);
                    p2Def = (ScreenControl.bondDef);
                    p2Spd = (ScreenControl.bondSpd);
                    p2Sprite.Image = /*add bond's image name here*/;
                    break;
                case "Brad":
                    p2hp = (ScreenControl.bradHP);
                    p2Atk = (ScreenControl.bradAtk);
                    p2Def = (ScreenControl.bradDef);
                    p2Spd = (ScreenControl.bradSpd);
                    p2Sprite.Image = /*add brad's image name here*/;
                    break;
                case "Leitch":
                    p2hp = (ScreenControl.leitchHP);
                    p2Atk = (ScreenControl.leitchAtk);
                    p2Def = (ScreenControl.leitchDef);
                    p2Spd = (ScreenControl.leitchSpd);
                    p2Sprite.Image = /*add leitch's image name here*/;
                    break;
                case "Cutch":
                    p2hp = (ScreenControl.cutchHP);
                    p2Atk = (ScreenControl.cutchAtk);
                    p2Def = (ScreenControl.cutchDef);
                    p2Spd = (ScreenControl.cutchSpd);
                    p2Sprite.Image = /*add cutch's image name here*/;
                    break;
                case "Ort":
                    p2hp = (ScreenControl.ortHP);
                    p2Atk = (ScreenControl.ortAtk);
                    p2Def = (ScreenControl.ortDef);
                    p2Spd = (ScreenControl.ortSpd);
                    p2Sprite.Image = /*add ortelli's image name here*/;
                    break;
                case "Steel":
                    p2hp = (ScreenControl.steelHP);
                    p2Atk = (ScreenControl.steelAtk);
                    p2Def = (ScreenControl.steelDef);
                    p2Spd = (ScreenControl.steelSpd);
                    p2Sprite.Image = /*add steel's image name here*/;
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
        
        public void AttackBot() //Hannah has this one
        {
            int playerAtk = 1;
            int opponentDef = 1;
            int opponentHP = 0;
            int opponentAtk = 0;
            int damage = 0;
            if (p1character == "Brad")
            {
                playerAtk = p1Atk;
                opponentDef = p2Def;
                opponentHP = p2hp;
                opponentAtk = p2Atk;
            }
            else if (p2character == "Brad")
            {
                playerAtk = p2Atk;
                opponentDef = p1Def;
                opponentHP = p1hp;
                opponentAtk = p1Atk;
            }
            battleStatusOutput.Text = "Bradshaw used Attack Bot!";
            Thread.Sleep(sleepTime);

            if (randNum.Next(1,101) <= 95)
            {
                damage = (((42 * playerAtk * 40 / opponentDef) / 50) + 2)
                    * randNum.Next(1, 101) / 100;
                opponentHP -= damage;

                opponentAtk -= 25;
                battleStatusOutput.Text = "The opponents Defence was lowered!";
                Thread.Sleep(sleepTime);
                if (opponentAtk <= 0)
                {
                    opponentAtk = 1;
                    battleStatusOutput.Text = "The opponents Defence can't go any lower!";
                    Thread.Sleep(sleepTime);
                }
            }
            else
            {
                battleStatusOutput.Text = "But the opponent avoided the attack!";
            }
            
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

        public void TalkAboutFamily()//Cayla is programming
        {
            int playerHP = 0;
            int playerDef = 0;
            if (p1character == "Bond")
            {
                playerHP = p1hp;
                playerDef = p1Def;
            }
            if (p2character == "Bond")
            {
                playerHP = p2hp;
                playerDef = p2Def;
            }

            battleStatusOutput.Text = "Bond used Critera Chart!";
            Thread.Sleep(sleepTime);
            playerHP += 38;
            if (playerHP > 150)
            {
                playerHP = 150;
            }
            battleStatusOutput.Text = "Bond restored his HP!";
            Thread.Sleep(sleepTime);

            playerDef += 25;
            battleStatusOutput.Text = "Bonds Defence increased!";
            Thread.Sleep(sleepTime);
            if(playerDef >250)
            {                
                bondDef = 250;
                battleStatusOutput.Text = "Bonds Defence can't go any higher!";
                Thread.Sleep(sleepTime);
            }

            if (p1character == "Bond")
            {
                p1hp = playerHP;
                p1Def = playerDef;
            }
            if (p2character == "Bond")
            {
                p2hp = playerHP;
                p2Def = playerDef;
            }
        }

        public void TextbookBarricade()
        {

        }

        public void Tuning() //Justin got this
        {
            int playerHP = 0;
            if (p1character == "Ort")
            {
                playerHP = p1hp;
            }
            else if (p2character == "Ort")
            {
                playerHP = p2hp;
            }
            battleStatusOutput.Text = "Ortelli used Tuning!";
            Thread.Sleep(sleepTime);
            playerHP += 88;            
            if (playerHP < 175)
            {
                playerHP = 175;
            }
            battleStatusOutput.Text = "Ortelli restored her HP!";
            Thread.Sleep(sleepTime);

            if (p1character == "Ort")
            {
                p1hp = playerHP;
            }
            else if (p2character == "Ort")
            {
                p2hp = playerHP;
            }    
        }

        public void VideoFriday()//Cayla's programming
        {
            int playerHP = 0;
            if(p1character == "Brad")
            {
                playerHP = p1hp;
            }
            else if (p2character == "Brad")
            {
                playerHP = p2hp;
            }

            battleStatusOutput.Text = "Bradshaw used Video Friday!";
            Thread.Sleep(sleepTime);
            playerHP += 75;
            if (playerHP > 150)
            {
                playerHP = 150;
            }
            battleStatusOutput.Text = "Bradshaw restored his HP!";
            Thread.Sleep(sleepTime);

            if (p1character == "Brad")
            {
                p1hp = playerHP;
            }
            if (p2character == "Brad")
            {
                p2hp = playerHP;
            }
        }

        private void moveSelectTimer_Tick(object sender, EventArgs e)
        {
            if ((ScreenControl.p1moveSelect) == true && (ScreenControl.p2moveSelect) == true)
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
                                AttackBot();
                                break;
                            case "Leitch":
                                //Documentary
                                break;
                            case "Cutch":
                                Dodgeball(p1Atk, p1Def, p2Def, p2hp);
                                break;
                            case "Ort":
                                ClarinetSqueak();
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
                                TalkAboutFamily();
                                break;
                            case "Brad":
                                VideoFriday();
                                break;
                            case "Leitch":
                                MultiQuestion();
                                break;
                            case "Cutch":
                                //HealthClass
                                break;
                            case "Ort":
                                Tuning();
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
