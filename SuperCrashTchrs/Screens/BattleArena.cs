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

        string player;
        int sleepTime = 1000;

        //attack and damage sound players
        SoundPlayer attackPlayer = new SoundPlayer(Properties.Resources.Attack_Sound);
        SoundPlayer damagePlayer = new SoundPlayer(Properties.Resources.Pain_Sound);

        int leitchSleep = 0;
        bool ortSleep = false;
        bool melodiousSleep = false;

        int atkLimit = 250;
        int defLimit = 275;
        int spdLimit = 250;

        int p1InitialHP = Form1.teacher[0].hP;
        int p2InitialHP = Form1.teacher[1].hP;
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

        public void AttackBot(string player)
        {
            //send move initiation message
            battleStatusOutput.Text = "Bradshaw got his Attack Bot!";
            Thread.Sleep(sleepTime);
            Refresh();

            //if attack hits
            if (randNum.Next(1, 11) > 1)
            {
                if (player == "p1")
                {
                    //calculate damage (power of 30)
                    Form1.teacher[1].hP = HitCalc(Form1.teacher[1].hP, Form1.teacher[1].def, Form1.teacher[0].atk, 30);

                    //lower attack of opponent by one stage (25)
                    Form1.teacher[1].atk = StatLower(Form1.teacher[1].atk, 25, "Attack");
                }

                else
                {
                    //calculate damage (power of 30)
                    Form1.teacher[0].hP = HitCalc(Form1.teacher[0].hP, Form1.teacher[0].def, Form1.teacher[1].atk, 30);

                    //lower attack of opponent by one stage (25)
                    Form1.teacher[0].atk = StatLower(Form1.teacher[0].atk, 25, "Attack");
                }
            }

            else
            {
                //if attack doesn't hit, send move failed message
                battleStatusOutput.Text = "But the bot failed to boot up!";
                Thread.Sleep(sleepTime);
                Refresh();
            }
        }

        public void ClarinetSqueak(string player)
        {
            //send move initiation message
            battleStatusOutput.Text = "Ben Fortin's clarinet squeaked!";
            Thread.Sleep(sleepTime);
            Refresh();

            //chose correct player
            if (player == "p1")
            {
                //lower opponent's defence stat by one stage (25)
                Form1.teacher[1].def = StatLower(Form1.teacher[1].def, 25, "Defence");
            }
            else
            {
                //lower opponent's defence stat by one stage (25)
                Form1.teacher[0].def = StatLower(Form1.teacher[0].def, 25, "Defence");
            }
        }

        public void CriteriaChart(string player)
        {
            // send move initiation message
            battleStatusOutput.Text = "Bond put a criteria chart on the test!";
            Thread.Sleep(sleepTime);
            Refresh();

            if(player == "p1")
            {
                //raise speed and attack of Bond
                Form1.teacher[0].atk = StatRaise(Form1.teacher[0].atk, atkLimit, "Attack");
                Form1.teacher[0].spd = StatRaise(Form1.teacher[0].spd, spdLimit, "Speed");
            }

            else
            {
                //raise speed and attack of Bond
                Form1.teacher[1].atk = StatRaise(Form1.teacher[1].atk, atkLimit, "Attack");
                Form1.teacher[1].spd = StatRaise(Form1.teacher[1].spd, spdLimit, "Speed");
            }

        }

        public void Dissection(string player)//not done
        {

        }

        public void Documentary(string player)
        {
            // send move initiation message
            battleStatusOutput.Text = "Leitch put a documentary on!";
            Thread.Sleep(sleepTime);
            Refresh();

            //choose correct player as Leitch, raise HP
            if (player == "p1")
            {
                Form1.teacher[0].hP = HPRaise(Form1.teacher[0].hP, p1InitialHP, 1);
            }
            else
            {
                Form1.teacher[1].hP = HPRaise(Form1.teacher[1].hP, p1InitialHP, 1);
            }
            // send move initiation message
            battleStatusOutput.Text = "But the class fell asleep while watching!";
            Thread.Sleep(sleepTime);
            Refresh();

        }

        public void Dodgeball(string player)
        {
            // send move initiation message
            battleStatusOutput.Text = "McCutcheon played DODGEBALL!";
            Thread.Sleep(sleepTime);
            Refresh();

            if (player == "p1")
            {
                if (randNum.Next(1, 11) > 1)
                {
                    //calculate opponent's HP
                    Form1.teacher[1].hP = HitCalc(Form1.teacher[1].hP, Form1.teacher[1].def, Form1.teacher[0].atk, 100);

                    // send message
                    battleStatusOutput.Text = "A ball almost hit him in the head!";
                    Thread.Sleep(sleepTime);
                    Refresh();

                    //lower Cutch's attack and defence by one stage (25)
                    Form1.teacher[0].atk = StatLower(Form1.teacher[0].atk, 25, "Attack");
                    Form1.teacher[0].def = StatLower(Form1.teacher[0].def, 25, "Defence");
                }
                else
                {
                    //calculate opponent's HP
                    Form1.teacher[0].hP = HitCalc(Form1.teacher[0].hP, Form1.teacher[0].def, Form1.teacher[1].atk, 100);

                    // send message
                    battleStatusOutput.Text = "A ball almost hit him in the head!";
                    Thread.Sleep(sleepTime);
                    Refresh();

                    //lower Cutch's attack and defence by one stage (25)
                    Form1.teacher[1].atk = StatLower(Form1.teacher[1].atk, 25, "Attack");
                    Form1.teacher[1].def = StatLower(Form1.teacher[1].def, 25, "Defence");
                }
            }
            else
            {
                // send move failed message
                battleStatusOutput.Text = "But you sat out!";
                Thread.Sleep(sleepTime);
                Refresh();
            }
        }

        public void EqualSign()
        {
            battleStatusOutput.Text = "Steel added a '='!";
            Thread.Sleep(sleepTime);
            Refresh();
            battleStatusOutput.Text = "Steel Balanced his HP with the opponent!";
            Thread.Sleep(sleepTime);
            Refresh();

            if (Form1.teacher[0].name == "Steel")
            {
                //add both player's HP together then half it
                Form1.teacher[0].hP = (Form1.teacher[0].hP + Form1.teacher[1].hP) / 2;
                //make sure both player's HP are equal
                Form1.teacher[1].hP = Form1.teacher[0].hP;
            }
            else if (Form1.teacher[1].name == "Steel")
            {
                //add both player's HP together then half it
                Form1.teacher[1].hP = (Form1.teacher[1].hP + Form1.teacher[0].hP) / 2;
                //make both player's HP equal
                Form1.teacher[0].hP = Form1.teacher[1].hP;
            }
        }

        public void HealthClass()
        {
            //variable
            int damage = 0;

            battleStatusOutput.Text = "McCutcheon is teaching a Health Class!";
            Thread.Sleep(sleepTime);
            Refresh();

            //assign to current player
            if (Form1.teacher[0].name == "McCutcheon")
            {
                //damage calc
                damage = (((42 * Form1.teacher[0].atk * 90 / Form1.teacher[1].def) / 50) + 2)
                    * randNum.Next(1, 101) / 100;
                //calculate HP of both players
                Form1.teacher[1].hP -= damage;
                Form1.teacher[0].hP -= damage / 4;
            }
            else if (Form1.teacher[1].name == "McCutcheon")
            {
                //damage calc
                damage = (((42 * Form1.teacher[1].atk * 90 / Form1.teacher[0].def) / 50) + 2)
                    * randNum.Next(1, 101) / 100;
                //calculate HP of both charaters
                Form1.teacher[0].hP -= damage;
                Form1.teacher[1].hP -= damage / 4;
            }


            battleStatusOutput.Text = "McCutcheon is hurt from recoil!";
            Thread.Sleep(sleepTime);
            Refresh();
        }

        public void HistoricWar()
        {
            //variable
            int damage = 0;

            battleStatusOutput.Text = "Leitch is teaching about a Historic War!";
            Thread.Sleep(sleepTime);
            Refresh();
            if (leitchSleep == 0)
            {
                //assign to current player
                if (Form1.teacher[0].name == "Leitch")
                {
                    //damage calc
                    damage = (((42 * Form1.teacher[0].atk * 90 / Form1.teacher[1].def) / 50) + 2)
                        * randNum.Next(1, 101) / 100;
                    //HP calc for both players
                    Form1.teacher[1].hP -= damage;
                    Form1.teacher[0].hP -= damage / 4;
                }
                else if (Form1.teacher[1].name == "Leitch")
                {
                    //damage calc
                    damage = (((42 * Form1.teacher[1].atk * 90 / Form1.teacher[0].def) / 50) + 2)
                        * randNum.Next(1, 101) / 100;
                    //HP calc for both players
                    Form1.teacher[0].hP -= damage;
                    Form1.teacher[1].hP -= damage / 4;
                }

                battleStatusOutput.Text = "Leitch is hurt from recoil!";
                Thread.Sleep(sleepTime);
                Refresh();
            }
        }

        public void PinkPaper()
        {
            //variable
            int damage = 0;

            battleStatusOutput.Text = "Steel handed out a Pink Paper";
            Thread.Sleep(sleepTime);
            Refresh();

            //assign to current player
            if (Form1.teacher[0].name == "Steel")
            {
                //damage calc
                damage = (((42 * Form1.teacher[0].atk * 65 / Form1.teacher[1].def) / 50) + 2)
                    * randNum.Next(1, 101) / 100;
                //HP calculation both players
                Form1.teacher[1].hP -= damage;
                Form1.teacher[0].hP += damage / 2;
            }
            else if (Form1.teacher[1].name == "Steel")
            {
                //damage calc
                damage = (((42 * Form1.teacher[1].atk * 65 / Form1.teacher[0].def) / 50) + 2)
                    * randNum.Next(1, 101) / 100;
                //HP calculation both players
                Form1.teacher[0].hP -= damage;
                Form1.teacher[1].hP += damage / 2;
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
            player = "p1";
            //order of moves is always Bond, Bradshaw, Leitch, Cutch, Ortelli, Steel
            #region move 1
            switch (Form1.teacher[0].move1)
            {
                case "CriteriaChart":
                    //call up criteria chart move
                    CriteriaChart(player);
                    break;

                case "AttackBot":
                    //call up attack bot move
                    AttackBot(player);
                    break;

                case "Documentary":
                    //Documentary (HP fully restored and miss 2 turns)
                    Documentary(player);
                    leitchSleep = 2;
                    break;

                case "Dodgeball":
                    //call up dodgeball move method
                    Dodgeball(player);
                    break;

                case "ClarinetSpeak":
                    //call up clarinet squeak move method
                    ClarinetSqueak(player);
                    break;

                case "EqualSign":
                    EqualSign();
                    break;

                default:
                    break;
            }
            #endregion

            #region move 2
            switch (Form1.teacher[0].move2)
            {
                case "Dissection":
                    //calculate opponent's HP (move power of 30)
                    Form1.teacher[1].hP = HitCalc(Form1.teacher[1].hP, Form1.teacher[1].def, Form1.teacher[0].atk, 30);
                    //lower defence of opponent by 2 stages (50)
                    Form1.teacher[1].def = StatLower(Form1.teacher[1].def, 50, "Defence");
                    break;

                case "ComplainAboutApple":
                    //calculate opponent's HP (power of 75)
                    Form1.teacher[1].hP = HitCalc(Form1.teacher[1].hP, Form1.teacher[1].def, Form1.teacher[0].atk, 75);
                    break;

                case "EssayQuestion":
                    //lower speed of opponent by 2 stages (50)
                    Form1.teacher[1].spd = StatLower(Form1.teacher[1].spd, 50, "Speed");
                    break;

                case "Dunk-On":
                    //calculate opponent's HP (power of 90)
                    Form1.teacher[1].hP = HitCalc(Form1.teacher[1].hP, Form1.teacher[1].def, Form1.teacher[0].atk, 90);
                    break;

                case "FullBandFortissimo":
                    //calculate opponent's HP (power of 120)
                    Form1.teacher[1].hP = HitCalc(Form1.teacher[1].hP, Form1.teacher[1].def, Form1.teacher[0].atk, 120);
                    //need sleep timer
                    break;

                case "PinkPaper":
                    PinkPaper();
                    break;

                default:
                    break;
            }
            #endregion

            #region move 3
            switch (Form1.teacher[0].move3)
            {
                case "MadExperiment":
                    Form1.teacher[1].hP = HitCalc(Form1.teacher[1].hP, Form1.teacher[1].def, Form1.teacher[0].atk, 100);
                    break;
                case "DefenderBot":
                    //Raise defence by one stage (25)
                    Form1.teacher[0].def = StatRaise(Form1.teacher[0].def, defLimit, "Defence");
                    break;
                case "HistoricWar":
                    HistoricWar();
                    break;
                case "PushUps":
                    //Raise attack by one stage (25)
                    Form1.teacher[0].atk = StatRaise(Form1.teacher[0].atk, atkLimit, "Attack");
                    break;
                case "MelodiousPassage":
                    //calclate opponent's new HP (move power of 70)
                    Form1.teacher[1].hP = HitCalc(Form1.teacher[1].hP, Form1.teacher[1].def, Form1.teacher[0].atk, 70);
                    break;
                case "QuadraticAttack":
                    //calculate power
                    int power = (randNum.Next() * 10) + 40;
                    //calculate new HP of opponent
                    Form1.teacher[1].hP = HitCalc(Form1.teacher[1].hP, Form1.teacher[1].def, Form1.teacher[0].atk, power);
                    break;
                default:
                    break;

            }
            #endregion

            #region move 4

            switch (Form1.teacher[0].move4)
            {
                case "TalkAboutFamily":
                    //defence raise by one stage (25)
                    Form1.teacher[0].def = StatRaise(Form1.teacher[0].def, defLimit, "Defence");
                    //calculate Bond's new HP (restores 1/4)
                    break;
                case "VideoFriday":
                    //calculate Bradshaw's new HP (restores 1/2)
                    Form1.teacher[0].hP = HPRaise(Form1.teacher[0].hP, p1InitialHP, 2);
                    break;
                case "MultipleChoiceQuestion":
                    //calculate opponent's new HP (move power of 75)
                    Form1.teacher[1].hP = HitCalc(Form1.teacher[1].hP, Form1.teacher[1].def, Form1.teacher[0].atk, 75);
                    break;
                case "HealthClass":
                    HealthClass();
                    break;
                case "Tuning":
                    //add 1/4 of initial HP to recent HP
                    Form1.teacher[0].hP = HPRaise(Form1.teacher[0].hP, p1InitialHP, 4);
                    break;
                case "TextbookBarricade":
                    Form1.teacher[0].def = StatRaise(Form1.teacher[0].def, defLimit, "Defence");
                    break;
                default:
                    break;

            }
            #endregion
        }

        public void p2MoveSelect()
        {
            //order of moves is always Bond, Bradshaw, Leitch, Cutch, Ortelli, Steel
            #region move 1
            switch (Form1.teacher[0].move1)
            {
                case "CriteriaChart":
                    //raise speed and attack of Bond
                    Form1.teacher[0].atk = StatRaise(Form1.teacher[0].atk, atkLimit, "Attack");
                    Form1.teacher[0].spd = StatRaise(Form1.teacher[0].spd, spdLimit, "Speed");
                    break;

                case "AttackBot":
                    //calculate damage (power of 30)
                    Form1.teacher[1].hP = HitCalc(Form1.teacher[1].hP, Form1.teacher[1].def, Form1.teacher[0].atk, 30);

                    //lower attack of opponent by one stage (25)
                    Form1.teacher[1].atk = StatLower(Form1.teacher[1].atk, 25, "Attack");
                    break;

                case "Documentary":
                    //Documentary (HP fully restored and miss 2 turns)
                    Form1.teacher[0].hP = HPRaise(Form1.teacher[0].hP, p1InitialHP, 1);
                    leitchSleep = 2;
                    break;

                case "Dodgeball":
                    //calculate opponent's HP
                    Form1.teacher[1].hP = HitCalc(Form1.teacher[1].hP, Form1.teacher[1].def, Form1.teacher[0].atk, 100);

                    //lower Cutch's attack and defence by one stage (25)
                    Form1.teacher[0].atk = StatLower(Form1.teacher[0].atk, 25, "Attack");
                    Form1.teacher[0].def = StatLower(Form1.teacher[0].def, 25, "Defence");
                    break;

                case "ClarinetSpeak":
                    //lower opponent's defence stat by one stage (25)
                    Form1.teacher[1].def = StatLower(Form1.teacher[1].def, 25, "Defence");
                    break;

                case "EqualSign":
                    EqualSign();
                    break;

                default:
                    break;
            }
            #endregion

            #region move 2
            switch (Form1.teacher[0].move2)
            {
                case "Dissection":
                    //calculate opponent's HP (move power of 30)
                    Form1.teacher[1].hP = HitCalc(Form1.teacher[1].hP, Form1.teacher[1].def, Form1.teacher[0].atk, 30);
                    //lower defence of opponent by 2 stages (50)
                    Form1.teacher[1].def = StatLower(Form1.teacher[1].def, 50, "Defence");
                    break;

                case "ComplainAboutApple":
                    //calculate opponent's HP (power of 75)
                    Form1.teacher[1].hP = HitCalc(Form1.teacher[1].hP, Form1.teacher[1].def, Form1.teacher[0].atk, 75);
                    break;

                case "EssayQuestion":
                    //lower speed of opponent by 2 stages (50)
                    Form1.teacher[1].spd = StatLower(Form1.teacher[1].spd, 50, "Speed");
                    break;

                case "Dunk-On":
                    //calculate opponent's HP (power of 90)
                    Form1.teacher[1].hP = HitCalc(Form1.teacher[1].hP, Form1.teacher[1].def, Form1.teacher[0].atk, 90);
                    break;

                case "FullBandFortissimo":
                    //calculate opponent's HP (power of 120)
                    Form1.teacher[1].hP = HitCalc(Form1.teacher[1].hP, Form1.teacher[1].def, Form1.teacher[0].atk, 120);
                    //need sleep timer
                    break;

                case "PinkPaper":
                    PinkPaper();
                    break;

                default:
                    break;
            }
            #endregion

            #region move 3
            switch (Form1.teacher[0].move3)
            {
                case "MadExperiment":
                    Form1.teacher[1].hP = HitCalc(Form1.teacher[1].hP, Form1.teacher[1].def, Form1.teacher[0].atk, 100);
                    break;
                case "DefenderBot":
                    //Raise defence by one stage (25)
                    Form1.teacher[0].def = StatRaise(Form1.teacher[0].def, defLimit, "Defence");
                    break;
                case "HistoricWar":
                    HistoricWar();
                    break;
                case "PushUps":
                    //Raise attack by one stage (25)
                    Form1.teacher[0].atk = StatRaise(Form1.teacher[0].atk, atkLimit, "Attack");
                    break;
                case "MelodiousPassage":
                    //calclate opponent's new HP (move power of 70)
                    Form1.teacher[1].hP = HitCalc(Form1.teacher[1].hP, Form1.teacher[1].def, Form1.teacher[0].atk, 70);
                    break;
                case "QuadraticAttack":
                    //calculate power
                    int power = (randNum.Next() * 10) + 40;
                    //calculate new HP of opponent
                    Form1.teacher[1].hP = HitCalc(Form1.teacher[1].hP, Form1.teacher[1].def, Form1.teacher[0].atk, power);
                    break;
                default:
                    break;

            }
            #endregion

            #region move 4

            switch (Form1.teacher[0].move4)
            {
                case "TalkAboutFamily":
                    //defence raise by one stage (25)
                    Form1.teacher[0].def = StatRaise(Form1.teacher[0].def, defLimit, "Defence");
                    //calculate Bond's new HP (restores 1/4)
                    break;
                case "VideoFriday":
                    //calculate Bradshaw's new HP (restores 1/2)
                    Form1.teacher[0].hP = HPRaise(Form1.teacher[0].hP, p1InitialHP, 2);
                    break;
                case "MultipleChoiceQuestion":
                    //calculate opponent's new HP (move power of 75)
                    Form1.teacher[1].hP = HitCalc(Form1.teacher[1].hP, Form1.teacher[1].def, Form1.teacher[0].atk, 75);
                    break;
                case "HealthClass":
                    HealthClass();
                    break;
                case "Tuning":
                    //add 1/4 of initial HP to recent HP
                    Form1.teacher[0].hP = HPRaise(Form1.teacher[0].hP, p1InitialHP, 4);
                    break;
                case "TextbookBarricade":
                    Form1.teacher[0].def = StatRaise(Form1.teacher[0].def, defLimit, "Defence");
                    break;
                default:
                    break;

            }
            #endregion
        }

        public int HitCalc(int oppHP, int oppDef, int plrAtk, int movePower)
        {
            //attack sound
            attackPlayer.Play();
            //damage calculation
            oppHP = oppHP - (((42 * plrAtk * movePower / oppDef) / 50) + 2) * randNum.Next(1, 101) / 100;
            //play damage sound before changing hp
            damagePlayer.Play();

            return oppHP;
        }

        public int StatLower(int stat, int lower, string statType)
        {
            //lower stat
            stat -= lower;
            //display message
            battleStatusOutput.Text = "The opponent's " + statType + " was lowered!";
            Thread.Sleep(sleepTime);
            Refresh();
            //make sure stat doesn't go below 0
            if (stat <= 0)
            {
                stat = 1;
                //display message
                battleStatusOutput.Text = "The opponent's" + statType + " can't go any lower!";
                Thread.Sleep(sleepTime);
                Refresh();
            }
            return stat;
        }

        public int StatRaise(int stat, int statLimit, string statName)
        {
            // increase stat
            stat += 25;
            battleStatusOutput.Text = statName + " has been raised!";
            Thread.Sleep(sleepTime);
            Refresh();
            //make sure stat doesn't go above limit
            if (stat > statLimit)
            {
                stat = statLimit;
                battleStatusOutput.Text = statName + " can't go any higher!";
                Thread.Sleep(sleepTime);
                Refresh();
            }
            return stat;
        }

        public int HPRaise(int hP, int initialHP, int restore)
        {
            //add amount of new HP to old HP
            hP += initialHP / restore;
            //make sure it doesn't go above max
            if (hP < initialHP)
            {
                hP = initialHP;
            }
            return hP;
        }
    }
}

