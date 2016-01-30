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
using System.Media;

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

        //attack and damage sound players
        SoundPlayer attackPlayer = new SoundPlayer(Properties.Resources.Attack_Sound);
        SoundPlayer damagePlayer = new SoundPlayer(Properties.Resources.Pain_Sound);

        int leitchSleep = 0;
        bool ortSleep = false;

        #endregion

        public BattleArena()
        {
            InitializeComponent();
            moveSelectTimer.Enabled = true;
            p1character = "Brad";
            p2character = "Bond";

            #region Stat Switchs
            switch (p1character)
            {
                case "Bond":
                    p1hp = (ScreenControl.bondHP);
                    p1Atk = (ScreenControl.bondAtk);
                    p1Def = (ScreenControl.bondDef);
                    p1Spd = (ScreenControl.bondSpd);
                    p1HPBar.Size = new Size(ScreenControl.bondHP, 10);
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
                    p1HPBar.Size = new Size(ScreenControl.bradHP, 10);
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
                    p1HPBar.Size = new Size(ScreenControl.leitchHP, 10);
                    p1Yellow.Text = "Documentary";
                    p1Blue.Text = "Essay Question";
                    p1Red.Text = "Historic War";
                    p1Green.Text = "Multiple Choice Question";
                    // p1Sprite.Image = SuperCrashTchrs.Properties.Resources.Leitch_L;
                    break;
                case "Cutch":
                    p1hp = (ScreenControl.cutchHP);
                    p1Atk = (ScreenControl.cutchAtk);
                    p1Def = (ScreenControl.cutchDef);
                    p1Spd = (ScreenControl.cutchSpd);
                    p1HPBar.Size = new Size(ScreenControl.cutchHP, 10);
                    p1Yellow.Text = "DODGEBALL";
                    p1Blue.Text = "Dunk ON";
                    p1Red.Text = "Push Ups";
                    p1Green.Text = "Health Class";
                    p1Sprite.Image = SuperCrashTchrs.Properties.Resources.Cutch_L;
                    break;
                case "Ort":
                    p1hp = (ScreenControl.ortHP);
                    p1Atk = (ScreenControl.ortAtk);
                    p1Def = (ScreenControl.ortDef);
                    p1Spd = (ScreenControl.ortSpd);
                    p1HPBar.Size = new Size(ScreenControl.ortHP, 10);
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
                    p1HPBar.Size = new Size(ScreenControl.steelHP, 10);
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
                    p2HPBar.Size = new Size(ScreenControl.bondHP, 10);
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
                    p2HPBar.Size = new Size(ScreenControl.bradHP, 10);
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
                    p2HPBar.Size = new Size(ScreenControl.leitchHP, 10);
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
                    p2HPBar.Size = new Size(ScreenControl.cutchHP, 10);
                    p2Yellow.Text = "DODGEBALL";
                    p2Blue.Text = "Dunk ON";
                    p2Red.Text = "Push Ups";
                    p2Green.Text = "Health Class";
                    p2Sprite.Image = SuperCrashTchrs.Properties.Resources.Cutch_R;
                    break;
                case "Ort":
                    p2hp = (ScreenControl.ortHP);
                    p2Atk = (ScreenControl.ortAtk);
                    p2Def = (ScreenControl.ortDef);
                    p2Spd = (ScreenControl.ortSpd);
                    p2HPBar.Size = new Size(ScreenControl.ortHP, 10);
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
                    p2HPBar.Size = new Size(ScreenControl.steelHP, 10);
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

        //Button Presses
        private void BattleArena_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
                    battleStatusOutput.Text = "Player 1 has decided";
                    break;
                case Keys.B:
                    p1moveSelect = true;
                    p1move1 = false;
                    p1move2 = true;
                    p1move3 = false;
                    p1move4 = false;
                    battleStatusOutput.Text = "Player 1 has decided";
                    break;
                case Keys.M:
                    p1moveSelect = true;
                    p1move1 = false;
                    p1move2 = false;
                    p1move3 = true;
                    p1move4 = false;
                    battleStatusOutput.Text = "Player 1 has decided";
                    break;
                case Keys.Space:
                    p1moveSelect = true;
                    p1move1 = false;
                    p1move2 = false;
                    p1move3 = false;
                    p1move4 = true;
                    battleStatusOutput.Text = "Player 1 has decided";
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
                    battleStatusOutput.Text = "Player 2 has decided";
                    break;
                case Keys.C:
                    p2moveSelect = true;
                    p2move1 = false;
                    p2move2 = true;
                    p2move3 = false;
                    p2move4 = false;
                    battleStatusOutput.Text = "Player 2 has decided";
                    break;
                case Keys.X:
                    p2moveSelect = true;
                    p2move1 = false;
                    p2move2 = false;
                    p2move3 = true;
                    p2move4 = false;
                    battleStatusOutput.Text = "Player 2 has decided";
                    break;
                case Keys.Z:
                    p2moveSelect = true;
                    p2move1 = false;
                    p2move2 = false;
                    p2move3 = false;
                    p2move4 = true;
                    battleStatusOutput.Text = "Player 2 has decided";
                    break;
                default:
                    break;
            }
        }

        #region Character Moves
        public void AttackBot()//Brad DONE; sound in; no bugs
        {
            //intergers
            int playerAtk = 1;
            int opponentDef = 1;
            int opponentHP = 0;
            int opponentAtk = 0;
            int damage = 0;
            //assign values
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

            //display text
            battleStatusOutput.Text = "Bradshaw used Attack Bot!";
            Thread.Sleep(sleepTime);
            Refresh();

            //check if move hits
            if (randNum.Next(1, 101) <= 95)
            {
                //attack sound
                attackPlayer.Play();
                //damage calculation
                damage = (((42 * playerAtk * 30 / opponentDef) / 50) + 2)
                    * randNum.Next(1, 101) / 100;
                opponentHP -= damage;
                //play damage sound before changing hp
                damagePlayer.Play();

                //Change HPbar length
                if (p1character == "Brad")
                {
                    for (int i = p2hp; i > opponentHP && i > 0; i--)
                    {
                        p2HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                        Refresh();
                    }
                }
                else if (p2character == "Brad")
                {
                    for (int i = p1hp; i > opponentHP && i > 0; i--)
                    {
                        p1HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                        Refresh();
                    }
                }
                //check if opponent is KO
                if (opponentHP <= 0)
                {
                    battleStatusOutput.Text = "The opponent fainted!";
                    Thread.Sleep(sleepTime);
                    Refresh();
                    ScreenControl.changeScreen(this, "MultiEndScreen");
                }

                //lower attack stat
                opponentAtk -= 25;
                //display message
                battleStatusOutput.Text = "The opponents Attack was lowered!";
                Thread.Sleep(sleepTime);
                Refresh();
                if (opponentAtk <= 0)
                {
                    opponentAtk = 1;
                    //display message
                    battleStatusOutput.Text = "The opponents Attack can't go any lower!";
                    Thread.Sleep(sleepTime);
                    Refresh();
                }
            }
            //if attack misses    
            else
            {
                battleStatusOutput.Text = "But the robot malfunctioned!";
                Thread.Sleep(sleepTime);
                Refresh();
            }
            //reassign stats to players
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

        public void ClarinetSqueak()//Ort; needs sound DONE
        {
            melodiousSleep = false;
            int opponentDef = 0;
            if (p1character == "Ort")
            {
                opponentDef = p2Def;
            }
            else if (p2character == "Ort")
            {
                opponentDef = p1Def;
            }
            if (ortSleep == false)
            {
                battleStatusOutput.Text = "A Clairinet in the Band (Ben F.) created an obnoxious squeak!";
            Thread.Sleep(sleepTime);
            Refresh();

            opponentDef -= 25;
            battleStatusOutput.Text = "The opponents defence was lowered!";
            Thread.Sleep(sleepTime);
            Refresh();

            if (opponentDef <= 0)
            {
                opponentDef = 1;
                battleStatusOutput.Text = "The opponents defence cannot go any lower!";
                Thread.Sleep(sleepTime);
                Refresh();
            }
            }

            else if (ortSleep == true)
            {
                ortSleep = false;
                battleStatusOutput.Text = "Ortelli needs to recover!";
                Thread.Sleep(sleepTime);
                Refresh();
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

        public void ComplainAbout()//Brad; with sound; DONE
        {
            //variables
            int playerAtk = 1;
            int opponentDef = 1;
            int opponentHP = 0;
            int damage = 0;

            //assign to current player
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

            //display text
            battleStatusOutput.Text = "Bradshaw used Complain About Apple!";
            Thread.Sleep(sleepTime);
            Refresh();

            //check if attack hits
            if (randNum.Next(1, 101) <= 90)
            {
                //attack sound
                attackPlayer.Play();
                //damage calc
                damage = (((42 * playerAtk * 75 / opponentDef) / 50) + 2)
                    * randNum.Next(1, 101) / 100;
                opponentHP -= damage;
                //play damage sound
                damagePlayer.Play();

                //change HP bar
                if (p1character == "Brad")
                {
                    for (int i = p2hp; i > opponentHP && i > 0; i--)
                    {
                        p2HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                        Refresh();
                    }
                }
                else if (p2character == "Brad")
                {
                    for (int i = p1hp; i > opponentHP && i > 0; i--)
                    {
                        p1HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                        Refresh();
                    }
                }
                //check if fainted
                if (opponentHP <= 0)
                {
                    battleStatusOutput.Text = "The opponent fainted!";
                    Thread.Sleep(sleepTime);
                    Refresh();

                    ScreenControl.changeScreen(this, "MultiEndScreen");
                }
            }
            //check if dead
            else
            {
                battleStatusOutput.Text = "But the opponent never liked apple in the first place!";
                Thread.Sleep(sleepTime);
                Refresh();
            }
            //return stat changes
            if (p1character == "Brad")
            {
                p2hp = opponentHP;
            }
            else if (p2character == "Brad")
            {
                p1hp = opponentHP;
            }
        }

        public void CriteriaChart()//Bond; needs sound DONE
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
            Refresh();

            userAtk += 25;
            battleStatusOutput.Text = "Bonds Attack rose!";
            Thread.Sleep(sleepTime);
            Refresh();

            if (userAtk > 250)
            {
                userAtk = 250;
                battleStatusOutput.Text = "Bonds Attack can't go any higher!";
                Thread.Sleep(sleepTime);
                Refresh();
            }

            userSpd += 25;
            battleStatusOutput.Text = "Bonds Speed rose!";
            Thread.Sleep(sleepTime);
            Refresh();
            if (userSpd > 250)
            {
                userSpd = 250;
                battleStatusOutput.Text = "Bonds Speed can't go any higher!";
                Thread.Sleep(sleepTime);
                Refresh();
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

        public void DefenderBot()//Brad; needs sound kinda done
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
            battleStatusOutput.Text = "Bradshaw created a robot to defend himself!";
            Thread.Sleep(sleepTime);
            Refresh();
            playerDef -= 25;
            battleStatusOutput.Text = "Bradshaws Defence was raised!";
            Thread.Sleep(sleepTime);
            Refresh();

            if (playerDef <= 0)
            {
                playerDef = 1;
                battleStatusOutput.Text = "Bradshaws Defence can't go any higher!";
                Thread.Sleep(sleepTime);
                Refresh();
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

        public void Dissection()//Bond; sound done DONE
        {
            //variables
            int playerAtk = 1;
            int opponentDef = 1;
            int opponentHP = 0;
            int damage = 0;

            //assign values
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

            //display text
            battleStatusOutput.Text = "Bond used Discetion!";
            Thread.Sleep(sleepTime);
            Refresh();

            //check if hits
            if (randNum.Next(1, 101) <= 95)
            {
                //attack sound
                attackPlayer.Play();
                //damage calc
                damage = (((42 * playerAtk * 30 / opponentDef) / 50) + 2)
                    * randNum.Next(1, 101) / 100;
                opponentHP -= damage;
                //play damage sound
                damagePlayer.Play();

                //HPbar changes
                if (p1character == "Bond")
                {
                    for (int i = p2hp; i > opponentHP && i > 0; i--)
                    {
                        p2HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                        Refresh();
                    }
                }
                else if (p2character == "Bond")
                {
                    for (int i = p1hp; i > opponentHP && i > 0; i--)
                    {
                        p1HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                        Refresh();
                    }
                }
                //check if dead
                if (opponentHP <= 0)
                {
                    battleStatusOutput.Text = "The opponent fainted!";
                    Thread.Sleep(sleepTime);
                    Refresh();

                    ScreenControl.changeScreen(this, "MultiEndScreen");
                }

                //lower opponent defence
                opponentDef -= 25;
                battleStatusOutput.Text = "The opponents Defence was lowered!";
                Thread.Sleep(sleepTime);
                Refresh();

                if (opponentDef <= 0)
                {
                    opponentDef = 1;
                    battleStatusOutput.Text = "The opponents Defence can't go any lower!";
                    Thread.Sleep(sleepTime);
                    Refresh();
                }
            }
            //If misses
            else
            {
                battleStatusOutput.Text = "But the opponent wasn't grossed out!";
                Thread.Sleep(sleepTime);
                Refresh();
            }
            //return changes
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

        public void Documentary()//Leitch; needs sound done
        {
            int playerHP = 1;
            if (leitchSleep == 0)
            {
                if (p1character == "Leitch")
                {
                    playerHP = p1hp; 
                } 
                else if (p2character == "Leitch")
                {
                    playerHP = p2hp;
                }
                battleStatusOutput.Text = "Leitch put on a Documentary!";
                Thread.Sleep(sleepTime);
                Refresh();
                playerHP = ScreenControl.leitchHP;
                leitchSleep = 2;
                battleStatusOutput.Text = "Leitch Restored his Health!";
                Thread.Sleep(sleepTime);
                Refresh();
                battleStatusOutput.Text = "Leitch put the class to Sleep and needs to wait 2 turns!";
                Thread.Sleep(sleepTime);
                Refresh();
                if (p1character == "Leitch")
                {
                    p1HPBar.Size = new Size(playerHP, 10);
        }
                else if (p2character == "Leitch")
                {
                    p2HPBar.Size = new Size(playerHP, 10);
                }
            }
            else
            {
                battleStatusOutput.Text = "The class is still asleep!";
                Thread.Sleep(sleepTime);
                Refresh();
                leitchSleep--;
            }
        }

        public void Dodgeball()//Cutch; sound done; done
        {
            int playerAtk = 0;
            int playerDef = 0;
            int opponentHP = 1;
            int opponentDef = 0;
            int damage = 0;

            int accuracyHit = randNum.Next(1,101);
            if (p1character == "Cutch")
            {
                playerAtk = p1Atk;
                playerDef = p1Def;
                opponentDef = p2Def;
                opponentHP = p2Def;
            }
            if (p2character == "Cutch")
            {
                playerAtk = p2Atk;
                playerDef = p2Def;
                opponentDef = p1Def;
                opponentHP = p1Def;
            }

            //display text
            battleStatusOutput.Text = "McCutcheon started a game of DODGEBALL!";
            Thread.Sleep(sleepTime);
            Refresh();

            //check accuracy
            if (accuracyHit <= 90)
            {
                //attack sound
                attackPlayer.Play();
                //damage calculation
                damage = (((42 * playerAtk * 100 / opponentDef) / 50) + 2) 
                    * randNum.Next(1,101) / 100;
                opponentHP -= damage;
                //damage sound
                damagePlayer.Play();

                //HPbar change
                if (p1character == "Cutch")
                {
                    for (int i = p2hp; i > opponentHP && i > 0; i--)
                    {
                        p2HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                        Refresh();
                    }
                }
                else if (p2character == "Cutch")
                {
                    for (int i = p1hp; i > opponentHP && i > 0; i--)
                    {
                        p1HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                        Refresh();
                    }
                }
                //lower user atk
                battleStatusOutput.Text = "McCutcheons Attack fell!";
                Thread.Sleep(sleepTime);
                Refresh();                
                playerAtk -= 25;
                if (playerAtk <= 0)
                {
                    playerAtk = 1;

                    battleStatusOutput.Text = "McCutcheons Attack can't go any lower!";
                    Thread.Sleep(sleepTime);
                    Refresh();
                }

                //lower user def
                battleStatusOutput.Text = "McCutcheons Defence fell!";
                Thread.Sleep(sleepTime);
                Refresh();
                playerDef -= 25;
                if (playerDef <= 0)
                {
                    battleStatusOutput.Text = "McCutcheons Attack can't go any lower!";
                    Thread.Sleep(sleepTime);
                    Refresh();
                    playerDef = 1;
                }
                //check if dead
                if (opponentHP <= 0)
                {
                    battleStatusOutput.Text = "The opponent fainted!";
                    Thread.Sleep(sleepTime);
                    Refresh();
                    //go to game over screen
                    ScreenControl.changeScreen(this, "MultiEndScreen");
                }
            }
                else
                {
                battleStatusOutput.Text = "The opponent avoided the attack!";
                Thread.Sleep(sleepTime);
                Refresh();
                }
            if (p1character == "Cutch")
            {
                p1Atk = playerAtk;
                p1Def = playerDef;
                p2hp = opponentHP;
            }
            if (p2character == "Cutch")
            {
                p2Atk = playerAtk;
                p2Def = playerDef;
                p1hp = opponentHP;
            }
        }

        public void DunkOn()//Cutch done
        {
            //variables
            int playerAtk = 1;
            int opponentDef = 1;
            int opponentHP = 0;
            int damage = 0;

            //assign to current player
            if (p1character == "Cutch")
            {
                playerAtk = p1Atk;
                opponentDef = p2Def;
                opponentHP = p2hp;
            }
            else if (p2character == "Cutch")
        {
                playerAtk = p2Atk;
                opponentDef = p1Def;
                opponentHP = p1hp;
            }

            battleStatusOutput.Text = "McCutcheon Slam Dunked on the opponent!";
            Thread.Sleep(sleepTime);
            Refresh();

            //check if attack hits
            if (randNum.Next(1, 101) <= 70)
            {
                //damage calc
                damage = (((42 * playerAtk * 90 / opponentDef) / 50) + 2)
                 * randNum.Next(1, 101) / 100;
                opponentHP -= damage;

                //change HP bar
                if (p1character == "Cutch")
                {
                    for (int i = p2hp; i > opponentHP && i > 0; i--)
                    {
                        p2HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                        Refresh();
                    }
                }
                else if (p2character == "Cutch")
                {
                    for (int i = p1hp; i > opponentHP && i > 0; i--)
                {
                        p1HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                        Refresh();
                    }
                }
                //check if fainted
                if (opponentHP <= 0)
                {
                    battleStatusOutput.Text = "The opponent fainted!";
                    Thread.Sleep(sleepTime);
                    Refresh();

                    ScreenControl.changeScreen(this, "MultiEndScreen");
                }
            }
            //if misses
            else
            {
                battleStatusOutput.Text = "But the opponent blocked the shot!";
                Thread.Sleep(sleepTime);
                Refresh();
            }
            //return stat changes
            if (p1character == "Cutch")
            {
                p2hp = opponentHP;
            }
            else if (p2character == "Cutch")
            {
                p1hp = opponentHP;
            }
        }

        public void EqualSign()//Steel done
        {
            int playerHP = 1;
            int opponentHP = 1;
            if (p1character == "Steel")
            {
                playerHP = p1hp;
                opponentHP = p2hp;
            }
            else if (p2character == "Steel")
            {
                playerHP = p2hp;
                opponentHP = p1hp;
            }
            battleStatusOutput.Text = "Steel added a '='!";
            Thread.Sleep(sleepTime);
            Refresh();
            battleStatusOutput.Text = "Steel Balanced his HP with the opponent!";
            Thread.Sleep(sleepTime);
            Refresh();
            playerHP = (playerHP + opponentHP) / 2;
            opponentHP = playerHP;

            if (p1character == "Steel")
            {
                p1HPBar.Size = new Size(playerHP, 10);
                p2HPBar.Size = new Size(opponentHP, 10);
                p1hp = playerHP;
                p2hp = opponentHP;
            }
            else if (p2character == "Steel")
            {
                p2HPBar.Size = new Size(playerHP, 10);
                p1HPBar.Size = new Size(opponentHP, 10);
                p2hp = playerHP;
                p1hp = opponentHP;
            }
        }

        public void EssayQuestion()//Leitch DONE
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

            if (leitchSleep == 0)
            {
                battleStatusOutput.Text = "Leitch made the opponent write an Essay question!";
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

        public void FullBandFF()//Ort done
        {
            melodiousSleep = false;

            int playerAtk = 0;
            int opponentDef = 0;
            int opponentHP = 1;
            if (ortSleep == false)
            {
                if (p1character == "Ort")
                {
                    playerAtk = p1Atk;
                    opponentDef = p2Def;
                    opponentHP = p2hp;
                }
                else if (p2character == "Ort")
                {
                    playerAtk = p2Atk;
                    opponentDef = p1Def;
                    opponentHP = p1hp;
                }

                battleStatusOutput.Text = "Ortelli allowed a Full Band Fortissimo!";
                Thread.Sleep(sleepTime);
                Refresh();
                ortSleep = true;
                //check if attack hits
                if (randNum.Next(1, 101) <= 90)
                {
                    //damage calc
                    opponentHP -= (((42 * playerAtk * 120 / opponentDef) / 50) + 2)
                    * randNum.Next(1, 101) / 100;
                    //change HP bar
                    if (p1character == "Ort")
                    {
                        for (int i = p2hp; i > opponentHP && i > 0; i--)
                        {
                            p2HPBar.Size = new Size(i, 10);
                            Thread.Sleep(50);
                            Refresh();
                        }
                    }
                    else if (p2character == "Ort")
                    {
                        for (int i = p1hp; i > opponentHP && i > 0; i--)
                        {
                            p1HPBar.Size = new Size(i, 10);
                            Thread.Sleep(50);
                            Refresh();
                        }
                    }
                    //check if fainted
                    if (opponentHP <= 0)
                    {
                        battleStatusOutput.Text = "The opponent fainted!";
                        Thread.Sleep(sleepTime);
                        Refresh();

                        ScreenControl.changeScreen(this, "MultiEndScreen");
                    }
                }
                //check if dead
                else
                {
                    battleStatusOutput.Text = "But the opponent wasn't listening!";
                    Thread.Sleep(sleepTime);
                    Refresh();
                }
                //return stat changes
                if (p1character == "Ort")
                {
                    p2hp = opponentHP;
                }
                else if (p2character == "Ort")
                    {
                    p1hp = opponentHP;
                }
                    }
                    else
                    {
                battleStatusOutput.Text = "The band needs to rest!";
                Thread.Sleep(sleepTime);
                Refresh();
                ortSleep = false;
            }
        }

        public void HealthClass()//Cutch done
        {
            //variables
            int playerAtk = 1;
            int playerHP = 1;
            int opponentDef = 1;
            int opponentHP = 0;
            int damage = 0;

            //assign to current player
            if (p1character == "Cutch")
            {
                playerAtk = p1Atk;
                playerHP = p1hp;
                opponentDef = p2Def;
                opponentHP = p2hp;
            }
            else if (p2character == "Cutch")
            {
                playerAtk = p2Atk;
                playerHP = p2hp;
                opponentDef = p1Def;
                opponentHP = p1hp;
            }

            battleStatusOutput.Text = "McCutcheon is teaching a Health Class!";
            Thread.Sleep(sleepTime);
            Refresh();

            //check if attack hits
            if (randNum.Next(1, 101) <= 90)
            {
                //damage calc
                damage = (((42 * playerAtk * 90 / opponentDef) / 50) + 2)
                    * randNum.Next(1, 101) / 100;
                opponentHP -= damage;
                playerHP -= damage / 4;

                //change HP bar
                if (p1character == "Cutch")
                {
                    for (int i = p2hp; i > opponentHP && i > 0; i--)
                    {
                        p2HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                        Refresh();
                    }
                }
                else if (p2character == "Cutch")
                {
                    for (int i = p1hp; i > opponentHP && i > 0; i--)
                    {
                        p1HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                        Refresh();
                    }
                }
                //check if fainted opponent fainted
                if (opponentHP <= 0)
                {
                    battleStatusOutput.Text = "The opponent fainted!";
                    Thread.Sleep(sleepTime);
                    Refresh();

                    ScreenControl.changeScreen(this, "MultiEndScreen");
                }                
                if (p1character == "Cutch")
                {
                    for (int i = p1hp; i > playerHP && i > 0; i--)
                    {
                        p1HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                        Refresh();
                    }
                }
                else if (p2character == "Cutch")
                {
                    for (int i = p2hp; i > playerHP && i > 0; i--)
                    {
                        p2HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                        Refresh();
                    }
                }
                battleStatusOutput.Text = "McCutcheon is hurt from recoil!";
                Thread.Sleep(sleepTime);
                Refresh();

                if (playerHP <=0)
                {
                    battleStatusOutput.Text = "McCutcheon fainted!";
                    Thread.Sleep(sleepTime);
                    Refresh();

                        ScreenControl.changeScreen(this, "MultiEndScreen");
                    }
                }
            //check if dead
                else
                {
                battleStatusOutput.Text = "But the opponent skipped this class!";
                Thread.Sleep(sleepTime);
                Refresh();
            }
            //return stat changes
            if (p1character == "Cutch")
            {
                p1hp = playerHP;
                p2hp = opponentHP;
            }
            else if (p2character == "Cutch")
            {
                p2hp = playerHP;
                p1hp = opponentHP;
            }
        }

        public void HistoricWar()//Leitch not done
        {

            //variables
            int playerAtk = 1;
            int playerHP = 1;
            int opponentDef = 1;
            int opponentHP = 0;
            int damage = 0;
            if (leitchSleep == 0)
            {
                //assign to current player
                if (p1character == "Leitch")
                {
                    playerAtk = p1Atk;
                    playerHP = p1hp;
                    opponentDef = p2Def;
                    opponentHP = p2hp;
                }
                else if (p2character == "Leitch")
                {
                    playerAtk = p2Atk;
                    playerHP = p2hp;
                    opponentDef = p1Def;
                    opponentHP = p1hp;
                }

                battleStatusOutput.Text = "Leitch is teaching about a Historic War!";
                Thread.Sleep(sleepTime);
                Refresh();

                //check if attack hits
                if (randNum.Next(1, 101) <= 90)
                {
                    //damage calc
                    damage = (((42 * playerAtk * 90 / opponentDef) / 50) + 2)
                        * randNum.Next(1, 101) / 100;
                    opponentHP -= damage;
                    playerHP -= damage / 4;

                    //change HP bar
                    if (p1character == "Leitch")
                    {
                        for (int i = p2hp; i > opponentHP && i > 0; i--)
                        {
                            p2HPBar.Size = new Size(i, 10);
                            Thread.Sleep(50);
                            Refresh();
                }
            }
                    else if (p2character == "Leitch")
            {
                        for (int i = p1hp; i > opponentHP && i > 0; i--)
                        {
                            p1HPBar.Size = new Size(i, 10);
                            Thread.Sleep(50);
                            Refresh();
        }
                    }
                    //check if fainted opponent fainted
                    if (opponentHP <= 0)
                    {
                        battleStatusOutput.Text = "The opponent fainted!";
                        Thread.Sleep(sleepTime);
                        Refresh();

                        ScreenControl.changeScreen(this, "MultiEndScreen");
                    }
                    if (p1character == "Leitch")
        {
                        for (int i = p1hp; i > playerHP && i > 0; i--)
                        {
                            p1HPBar.Size = new Size(i, 10);
                            Thread.Sleep(50);
                            Refresh();
                        }
                    }
                    else if (p2character == "Leitch")
                    {
                        for (int i = p2hp; i > playerHP && i > 0; i--)
                        {
                            p2HPBar.Size = new Size(i, 10);
                            Thread.Sleep(50);
                            Refresh();
                        }
                    }
                    battleStatusOutput.Text = "Leitch is hurt from recoil!";
                    Thread.Sleep(sleepTime);
                    Refresh();

                    if (playerHP <= 0)
                    {
                        battleStatusOutput.Text = "Leitch fainted!";
                        Thread.Sleep(sleepTime);
                        Refresh();

                        ScreenControl.changeScreen(this, "MultiEndScreen");
        }
                }
                //check if dead
                else
                {
                    battleStatusOutput.Text = "But the opponent skipped this class!";
                    Thread.Sleep(sleepTime);
                    Refresh();
                }
                //return stat changes
                if (p1character == "Leitch")
                {
                    p1hp = playerHP;
                    p2hp = opponentHP;
                }
                else if (p2character == "Leitch")
                {
                    p2hp = playerHP;
                    p1hp = opponentHP;
                }
            }
            else
            {
                battleStatusOutput.Text = "The class is still asleep!";
                Thread.Sleep(sleepTime);
                Refresh();
                leitchSleep--;
            }
        }

        public void MadExperiment()//Bond DONE
        {
            //variables
            int playerAtk = 1;
            int opponentDef = 1;
            int opponentHP = 0;
            int damage = 0;
            //Assigns variables to active player
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
            //text to screen
            battleStatusOutput.Text = "Bond did a super cool experiment!";
            Thread.Sleep(sleepTime);
            Refresh();
            //checks if misses
            if (randNum.Next(1, 101) <= 70)
            {
                //damage calc
                damage = (((42 * playerAtk * 100 / opponentDef) / 50) + 2)
                    * randNum.Next(1, 101) / 100;
                opponentHP -= damage;
                //slowly depletes HP bar
                if (p1character == "Bond")
                {
                    for (int i = p2hp; i > opponentHP && i > 0; i--)
                    {
                        p2HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                    }
                }
                else if (p2character == "Bond")
                {
                    for (int i = p1hp; i > opponentHP && i > 0; i--)
                    {
                        p1HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                    }
                }
                //checks if opponent dead
                if (opponentHP <= 0)
                {
                    battleStatusOutput.Text = "The opponent fainted!";
                    Thread.Sleep(sleepTime);
                    Refresh();

                    ScreenControl.changeScreen(this, "MultiEndScreen");
                }
            }
            else
            {
                //if attack misses
                battleStatusOutput.Text = "But it didnt work as planned!";
                Thread.Sleep(sleepTime);
                Refresh();
            }
            //returns changed stats to characters
            if (p1character == "Bond")
            {
                p2hp = opponentHP;
            }
            else if (p2character == "Bond")
            {
                p1hp = opponentHP;
            }
        }

        public void MelodiousPassage()//Ort done
        {
            int playerAtk = 0;
            int opponentDef = 0;
            int opponentHP = 1;
            if (ortSleep == false && melodiousSleep == false)
            {
                if (p1character == "Ort")
                {
                    playerAtk = p1Atk;
                    opponentDef = p2Def;
                    opponentHP = p2hp;
                }
                else if (p2character == "Ort")
                {
                    playerAtk = p2Atk;
                    opponentDef = p1Def;
                    opponentHP = p1hp;
                }

                battleStatusOutput.Text = "Ortelli conducted a Melodious Passage!";
                Thread.Sleep(sleepTime);
                Refresh();
                ortSleep = true;
                //check if attack hits
                if (randNum.Next(1, 101) <= 95)
                {
                    //damage calc
                    opponentHP -= (((42 * playerAtk * 75 / opponentDef) / 50) + 2)
                        * randNum.Next(1, 101) / 100;
                    melodiousSleep = true;
                    //change HP bar
                    if (p1character == "Ort")
                    {
                        for (int i = p2hp; i > opponentHP && i > 0; i--)
                        {
                            p2HPBar.Size = new Size(i, 10);
                            Thread.Sleep(50);
                            Refresh();
        }
                    }
                    else if (p2character == "Ort")
                    {
                        for (int i = p1hp; i > opponentHP && i > 0; i--)
                        {
                            p1HPBar.Size = new Size(i, 10);
                            Thread.Sleep(50);
                            Refresh();
                        }
                    }
                    //check if fainted
                    if (opponentHP <= 0)
                    {
                        battleStatusOutput.Text = "The opponent fainted!";
                        Thread.Sleep(sleepTime);
                        Refresh();

                        ScreenControl.changeScreen(this, "MultiEndScreen");
                    }
                }
                //check if dead
                else
        {
                    battleStatusOutput.Text = "But the opponent wasn't listening!";
                    Thread.Sleep(sleepTime);
                    Refresh();
                }
                //return stat changes
                if (p1character == "Ort")
                {
                    p2hp = opponentHP;
                }
                else if (p2character == "Ort")
                {
                    p1hp = opponentHP;
                }
            }
            else if (ortSleep == true)
            {
                battleStatusOutput.Text = "The band needs to rest!";
                Thread.Sleep(sleepTime);
                Refresh();
                ortSleep = false;
            }
            else if (melodiousSleep == true)
            {
                battleStatusOutput.Text = "The band just played that!";
                Thread.Sleep(sleepTime);
                Refresh();
                melodiousSleep = false;
            }
        }

        public void MultiQuestion()//Leitch done?
        {
            int playerAtk = 0;
            int opponentHP = 1;
            int opponentDef = 0;
            if (leitchSleep == 0)
            {
                if (p1character == "Leitch")
                {
                    playerAtk = p1Atk;
                    opponentHP = p2hp;
                    opponentDef = p2Def;
        }
                else if (p2character == "Leitch")
                {
                    playerAtk = p2Atk;
                    opponentHP = p1hp;
                    opponentDef = p1Def;
                }
                battleStatusOutput.Text = "Leitch gave out a Multiple Choice Question!";
                Thread.Sleep(sleepTime);
                Refresh();
                if (randNum.Next(1, 101) < 75)
                {
                    //damage calc
                    opponentHP -= (((42 * playerAtk * 90 / opponentDef) / 50) + 2)
                        * randNum.Next(1, 101) / 100;

                    //Change HPbar
                    if (p1character == "Leitch")
                    {
                        for (int i = p2hp; i > opponentHP && i > 0; i--)
                        {
                            p2HPBar.Size = new Size(i, 10);
                            Thread.Sleep(50);
                            Refresh();
                        }
                    }
                    else if (p2character == "Leitch")
                    {
                        for (int i = p1hp; i > opponentHP && i > 0; i--)
                        {
                            p1HPBar.Size = new Size(i, 10);
                            Thread.Sleep(50);
                            Refresh();
                        }
                    }
                    //check if opponent dead
                    if (opponentHP <= 0)
                    {
                        battleStatusOutput.Text = "The opponent fainted!";
                        Thread.Sleep(sleepTime);
                        Refresh();
                        ScreenControl.changeScreen(this, "MultiEndScreen");
                    }
                }
                else
                {
                    battleStatusOutput.Text = "But it was Answered correct!";
                    Thread.Sleep(sleepTime);
                    Refresh();
                }
                if (p1character == "Leitch")
                {                    
                    p2hp = opponentHP;
                }
                else if (p2character == "Leitch")
                {
                    p1hp = opponentHP;
                }
            }
            else
            {
                battleStatusOutput.Text = "The class is still asleep!";
                Thread.Sleep(sleepTime);
                Refresh();
                leitchSleep--;
            }
        }

        public void PinkPaper()//Steel not done
        {
            //variables
            int playerAtk = 1;
            int playerHP = 1;
            int opponentDef = 1;
            int opponentHP = 0;
            int damage = 0;

            //assign to current player
            if (p1character == "Steel")
            {
                playerAtk = p1Atk;
                playerHP = p1hp;
                opponentDef = p2Def;
                opponentHP = p2hp;
            }
            else if (p2character == "Steel")
            {
                playerAtk = p2Atk;
                playerHP = p2hp;
                opponentDef = p1Def;
                opponentHP = p1hp;
            }

            battleStatusOutput.Text = "Steel handed out a Pink Paper";
            Thread.Sleep(sleepTime);
            Refresh();

            //check if attack hits
            if (randNum.Next(1, 101) <= 90)
            {
                //damage calc
                damage = (((42 * playerAtk * 65 / opponentDef) / 50) + 2)
                    * randNum.Next(1, 101) / 100;
                opponentHP -= damage;
                playerHP += damage / 2;

                //change HP bar
                if (p1character == "Steel")
                {
                    for (int i = p2hp; i > opponentHP && i > 0; i--)
                    {
                        p2HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                        Refresh();
                    }
                }
                else if (p2character == "Steel")
                {
                    for (int i = p1hp; i > opponentHP && i > 0; i--)
                {
                        p1HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                        Refresh();
                    }
                }
                //check if fainted opponent fainted
                if (opponentHP <= 0)
                {
                    battleStatusOutput.Text = "The opponent fainted!";
                    Thread.Sleep(sleepTime);
                    Refresh();

                    ScreenControl.changeScreen(this, "MultiEndScreen");
                }
                if (p1character == "Steel")
                {
                    for (int i = p1hp; i < playerHP && i > 0; i++)
                    {
                        p1HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                        Refresh();
                    }
                }
                else if (p2character == "Steel")
                {
                    for (int i = p2hp; i < playerHP && i > 0; i++)
                    {
                        p2HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                        Refresh();
                    }
                }
                battleStatusOutput.Text = "Steel sapped life from his students!";
                Thread.Sleep(sleepTime);
                Refresh();
                                
            }
            //check if missed
            else
            {
                battleStatusOutput.Text = "But the opponent brought a $100 calculator!";
                Thread.Sleep(sleepTime);
                Refresh();
            }
            //return stat changes
            if (p1character == "Steel")
            {
                p1hp = playerHP;
                p2hp = opponentHP;
            }
            else if (p2character == "Steel")
            {
                p2hp = playerHP;
                p1hp = opponentHP;
            }
        }

        public void PushUps()//Cutch done
        {
            int playerAtk = 0;
            if (p1character == "Cutch")
            {
                playerAtk = p1Atk;
            }
            else if (p2character == "Cutch")
            {
                playerAtk = p2Atk;
        }
            battleStatusOutput.Text = "McCutcheon did some Pushups!";
            Thread.Sleep(sleepTime);
            Refresh();

            playerAtk += 25;
            battleStatusOutput.Text = "McCutcheons Attack rose!";
            Thread.Sleep(sleepTime);
            Refresh();
            if (playerAtk > 250)
            {
                playerAtk = 250;
                battleStatusOutput.Text = "McCutcheons Attack can't go any higher!";
                Thread.Sleep(sleepTime);
                Refresh();
            }
            if (p1character == "Cutch")
            {
                p1Atk = playerAtk;
            }
            else if (p2character == "Cutch")
        {
                p1Atk = playerAtk;
            }
        }

        public void QuadraticAttack()//Steel done
        {
            //variables
            int playerAtk = 1;
            int opponentDef = 1;
            int opponentHP = 0;
            int damage = 0;
            int quad = randNum.Next(1, 6) * 20 + 20;
            //assign to current player
            if (p1character == "Steel")
            {
                playerAtk = p1Atk;
                opponentDef = p2Def;
                opponentHP = p2hp;
            }
            else if (p2character == "Steel")
            {
                playerAtk = p2Atk;
                opponentDef = p1Def;
                opponentHP = p1hp;
        }

            battleStatusOutput.Text = "Steel attacked using a quadratic expression!";
            Thread.Sleep(sleepTime);
            Refresh();

            //check if attack hits
            if (randNum.Next(1, 101) <= 90)
            {
                //damage calc
                damage = (((42 * playerAtk * quad / opponentDef) / 50) + 2)
                    * randNum.Next(1, 101) / 100;
                opponentHP -= damage;

                //change HP bar
                if (p1character == "Steel")
                {
                    for (int i = p2hp; i > opponentHP && i > 0; i--)
                    {
                        p2HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                        Refresh();
                    }
                }
                else if (p2character == "Steel")
                {
                    for (int i = p1hp; i > opponentHP && i > 0; i--)
                    {
                        p1HPBar.Size = new Size(i, 10);
                        Thread.Sleep(50);
                        Refresh();
                    }
                }
                //check if fainted
                if (opponentHP <= 0)
        {
                    battleStatusOutput.Text = "The opponent fainted!";
                    Thread.Sleep(sleepTime);
                    Refresh();

                    ScreenControl.changeScreen(this, "MultiEndScreen");
                }
            }
            //check if missed
            else
            {
                battleStatusOutput.Text = "But the opponent knew the solution!";
                Thread.Sleep(sleepTime);
                Refresh();
            }
            //return stat changes
            if (p1character == "Steel")
            {
                p2hp = opponentHP;
            }
            else if (p2character == "Steel")
            {
                p1hp = opponentHP;
            }
        }

        public void TalkAboutFamily()//Bond DONE
        {
            //intergers
            int playerHP = 0;
            int playerDef = 0;
            //assigns stats to current players
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

            battleStatusOutput.Text = "Bond told a long story about his family!";
            Thread.Sleep(sleepTime);
            Refresh();
            //Health restoration
            playerHP += 38;
            if (playerHP > 150)
            {
                playerHP = 150;
            }
            if (p1character == "Bond")
            {
                p1HPBar.Size = new Size(playerHP, 10);
            }
            else if (p2character == "Bond")
            {
                p2HPBar.Size = new Size(playerHP, 10);
            }
            battleStatusOutput.Text = "Bond restored his HP!";
            Thread.Sleep(sleepTime);
            Refresh();

            //defence increase
            playerDef += 25;
            battleStatusOutput.Text = "Bonds Defence increased!";
            Thread.Sleep(sleepTime);
            Refresh();

            if (playerDef > 250)
            {
                playerDef = 250;
                battleStatusOutput.Text = "Bonds Defence can't go any higher!";
                Thread.Sleep(sleepTime);
                Refresh();
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

        public void TextbookBarricade()//Steel DONE
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
            battleStatusOutput.Text = "Steel used his engineer skills to make a Textbook Barricade!";
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

        public void Tuning()//Ort DONE
        {
            melodiousSleep = false;

            int playerHP = 0;
            if (p1character == "Ort")
            {
                playerHP = p1hp;
            }
            else if (p2character == "Ort")
            {
                playerHP = p2hp;
            }

            if (ortSleep == false)
            {                
                battleStatusOutput.Text = "Ortelli allowed the flutes to tune!";
            Thread.Sleep(sleepTime);
                Refresh();
            playerHP += 88;
            if (playerHP < 175)
            {
                playerHP = 175;
            }
            battleStatusOutput.Text = "Ortelli restored her HP!";
            Thread.Sleep(sleepTime);
                Refresh();
                if (p1character == "Ort")
                {
                    p1HPBar.Size = new Size(playerHP, 10);
                }
                else if (p2character == "Ort")
                {
                    p2HPBar.Size = new Size(playerHP, 10);
                }
            }
            else
            {
                ortSleep = false;
                battleStatusOutput.Text = "The band needs to rest!";
                Thread.Sleep(sleepTime);
                Refresh();
            }
            if (p1character == "Ort")
            {
                p1hp = playerHP;
            }
            else if (p2character == "Ort")
            {
                p2hp = playerHP;
            }
        }

        public void VideoFriday()//Brad DONE
        {
            int playerHP = 0;
            if (p1character == "Brad")
            {
                playerHP = p1hp;
            }
            else if (p2character == "Brad")
            {
                playerHP = p2hp;
            }

            battleStatusOutput.Text = "Bradshaw honored the Video Friday Tradition!";
            Thread.Sleep(sleepTime);
            Refresh();

            playerHP += 75;
            if (playerHP > 150)
            {
                playerHP = 150;
            }
            if (p1character == "Brad")
            {
                p1HPBar.Size = new Size(playerHP, 10);
            }
            else if (p2character == "Brad")
            {
                p2HPBar.Size = new Size(playerHP, 10);
            }
            battleStatusOutput.Text = "Bradshaw restored his HP!";
            Thread.Sleep(sleepTime);
            Refresh();

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
                //moveSelectTimer.Enabled = false;
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
                                Documentary();
                                break;
                            case "Cutch":
                                Dodgeball();
                                break;
                            case "Ort":
                                ClarinetSqueak();
                                break;
                            case "Steel":
                                EqualSign();
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
                                DunkOn();
                                break;
                            case "Ort":
                                FullBandFF();
                                break;
                            case "Steel":
                                PinkPaper();
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
                                HistoricWar();
                                break;
                            case "Cutch":
                                PushUps();
                                break;
                            case "Ort":
                                MelodiousPassage();
                                break;
                            case "Steel":
                                QuadraticAttack();
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
                                HealthClass();
                                break;
                            case "Ort":
                                Tuning();
                                break;
                            case "Steel":
                                TextbookBarricade();
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
                                    Documentary();
                                    break;
                                case "Cutch":
                                    Dodgeball();
                                    break;
                                case "Ort":
                                    ClarinetSqueak();
                                    break;
                                case "Steel":
                                    EqualSign();
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
                                    DunkOn();
                                    break;
                                case "Ort":
                                    FullBandFF();
                                    break;
                                case "Steel":
                                    PinkPaper();
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
                                    HistoricWar();
                                    break;
                                case "Cutch":
                                    PushUps();
                                    break;
                                case "Ort":
                                    MelodiousPassage();
                                    break;
                                case "Steel":
                                    QuadraticAttack();
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
                                    HealthClass();
                                    break;
                                case "Ort":
                                    Tuning();
                                    break;
                                case "Steel":
                                    TextbookBarricade();
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
                                    ClarinetSqueak();
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
                                    Documentary();
                                    break;
                                case "Cutch":
                                    Dodgeball();
                                    break;
                                case "Ort":
                                    ClarinetSqueak();
                                    break;
                                case "Steel":
                                    EqualSign();
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
                                    DunkOn();
                                    break;
                                case "Ort":
                                    FullBandFF();
                                    break;
                                case "Steel":
                                    PinkPaper();
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
                                    HistoricWar();
                                    break;
                                case "Cutch":
                                    PushUps();
                                    break;
                                case "Ort":
                                    MelodiousPassage();
                                    break;
                                case "Steel":
                                    QuadraticAttack();
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
                                    HealthClass();
                                    break;
                                case "Ort":
                                    Tuning();
                                    break;
                                case "Steel":
                                    TextbookBarricade();
                                    break;
                                default:
                                    break;
                            }
                        }
                        #endregion
                        #endregion
                    }
                }
                //moveSelectTimer.Enabled = true;
            }
            else
            {

            }
        }

        #region Button Clicks
        private void p1Yellow_Click(object sender, EventArgs e)
        {
            p1moveSelect = true;
            p1move1 = true;
            p1move2 = false;
            p1move3 = false;
            p1move4 = false;
            battleStatusOutput.Text = "Player 1 has decided";
        }

        private void p1Blue_Click(object sender, EventArgs e)
        {
            p1moveSelect = true;
            p1move1 = false;
            p1move2 = true;
            p1move3 = false;
            p1move4 = false;
            battleStatusOutput.Text = "Player 1 has decided";
        }

        private void p1Red_Click(object sender, EventArgs e)
        {
            p1moveSelect = true;
            p1move1 = false;
            p1move2 = false;
            p1move3 = true;
            p1move4 = false;
            battleStatusOutput.Text = "Player 1 has decided";
        }

        private void p1Green_Click(object sender, EventArgs e)
        {
            p1moveSelect = true;
            p1move1 = false;
            p1move2 = false;
            p1move3 = false;
            p1move4 = true;
            battleStatusOutput.Text = "Player 1 has decided";
        }

        private void p2Yellow_Click(object sender, EventArgs e)
        {
            p2moveSelect = true;
            p2move1 = true;
            p2move2 = false;
            p2move3 = false;
            p2move4 = false;
            battleStatusOutput.Text = "Player 2 has decided";
        }

        private void p2Blue_Click(object sender, EventArgs e)
        {
            p2moveSelect = true;
            p2move1 = false;
            p2move2 = true;
            p2move3 = false;
            p2move4 = false;
            battleStatusOutput.Text = "Player 2 has decided";
        }

        private void p2Red_Click(object sender, EventArgs e)
        {
            p2moveSelect = true;
            p2move1 = false;
            p2move2 = false;
            p2move3 = true;
            p2move4 = false;
            battleStatusOutput.Text = "Player 2 has decided";
        }

        private void p2Green_Click(object sender, EventArgs e)
        {
            p2moveSelect = true;
            p2move1 = false;
            p2move2 = false;
            p2move3 = false;
            p2move4 = true;
            battleStatusOutput.Text = "Player 2 has decided";
        }
        #endregion
    }
}
