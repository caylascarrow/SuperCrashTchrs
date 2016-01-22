namespace SuperCrashTchrs.Screens
{
    partial class BattleArena
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.p1Blue = new System.Windows.Forms.Button();
            this.p1Yellow = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.p1HPBar = new System.Windows.Forms.Label();
            this.p2HPBar = new System.Windows.Forms.Label();
            this.HPlabel1 = new System.Windows.Forms.Label();
            this.HPlabel2 = new System.Windows.Forms.Label();
            this.battleStatusOutput = new System.Windows.Forms.Label();
            this.p1Sprite = new System.Windows.Forms.PictureBox();
            this.p2Sprite = new System.Windows.Forms.PictureBox();
            this.moveSelectTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.p1Sprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Sprite)).BeginInit();
            this.SuspendLayout();
            // 
            // p1Blue
            // 
            this.p1Blue.BackColor = System.Drawing.Color.Blue;
            this.p1Blue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p1Blue.ForeColor = System.Drawing.Color.White;
            this.p1Blue.Location = new System.Drawing.Point(25, 695);
            this.p1Blue.Name = "p1Blue";
            this.p1Blue.Size = new System.Drawing.Size(75, 23);
            this.p1Blue.TabIndex = 0;
            this.p1Blue.Text = "move2";
            this.p1Blue.UseVisualStyleBackColor = false;
            // 
            // p1Yellow
            // 
            this.p1Yellow.BackColor = System.Drawing.Color.Yellow;
            this.p1Yellow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p1Yellow.Location = new System.Drawing.Point(137, 666);
            this.p1Yellow.Name = "p1Yellow";
            this.p1Yellow.Size = new System.Drawing.Size(75, 23);
            this.p1Yellow.TabIndex = 1;
            this.p1Yellow.Text = "move1";
            this.p1Yellow.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(200, 721);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "move3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(89, 752);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "move4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(568, 763);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "move4";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(639, 704);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "move3";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Yellow;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(540, 676);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "move1";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Blue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(464, 738);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "move2";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // p1HPBar
            // 
            this.p1HPBar.BackColor = System.Drawing.Color.Lime;
            this.p1HPBar.Location = new System.Drawing.Point(86, 588);
            this.p1HPBar.Name = "p1HPBar";
            this.p1HPBar.Size = new System.Drawing.Size(200, 10);
            this.p1HPBar.TabIndex = 8;
            // 
            // p2HPBar
            // 
            this.p2HPBar.BackColor = System.Drawing.Color.Lime;
            this.p2HPBar.Location = new System.Drawing.Point(476, 588);
            this.p2HPBar.Name = "p2HPBar";
            this.p2HPBar.Size = new System.Drawing.Size(200, 10);
            this.p2HPBar.TabIndex = 9;
            // 
            // HPlabel1
            // 
            this.HPlabel1.AutoSize = true;
            this.HPlabel1.Location = new System.Drawing.Point(55, 588);
            this.HPlabel1.Name = "HPlabel1";
            this.HPlabel1.Size = new System.Drawing.Size(25, 13);
            this.HPlabel1.TabIndex = 10;
            this.HPlabel1.Text = "HP:";
            // 
            // HPlabel2
            // 
            this.HPlabel2.AutoSize = true;
            this.HPlabel2.Location = new System.Drawing.Point(433, 588);
            this.HPlabel2.Name = "HPlabel2";
            this.HPlabel2.Size = new System.Drawing.Size(25, 13);
            this.HPlabel2.TabIndex = 11;
            this.HPlabel2.Text = "HP:";
            // 
            // battleStatusOutput
            // 
            this.battleStatusOutput.AutoSize = true;
            this.battleStatusOutput.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleStatusOutput.Location = new System.Drawing.Point(194, 37);
            this.battleStatusOutput.Name = "battleStatusOutput";
            this.battleStatusOutput.Size = new System.Drawing.Size(356, 32);
            this.battleStatusOutput.TabIndex = 12;
            this.battleStatusOutput.Text = "Pikachu used Thunder!";
            // 
            // p1Sprite
            // 
            this.p1Sprite.BackColor = System.Drawing.Color.Black;
            this.p1Sprite.Location = new System.Drawing.Point(89, 171);
            this.p1Sprite.Name = "p1Sprite";
            this.p1Sprite.Size = new System.Drawing.Size(236, 356);
            this.p1Sprite.TabIndex = 13;
            this.p1Sprite.TabStop = false;
            // 
            // p2Sprite
            // 
            this.p2Sprite.BackColor = System.Drawing.Color.Black;
            this.p2Sprite.Location = new System.Drawing.Point(478, 171);
            this.p2Sprite.Name = "p2Sprite";
            this.p2Sprite.Size = new System.Drawing.Size(236, 356);
            this.p2Sprite.TabIndex = 14;
            this.p2Sprite.TabStop = false;
            // 
            // moveSelectTimer
            // 
            this.moveSelectTimer.Interval = 17;
            this.moveSelectTimer.Tick += new System.EventHandler(this.moveSelectTimer_Tick);
            // 
            // BattleArena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.p2Sprite);
            this.Controls.Add(this.p1Sprite);
            this.Controls.Add(this.battleStatusOutput);
            this.Controls.Add(this.HPlabel2);
            this.Controls.Add(this.HPlabel1);
            this.Controls.Add(this.p2HPBar);
            this.Controls.Add(this.p1HPBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.p1Yellow);
            this.Controls.Add(this.p1Blue);
            this.Name = "BattleArena";
            this.Size = new System.Drawing.Size(800, 800);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BattleArena_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.p1Sprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Sprite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button p1Blue;
        private System.Windows.Forms.Button p1Yellow;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label p1HPBar;
        private System.Windows.Forms.Label p2HPBar;
        private System.Windows.Forms.Label HPlabel1;
        private System.Windows.Forms.Label HPlabel2;
        private System.Windows.Forms.Label battleStatusOutput;
        private System.Windows.Forms.PictureBox p1Sprite;
        private System.Windows.Forms.PictureBox p2Sprite;
        private System.Windows.Forms.Timer moveSelectTimer;
    }
}
