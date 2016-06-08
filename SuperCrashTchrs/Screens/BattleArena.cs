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

        bool p1moveOK = false;
        bool p2moveOK = false;

        string p1character, p2character;
        int p1hp, p1Atk, p1Def, p1Spd, p2hp, p2Atk, p2Def, p2Spd;
        int sleepTime = 1000;

        //attack and damage sound players
        SoundPlayer attackPlayer = new SoundPlayer(Properties.Resources.Attack_Sound);
        SoundPlayer damagePlayer = new SoundPlayer(Properties.Resources.Pain_Sound);

        int leitchSleep = 0;
        bool ortSleep = false;
        bool melodiousSleep = false;
        #endregion

        public BattleArena()
        {
            InitializeComponent();
            moveSelectTimer.Enabled = true;
        }

        public static Random randNum = new Random();

        //Button Presses
        private void BattleArena_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                #region player 1 keys
                case Keys.N:
                    p1moveOK = true;
                    battleStatusOutput.Text = "Player 1 has decided";
                    break;
                case Keys.B:
                    p1moveOK = true;
                    battleStatusOutput.Text = "Player 1 has decided";
                    break;
                case Keys.M:
                    p1moveOK = true;
                    battleStatusOutput.Text = "Player 1 has decided";
                    break;
                case Keys.Space:
                    p1moveOK = true;
                    battleStatusOutput.Text = "Player 1 has decided";
                    break;
                #endregion

                #region player 2 keys
                case Keys.V:
                    p2moveOK = true;
                    battleStatusOutput.Text = "Player 2 has decided";
                    break;
                case Keys.C:
                    p2moveOK = true;
                    battleStatusOutput.Text = "Player 2 has decided";
                    break;
                case Keys.X:
                    p2moveOK = true;
                    battleStatusOutput.Text = "Player 2 has decided";
                    break;
                case Keys.Z:
                    p2moveOK = true;
                    battleStatusOutput.Text = "Player 2 has decided";
                    break;
                #endregion

                default:
                    break;
            }
        }

        #region Character Moves
        public int AttackBot(int OPhP, int bradAtk, int OPDef, int OPAtk)//Brad DONE; sound in; no bugs
        {

            //display text
            battleStatusOutput.Text = "Bradshaw used Attack Bot!";
            Thread.Sleep(sleepTime);
            Refresh();

            //check if move hits
            if (randNum.Next(1, 101) <= 95)
            {
                //choose which teacher to use
                if (Form1.teacher[0].name == "Brad")
                {
                    //attack sound
                    attackPlayer.Play();
                    //damage calculation
                    OPhP = OPhP - (((42 * bradAtk * 30 / OPDef) / 50) + 2) * randNum.Next(1, 101) / 100;
                    //play damage sound before changing hp
                    damagePlayer.Play();
                    //lower attack
                    OPAtk -= 25;
                    //display message
                    battleStatusOutput.Text = "The opponents Attack was lowered!";
                    Thread.Sleep(sleepTime);
                    Refresh();
                    if (OPAtk <= 0)
                    {
                        OPAtk = 1;
                        //display message
                        battleStatusOutput.Text = "The opponents Attack can't go any lower!";
                        Thread.Sleep(sleepTime);
                        Refresh();
                    }
                    return OPhP;
                    return OPAtk;
                }
            }

            //if attack misses    
            else
            {
                battleStatusOutput.Text = "But the robot malfunctioned!";
                Thread.Sleep(sleepTime);
                Refresh();
            }
        }

        public void ClarinetSqueak()//Ort; needs sound DONE
        {
            //set sleep for melodious passage off
            melodiousSleep = false;
            //check which teacher to use
            if (Form1.teacher[0].name == "Ortelli")
            {
                //remove 25 points from opponent's defence
                Form1.teacher[1].def -= 25;
                battleStatusOutput.Text = "The opponents defence was lowered!";
                Thread.Sleep(sleepTime);
                Refresh();
                //make sure opponent's defence isn't lower than 1
                if (Form1.teacher[1].def <= 0)
                {
                    Form1.teacher[1].def = 1;
                    battleStatusOutput.Text = "The opponents defence cannot go any lower!";
                    Thread.Sleep(sleepTime);
                    Refresh();
                }
            }
            else if (Form1.teacher[1].name == "Ortelli")
            {
                //remove 25 points from opponent's defence
                Form1.teacher[0].def -= 25;
                battleStatusOutput.Text = "The opponents defence was lowered!";
                Thread.Sleep(sleepTime);
                Refresh();
                //make sure opponent's defence isn't lower than 1
                if (Form1.teacher[0].def <= 0)
                {
                    Form1.teacher[0].def = 1;
                    battleStatusOutput.Text = "The opponents defence cannot go any lower!";
                    Thread.Sleep(sleepTime);
                    Refresh();
                }
            }
            if (ortSleep == false)
            {
                battleStatusOutput.Text = "A Clairinet in the Band (Ben F.) created an obnoxious squeak!";
                Thread.Sleep(sleepTime);
                Refresh();
            }
            else if (ortSleep == true)
            {
                ortSleep = false;
                battleStatusOutput.Text = "Ortelli needs to recover!";
                Thread.Sleep(sleepTime);
                Refresh();
            }
        }

        public void ComplainAbout()//Brad; with sound; DONE
        {
            //display text
            battleStatusOutput.Text = "Bradshaw used Complain About Apple!";
            Thread.Sleep(sleepTime);
            Refresh();

            //check if attack hits
            if (randNum.Next(1, 101) <= 90)
            {
                if (Form1.teacher[0].name == "Brad")
                {
                    //attack sound
                    attackPlayer.Play();
                    //damage calc
                    Form1.teacher[1].hP = Form1.teacher[1].hP - (((42 * Form1.teacher[0].atk * 75 /
                        Form1.teacher[1].def) / 50) + 2) * randNum.Next(1, 101) / 100;
                    //play damage sound
                    damagePlayer.Play();
                }
                else if (Form1.teacher[1].name == "Brad")
                {
                    //attack sound
                    attackPlayer.Play();
                    //damage calc
                    Form1.teacher[0].hP = Form1.teacher[0].hP - (((42 * Form1.teacher[1].atk * 75 /
                        Form1.teacher[0].def) / 50) + 2) * randNum.Next(1, 101) / 100;
                    //play damage sound
                    damagePlayer.Play();
                }
            }
            else
            {
                battleStatusOutput.Text = "But the opponent never liked apple in the first place!";
                Thread.Sleep(sleepTime);
                Refresh();
            }
        }

        public void CriteriaChart()//Bond; needs sound DONE
        {
            battleStatusOutput.Text = "Bond used Critera Chart!";
            Thread.Sleep(sleepTime);
            Refresh();
            //use proper teacher stats
            if (Form1.teacher[0].name == "Bond")
            {
                Form1.teacher[0].atk += 25;
                battleStatusOutput.Text = "Bonds Attack rose!";
                Thread.Sleep(sleepTime);
                Refresh();
                //make sure bond's attack doesn't go above limit
                if (Form1.teacher[0].atk > 250)
                {
                    Form1.teacher[0].atk = 250;
                    battleStatusOutput.Text = "Bonds Attack can't go any higher!";
                    Thread.Sleep(sleepTime);
                    Refresh();
                }
                //increase bond's speed
                Form1.teacher[0].spd += 25;
                battleStatusOutput.Text = "Bonds Speed rose!";
                Thread.Sleep(sleepTime);
                Refresh();
                // make sure speed doesn't go over limit
                if (Form1.teacher[0].spd > 250)
                {
                    Form1.teacher[0].spd = 250;
                    battleStatusOutput.Text = "Bonds Speed can't go any higher!";
                    Thread.Sleep(sleepTime);
                    Refresh();
                }
            }
            else if (p2character == "Bond")
            {
                //increase Bond's attack
                Form1.teacher[0].atk += 25;
                battleStatusOutput.Text = "Bonds Attack rose!";
                Thread.Sleep(sleepTime);
                Refresh();
                //make sure Bond's attack doesn't go above limit
                if (Form1.teacher[0].atk > 250)
                {
                    Form1.teacher[0].atk = 250;
                    battleStatusOutput.Text = "Bonds Attack can't go any higher!";
                    Thread.Sleep(sleepTime);
                    Refresh();
                }
                //increase Bond's speed
                Form1.teacher[0].spd += 25;
                battleStatusOutput.Text = "Bonds Speed rose!";
                Thread.Sleep(sleepTime);
                Refresh();
                // make sure speed doesn't go over limit
                if (Form1.teacher[0].spd > 250)
                {
                    Form1.teacher[0].spd = 250;
                    battleStatusOutput.Text = "Bonds Speed can't go any higher!";
                    Thread.Sleep(sleepTime);
                    Refresh();
                }
            }
        }

        public void DefenderBot()//Brad; needs sound kinda done
        {
            //Send message
            battleStatusOutput.Text = "Bradshaw created a robot to defend himself!";
            Thread.Sleep(sleepTime);
            Refresh();
            //check which stats to use
            if (Form1.teacher[0].name == "Brad")
            {
                //raise Bradshaw's defence
                Form1.teacher[0].def += 25;
                battleStatusOutput.Text = "Bradshaws Defence was raised!";
                Thread.Sleep(sleepTime);
                Refresh();
                //Make sure defence doesn't go over limit
                if (Form1.teacher[0].def > 225)
                {
                    Form1.teacher[0].def = 225;
                    battleStatusOutput.Text = "Bradshaws Defence can't go any higher!";
                    Thread.Sleep(sleepTime);
                    Refresh();
                }
            }
            else if (Form1.teacher[1].name == "Brad")
            {
                //raise Bradshaw's defence
                Form1.teacher[1].def += 25;
                battleStatusOutput.Text = "Bradshaws Defence was raised!";
                Thread.Sleep(sleepTime);
                Refresh();
                //make sure defence doesn't go over limit
                if (Form1.teacher[1].def > 225)
                {
                    Form1.teacher[1].def = 225;
                    battleStatusOutput.Text = "Bradshaws Defence can't go any higher!";
                    Thread.Sleep(sleepTime);
                    Refresh();
                }
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
                playerHP = Form1.leitchHP;
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

            int accuracyHit = randNum.Next(1, 101);
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
                    * randNum.Next(1, 101) / 100;
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
                //if (opponentHP <= 0)
                //{
                //    battleStatusOutput.Text = "The opponent fainted!";
                //    Thread.Sleep(sleepTime);
                //    Refresh();
                //    //go to game over screen
                //    ScreenControl.changeScreen(this, "MultiEndScreen");
                //}
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
                ////check if fainted
                //if (opponentHP <= 0)
                //{
                //    battleStatusOutput.Text = "The opponent fainted!";
                //    Thread.Sleep(sleepTime);
                //    Refresh();

                //    ScreenControl.changeScreen(this, "MultiEndScreen");
                //}
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
                    //if (opponentHP <= 0)
                    //{
                    //    battleStatusOutput.Text = "The opponent fainted!";
                    //    Thread.Sleep(sleepTime);
                    //    Refresh();

                    //    ScreenControl.changeScreen(this, "MultiEndScreen");
                    //}
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
                ////check if fainted opponent fainted
                //if (opponentHP <= 0)
                //{
                //    battleStatusOutput.Text = "The opponent fainted!";
                //    Thread.Sleep(sleepTime);
                //    Refresh();

                //    ScreenControl.changeScreen(this, "MultiEndScreen");
                //}                
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

                if (playerHP <= 0)
                {
                    battleStatusOutput.Text = "McCutcheon fainted!";
                    Thread.Sleep(sleepTime);
                    Refresh();

                    //ScreenControl.changeScreen(this, "MultiEndScreen");
                }
            }
            //check if dead
            //    else
            //    {
            //    battleStatusOutput.Text = "But the opponent skipped this class!";
            //    Thread.Sleep(sleepTime);
            //    Refresh();
            //}
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
                    ////check if fainted opponent fainted
                    //if (opponentHP <= 0)
                    //{
                    //    battleStatusOutput.Text = "The opponent fainted!";
                    //    Thread.Sleep(sleepTime);
                    //    Refresh();

                    //    ScreenControl.changeScreen(this, "MultiEndScreen");
                    //}
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

                        //ScreenControl.changeScreen(this, "MultiEndScreen");
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
                ////checks if opponent dead
                //if (opponentHP <= 0)
                //{
                //    battleStatusOutput.Text = "The opponent fainted!";
                //    Thread.Sleep(sleepTime);
                //    Refresh();

                //    ScreenControl.changeScreen(this, "MultiEndScreen");
                //}
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
                    ////check if fainted
                    //if (opponentHP <= 0)
                    //{
                    //    battleStatusOutput.Text = "The opponent fainted!";
                    //    Thread.Sleep(sleepTime);
                    //    Refresh();

                    //    ScreenControl.changeScreen(this, "MultiEndScreen");
                    //}
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
                    //if (opponentHP <= 0)
                    //{
                    //    battleStatusOutput.Text = "The opponent fainted!";
                    //    Thread.Sleep(sleepTime);
                    //    Refresh();
                    //    ScreenControl.changeScreen(this, "MultiEndScreen");
                    //}
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
                //if (opponentHP <= 0)
                //{
                //    battleStatusOutput.Text = "The opponent fainted!";
                //    Thread.Sleep(sleepTime);
                //    Refresh();

                //    ScreenControl.changeScreen(this, "MultiEndScreen");
                //}
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
                //        if (opponentHP <= 0)
                //{
                //            battleStatusOutput.Text = "The opponent fainted!";
                //            Thread.Sleep(sleepTime);
                //            Refresh();

                //            ScreenControl.changeScreen(this, "MultiEndScreen");
                //        }
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
            if (p1moveOK == true && p2moveOK == true)
            {
                p1moveOK = false;
                p2moveOK = false;

                //p1 goes first
                if (Form1.teacher[0].spd > Form1.teacher[1].spd)
                {
                    p1MoveSelect();
                    p2MoveSelect();
                }

                //p2 goes first
                if (Form1.teacher[0].spd < Form1.teacher[1].spd)
                {
                    p2MoveSelect();
                    p1MoveSelect();
                }

                //speed tie
                if (Form1.teacher[0].spd == Form1.teacher[1].spd)
                {
                    //p1 goes first
                    if (randNum.Next(1, 3) == 1)
                    {
                        p1MoveSelect();
                        p2MoveSelect();
                    }

                    //p2 goes first
                    else
                    {
                        p2MoveSelect();
                        p1MoveSelect();
                    }
                }
            }
        }

        public void p1MoveSelect()
        {
            #region move 1
            switch (Form1.teacher[0].move1)
            {
                case "CriteriaChart":
                    CriteriaChart();
                    break;
                case "AttackBot":
                    AttackBot(Form1.teacher[1].hP, Form1.teacher[0].atk, Form1.teacher[1].def, Form1.teacher[1].atk);
                    Form1.teacher[1].hP =
                    break;
                case "Documentary":
                    //Documentary
                    break;
                case "Dodgeball":
                    Dodgeball();
                    break;
                case "ClarinetSpeak":
                    ClarinetSqueak();
                    break;
                case "EqualSign":
                    //EqualSign
                    break;
                default:
                    break;
            }
            #endregion

            #region move 2
            switch (Form1.teacher[0].move2)
            {
                case "Dissection":
                    Dissection();
                    break;
                case "ComplainAboutApple":
                    ComplainAbout();
                    break;
                case "EssayQuestion":
                    EssayQuestion();
                    break;
                case "Dunk-On":
                    //DunkOn
                    break;
                case "FullBandFortissimo":
                    //FullBandFF
                    break;
                case "PinkPaper":
                    //PinkPaper
                    break;
                default:
                    break;
            }
            #endregion

            #region move 3
            switch (Form1.teacher[0].move3)
            {
                case "MadExperiment":
                    MadExperiment();
                    break;
                case "DefenderBot":
                    DefenderBot();
                    break;
                case "HistoricWar":
                    //HistoricWar
                    break;
                case "PushUps":
                    //PushUps
                    break;
                case "MelodiousPassage":
                    //MelodiousPassage
                    break;
                case "QuadraticAttack":
                    //QuadraticAttack
                    break;
                default:
                    break;

            }
            #endregion

            #region move 4

            switch (Form1.teacher[0].move4)
            {
                case "TalkAboutFamily":
                    TalkAboutFamily();
                    break;
                case "VideoFriday":
                    VideoFriday();
                    break;
                case "MultipleChoiceQuestion":
                    MultiQuestion();
                    break;
                case "HealthClass":
                    //HealthClass
                    break;
                case "Tuning":
                    Tuning();
                    break;
                case "TextbookBarricade":
                    //TextbookBarricade
                    break;
                default:
                    break;

            }
            #endregion
        }

        public void p2MoveSelect()
        {
            #region move 1
            switch (Form1.teacher[1].move1)
            {
                case "CriteriaChart":
                    CriteriaChart();
                    break;
                case "AttackBot":
                    AttackBot(Form1.teacher[0].hP, Form1.teacher[1].atk, Form1.teacher[0].def, Form1.teacher[0].atk);
                    break;
                case "Documentary":
                    //Documentary
                    break;
                case "DODGEBALL":
                    //DODGEBALL
                    break;
                case "ClarinetSqueak":
                    //ClairinetSqueak
                    break;
                case "=":
                    //EqualSign
                    break;
                default:
                    break;
            }
            #endregion

            #region move 2
            switch (Form1.teacher[1].move2)
            {
                case "Dissection":
                    Dissection();
                    break;
                case "ComplainAboutApple":
                    ComplainAbout();
                    break;
                case "EssayQuestion":
                    //EssayQuestion
                    break;
                case "Dunk-On":
                    //DunkOn
                    break;
                case "FullBandFortissimo":
                    //FullBandFF
                    break;
                case "PinkPaper":
                    //PinkPaper
                    break;
                default:
                    break;
            }
            #endregion

            #region move 3
            switch (Form1.teacher[1].move3)
            {
                case "MadExperiment":
                    MadExperiment();
                    break;
                case "DefenderBot":
                    DefenderBot();
                    break;
                case "HistoricWar":
                    //HistoricWar
                    break;
                case "PushUps":
                    //PushUps
                    break;
                case "MelodiousPassage":
                    //MelodiousPassage
                    break;
                case "QuadraticAttack":
                    //QuadraticAttack
                    break;
                default:
                    break;
            }
            #endregion

            #region move 4
            switch (Form1.teacher[1].move4)
            {
                case "TalkAboutFamily":
                    TalkAboutFamily();
                    break;
                case "VideoFriday":
                    VideoFriday();
                    break;
                case "MultipleChoiceQuestion":
                    //MCQuestion
                    break;
                case "HealthClass":
                    //HealthClass
                    break;
                case "Tuning":
                    //Tuning
                    break;
                case "TextbookBarricade":
                    //TextbookBarricade
                    break;
                default:
                    break;
            }
            #endregion
        }
    }
}

