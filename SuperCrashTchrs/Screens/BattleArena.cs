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

        bool p1moveSelect = false;
        bool p2moveSelect = false;

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

        //int leitchSleep = 0;
        //bool ortSleep = false;

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
                    p1Yellow.Text = "Critera Chart";
                    p1Blue.Text = "Dissection";
                    p1Red.Text = "Mad Experiment";
                    p1Green.Text = "Talk about Family";
                    p1Sprite.Image = SuperCrashTchrs.Properties.Resources.Bond_L;
                    break;
                case "Brad":
                    p1hp = (ScreenControl.bradHP);
                    p1Atk = (ScreenControl.bradAtk);
                    p1Def = (ScreenControl.bradDef);
                    p1Spd = (ScreenControl.bradSpd);
                    p1Yellow.Text = "Attack Bot";
                    p1Blue.Text = "Complain About Apple";
                    p1Red.Text = "Defender Bot";
                    p1Green.Text = "Video Friday";
                    p1Sprite.Image = SuperCrashTchrs.Properties.Resources.Bradshaw_L;
                    break;
                case "Leitch":
                    p1hp = (ScreenControl.leitchHP);
                    p1Atk = (ScreenControl.leitchAtk);
                    p1Def = (ScreenControl.leitchDef);
                    p1Spd = (ScreenControl.leitchSpd);
                    p1Yellow.Text = "Documentary";
                    p1Blue.Text = "Essay Question";
                    p1Red.Text = "Historic War";
                    p1Green.Text = "Multiple Choice Question";
                    //p1Sprite.Image = /*add leitch's image name here*/;
                    break;
                case "Cutch":
                    p1hp = (ScreenControl.cutchHP);
                    p1Atk = (ScreenControl.cutchAtk);
                    p1Def = (ScreenControl.cutchDef);
                    p1Spd = (ScreenControl.cutchSpd);
                    p1Yellow.Text = "DODGEBALL";
                    p1Blue.Text = "Dunk ON";
                    p1Red.Text = "Push Ups";
                    p1Green.Text = "Health Class";
                    //p1Sprite.Image = /*add cutch's image name here*/;
                    break;
                case "Ort":
                    p1hp = (ScreenControl.ortHP);
                    p1Atk = (ScreenControl.ortAtk);
                    p1Def = (ScreenControl.ortDef);
                    p1Spd = (ScreenControl.ortSpd);
                    p1Yellow.Text = "Clairinet Squeak";
                    p1Blue.Text = "Full Band Fortissimo";
                    p1Red.Text = "Melodious Passage";
                    p1Green.Text = "Tuning";
                    //p1Sprite.Image = /*add ortelli's image name here*/;
                    break;
                case "Steel":
                    p1hp = (ScreenControl.steelHP);
                    p1Atk = (ScreenControl.steelAtk);
                    p1Def = (ScreenControl.steelDef);
                    p1Spd = (ScreenControl.steelSpd);
                    p1Yellow.Text = "=";
                    p1Blue.Text = "Pink Paper";
                    p1Red.Text = "Quadratic Attack";
                    p1Green.Text = "Textbook Barricade";
                    //p1Sprite.Image = /*add steel's image name here*/;
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
                    p2Yellow.Text = "Critera Chart";
                    p2Blue.Text = "Dissection";
                    p2Red.Text = "Mad Experiment";
                    p2Green.Text = "Talk about Family";
                    p2Sprite.Image = SuperCrashTchrs.Properties.Resources.Bond_R;
                    break;
                case "Brad":
                    p2hp = (ScreenControl.bradHP);
                    p2Atk = (ScreenControl.bradAtk);
                    p2Def = (ScreenControl.bradDef);
                    p2Spd = (ScreenControl.bradSpd);
                    p2Yellow.Text = "Attack Bot";
                    p2Blue.Text = "Complain About Apple";
                    p2Red.Text = "Defender Bot";
                    p2Green.Text = "Video Friday";
                    p2Sprite.Image = SuperCrashTchrs.Properties.Resources.Bradshaw_R;
                    break;
                case "Leitch":
                    p2hp = (ScreenControl.leitchHP);
                    p2Atk = (ScreenControl.leitchAtk);
                    p2Def = (ScreenControl.leitchDef);
                    p2Spd = (ScreenControl.leitchSpd);
                    p2Yellow.Text = "Documentary";
                    p2Blue.Text = "Essay Question";
                    p2Red.Text = "Historic War";
                    p2Green.Text = "Multiple Choice Question";
                    //p2Sprite.Image = /*add leitch's image name here*/;
                    break;
                case "Cutch":
                    p2hp = (ScreenControl.cutchHP);
                    p2Atk = (ScreenControl.cutchAtk);
                    p2Def = (ScreenControl.cutchDef);
                    p2Spd = (ScreenControl.cutchSpd);
                    p2Yellow.Text = "DODGEBALL";
                    p2Blue.Text = "Dunk ON";
                    p2Red.Text = "Push Ups";
                    p2Green.Text = "Health Class";
                    //p2Sprite.Image = /*add cutch's image name here*/;
                    break;
                case "Ort":
                    p2hp = (ScreenControl.ortHP);
                    p2Atk = (ScreenControl.ortAtk);
                    p2Def = (ScreenControl.ortDef);
                    p2Spd = (ScreenControl.ortSpd);
                    p2Yellow.Text = "Clairinet Squeak";
                    p2Blue.Text = "Full Band Fortissimo";
                    p2Red.Text = "Melodious Passage";
                    p2Green.Text = "Tuning";
                    //p2Sprite.Image = /*add ortelli's image name here*/;
                    break;
                case "Steel":
                    p2hp = (ScreenControl.steelHP);
                    p2Atk = (ScreenControl.steelAtk);
                    p2Def = (ScreenControl.steelDef);
                    p2Spd = (ScreenControl.steelSpd);
                    p2Yellow.Text = "=";
                    p2Blue.Text = "Pink Paper";
                    p2Red.Text = "Quadratic Attack";
                    p2Green.Text = "Textbook Barricade";
                    //p2Sprite.Image = /*add steel's image name here*/;
                    break;
                default:
                    break;
            }
            #endregion
        }
        
        public static Random randNum = new Random();

        #region Character Moves
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
        
        public void AttackBot()//DONE
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
                damage = (((42 * playerAtk * 30 / opponentDef) / 50) + 2)
                    * randNum.Next(1, 101) / 100;
                opponentHP -= damage;
                if (p1character == "Brad")
                {
                    for (int i = p2hp; i > opponentHP; i--) 
                    {
                        p2HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                    }                        
                }
                else if (p2character == "Brad")
                {
                    for (int i = p1hp; i > opponentHP; i--)
                    {
                        p1HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                    }
                }
                if (opponentHP <= 0)
                {
                    battleStatusOutput.Text = "The opponent fainted!";
                    Thread.Sleep(sleepTime);

                    ScreenControl.changeScreen(this, "MultiEndScreen");
                }

                opponentAtk -= 25;
                battleStatusOutput.Text = "The opponents Attack was lowered!";
                Thread.Sleep(sleepTime);
                if (opponentAtk <= 0)
                {
                    opponentAtk = 1;
                    battleStatusOutput.Text = "The opponents Attack can't go any lower!";
                    Thread.Sleep(sleepTime);
                }
            }
            else
            {
                battleStatusOutput.Text = "But the opponent avoided the attack!";
                Thread.Sleep(sleepTime);
            }

            if (p1character == "Brad")
            {
                p2hp = opponentHP;
                p2Atk = opponentAtk;
            }
            else if (p2character == "Brad")
            {
                p1hp = opponentHP;
                p1Atk = opponentAtk;
            }
        }

        public void ClarinetSqueak()//kinda DONE
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

        public void ComplainAbout()//DONE
        {
            int playerAtk = 1;
            int opponentDef = 1;
            int opponentHP = 0;            
            int damage = 0;
            if (p1character == "Brad")
            {
                playerAtk = p1Atk;
                opponentDef = p2Def;
                opponentHP = p2hp;                
            }
            else if (p2character == "Brad")
            {
                playerAtk = p2Atk;
                opponentDef = p1Def;
                opponentHP = p1hp; 
            }
            battleStatusOutput.Text = "Bradshaw used Complain About Apple!";
            Thread.Sleep(sleepTime);

            if (randNum.Next(1, 101) <= 90)
            {
                damage = (((42 * playerAtk * 75 / opponentDef) / 50) + 2)
                    * randNum.Next(1, 101) / 100;
                opponentHP -= damage;
                if (p1character == "Brad")
                {
                    for (int i = p2hp; i > opponentHP; i--)
                    {
                        p2HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                    }
                }
                else if (p2character == "Brad")
                {
                    for (int i = p1hp; i > opponentHP; i--)
                    {
                        p1HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                    }
                }
                if (opponentHP <= 0)
                {
                    battleStatusOutput.Text = "The opponent fainted!";
                    Thread.Sleep(sleepTime);

                    ScreenControl.changeScreen(this, "MultiEndScreen");
                }
            }
            else
            {
                battleStatusOutput.Text = "But the opponent avoided the attack!";
                Thread.Sleep(sleepTime);
            }

            if (p1character == "Brad")
            {
                p2hp = opponentHP;                
            }
            else if (p2character == "Brad")
            {
                p1hp = opponentHP;                
            }
        }

        public void CriteriaChart()//DONE
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

        public void DefenderBot()//kinda done
        {
            int playerDef = 0;
            if (p1character == "Brad")
            {
                playerDef = p1Def;
            }
            else if (p2character == "Brad")
            {
                playerDef = p2Def;
            }
            battleStatusOutput.Text = "Bradshaw used Defender Bot!";
            Thread.Sleep(sleepTime);
            playerDef -= 25;
            battleStatusOutput.Text = "Bradshaws Defence was raised!";
            Thread.Sleep(sleepTime);

            if (playerDef <= 0)
            {
                playerDef = 1;
                battleStatusOutput.Text = "Bradshaws Defence can't go any higher!";
                Thread.Sleep(sleepTime);
            }

            if (p1character == "Brad")
            {
                p1Def = playerDef;
            }
            else if (p2character == "Brad")
            {
                p2Def = playerDef;
            }
        }

        public void Dissection()//DONE
        {
            int playerAtk = 1;
            int opponentDef = 1;
            int opponentHP = 0;
            int damage = 0;
            if (p1character == "Bond")
            {
                playerAtk = p1Atk;
                opponentDef = p2Def;
                opponentHP = p2hp;
            }
            else if (p2character == "Bond")
            {
                playerAtk = p2Atk;
                opponentDef = p1Def;
                opponentHP = p1hp;
            }
            battleStatusOutput.Text = "Bond used Discetion!";
            Thread.Sleep(sleepTime);

            if (randNum.Next(1, 101) <= 95)
            {
                damage = (((42 * playerAtk * 30 / opponentDef) / 50) + 2)
                    * randNum.Next(1, 101) / 100;
                opponentHP -= damage;
                if (p1character == "Bond")
                {
                    for (int i = p2hp; i > opponentHP; i--)
                    {
                        p2HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                    }
                }
                else if (p2character == "Bond")
                {
                    for (int i = p1hp; i > opponentHP; i--)
                    {
                        p1HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                    }
                }
                if (opponentHP <= 0)
                {
                    battleStatusOutput.Text = "The opponent fainted!";
                    Thread.Sleep(sleepTime);

                    ScreenControl.changeScreen(this, "MultiEndScreen");
                }
                opponentDef -= 25;
                battleStatusOutput.Text = "The opponents Defence was lowered!";
                Thread.Sleep(sleepTime);
                if (opponentDef <= 0)
                {
                    opponentDef = 1;
                    battleStatusOutput.Text = "The opponents Defence can't go any lower!";
                    Thread.Sleep(sleepTime);
                }
            }
            else
            {
                battleStatusOutput.Text = "But the opponent avoided the attack!";
                Thread.Sleep(sleepTime);
            }

            if (p1character == "Bond")
            {
                p2hp = opponentHP;
                p2Def = opponentDef;
            }
            else if (p2character == "Bond")
            {
                p1hp = opponentHP;
                p1Def = opponentDef;
            }
        }

        public void Documentary()//not done
        {
            /*
            //check if leitch is asleep
            if (leitchSleep != 0)
            {
                //if asleep pass the turn
                leitchSleep--;
                battleStatusOutput.Text = "Leitch is fast asleep...";
                Thread.Sleep(sleepTime);
            }
            else
            {
                int playerHP = 0;
                if (p1character == "Leitch")
                {
                    playerHP = p1hp; 
                } 
                else if (p2character == "Leitch")
                {
                    playerHP = p2hp;
                }
                playerHP = 200;
                
            }*/
        }

        public void Dodgeball()//not done
        {   
            /*
            int accuracyHit = randNum.Next(1,101);
            double damage;
            //check accuracy
            if (accuracyHit <= 90)
            {
                //show animation
                
                damage = (((42 * playerAtk * 100 / opponentDef) / 50) + 2) 
                    * randNum.Next(1,101) / 100;
                opponentHP -= damage;
                //for (int i = 100oponents HPbar length; i == opponentHP; i--)
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
            }*/
        }

        public void DunkOn()//not done
        {
            /*
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
            }*/
        }

        public void EqualSign()//not done
        {
            if (p1character == "Steel")
            {

            }

        }

        public void EssayQuestion()//DONE
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

        public void FullBandFF()//not done
        {
            /*
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
            }*/
        }

        public void HealthClass()//not done
        {

        }

        public void MadExperiment()//DONE
        {
            int playerAtk = 1;
            int opponentDef = 1;
            int opponentHP = 0;
            int damage = 0;
            if (p1character == "Bond")
            {
                playerAtk = p1Atk;
                opponentDef = p2Def;
                opponentHP = p2hp;
            }
            else if (p2character == "Bond")
            {
                playerAtk = p2Atk;
                opponentDef = p1Def;
                opponentHP = p1hp;
            }
            battleStatusOutput.Text = "Bond used Mad Experiment!";
            Thread.Sleep(sleepTime);

            if (randNum.Next(1, 101) <= 70)
            {
                damage = (((42 * playerAtk * 100 / opponentDef) / 50) + 2)
                    * randNum.Next(1, 101) / 100;
                opponentHP -= damage;
                if (p1character == "Brad")
                {
                    for (int i = p2hp; i > opponentHP && i > 0; i--)
                    {
                        p2HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                    }
                }
                else if (p2character == "Brad")
                {
                    for (int i = p1hp; i > opponentHP && i > 0; i--)
                    {
                        p1HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                    }
                }
                if (opponentHP <= 0)
                {
                    battleStatusOutput.Text = "The opponent fainted!";
                    Thread.Sleep(sleepTime);

                    ScreenControl.changeScreen(this, "MultiEndScreen");
                }
            }
            else
            {
                battleStatusOutput.Text = "But the opponent avoided the attack!";
                Thread.Sleep(sleepTime);
            }

            if (p1character == "Brad")
            {
                p2hp = opponentHP;
            }
            else if (p2character == "Brad")
            {
                p1hp = opponentHP;
            }
        }

        public void MelodiousPassage()//not done
        {

        }

        public void MultiQuestion()//not done
        {            
            
        }

        public void PinkPaper()//not done
        {
            /*
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
            }*/
        }

        public void PushUps()//not done
        {
            
        }

        public void QuadraticAttack()//not done
        {

        }

        public void TalkAboutFamily()//DONE
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
                playerDef = 250;
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

        public void TextbookBarricade()//DONE
        {
            int playerDef = 0;
            if (p1character == "Steel")
            {
                playerDef = p1Def;
            }
            else if (p2character == "Steel")
            {
                playerDef = p2Def;
            }
            battleStatusOutput.Text = "Steel used Textbook Barricade!";
            Thread.Sleep(sleepTime);
            playerDef -= 25;
            battleStatusOutput.Text = "Steels Defence was raised!";
            Thread.Sleep(sleepTime);

            if (playerDef <= 0)
            {
                playerDef = 1;
                battleStatusOutput.Text = "Steels Defence can't go any higher!";
                Thread.Sleep(sleepTime);
            }

            if (p1character == "Steel")
            {
                p1Def = playerDef;
            }
            else if (p2character == "Steel")
            {
                p2Def = playerDef;
            }
        }

        public void Tuning()//DONE
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

        public void VideoFriday()//DONE
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
        #endregion

        private void moveSelectTimer_Tick(object sender, EventArgs e)
        {
            if (p1moveSelect == true && p2moveSelect == true)
            {
                moveSelectTimer.Enabled = false;
                p1moveSelect = false;
                p2moveSelect = false;
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
                                Dodgeball();
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
                                Dissection();
                                break;
                            case "Brad":
                                ComplainAbout();
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
                                MadExperiment();
                                break;
                            case "Brad":
                                DefenderBot();
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
                    #region move 1
                    if (p2move1 == true)
                    {
                        switch (p2character)
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
                    #endregion

                    #region move 2
                    if (p2move2 == true)
                    {
                        switch (p2character)
                        {
                            case "Bond":
                                Dissection();
                                break;
                            case "Brad":
                                ComplainAbout();
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
                    #endregion

                    #region move 3
                    if (p2move3 == true)
                    {
                        switch (p2character)
                        {
                            case "Bond":
                                MadExperiment();
                                break;
                            case "Brad":
                                DefenderBot();
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
                    if (p2move4 == true)
                    {
                        switch (p2character)
                        {
                            case "Bond":
                                TalkAboutFamily();
                                break;
                            case "Brad":
                                VideoFriday();
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
                    #endregion
                }
                else if (p1Spd < p2Spd)
                {
                    #region p2 Goes First
                    #region move 1
                    if (p2move1 == true)
                    {
                        switch (p2character)
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
                    #endregion

                    #region move 2
                    if (p2move2 == true)
                    {
                        switch (p2character)
                        {
                            case "Bond":
                                Dissection();
                                break;
                            case "Brad":
                                ComplainAbout();
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
                    #endregion

                    #region move 3
                    if (p2move3 == true)
                    {
                        switch (p2character)
                        {
                            case "Bond":
                                MadExperiment();
                                break;
                            case "Brad":
                                DefenderBot();
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
                    if (p2move4 == true)
                    {
                        switch (p2character)
                        {
                            case "Bond":
                                TalkAboutFamily();
                                break;
                            case "Brad":
                                VideoFriday();
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
                    #endregion

                    #region p1 Goes Second
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
                                Dodgeball();
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
                                Dissection();
                                break;
                            case "Brad":
                                ComplainAbout();
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
                                MadExperiment();
                                break;
                            case "Brad":
                                DefenderBot();
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
                }
                else if (p1Spd == p2Spd)
                {
                    if (randNum.Next(1, 3) == 1)
                    {
                        #region p1 First Speed Tie
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
                                    Dodgeball();
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
                                    Dissection();
                                    break;
                                case "Brad":
                                    ComplainAbout();
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
                                    MadExperiment();
                                    break;
                                case "Brad":
                                    DefenderBot();
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

                        #region p2 Second Speed tie
                        #region move 1
                        if (p2move1 == true)
                        {
                            switch (p2character)
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
                        #endregion

                        #region move 2
                        if (p2move2 == true)
                        {
                            switch (p2character)
                            {
                                case "Bond":
                                    Dissection();
                                    break;
                                case "Brad":
                                    ComplainAbout();
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
                        #endregion

                        #region move 3
                        if (p2move3 == true)
                        {
                            switch (p2character)
                            {
                                case "Bond":
                                    MadExperiment();
                                    break;
                                case "Brad":
                                    DefenderBot();
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
                        if (p2move4 == true)
                        {
                            switch (p2character)
                            {
                                case "Bond":
                                    TalkAboutFamily();
                                    break;
                                case "Brad":
                                    VideoFriday();
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
                        #endregion
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
