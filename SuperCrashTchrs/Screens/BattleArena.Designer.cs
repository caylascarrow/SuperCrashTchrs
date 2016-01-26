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
            this.p1Red = new System.Windows.Forms.Button();
            this.p1Green = new System.Windows.Forms.Button();
            this.p2Green = new System.Windows.Forms.Button();
            this.p2Red = new System.Windows.Forms.Button();
            this.p2Yellow = new System.Windows.Forms.Button();
            this.p2Blue = new System.Windows.Forms.Button();
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
            this.p1Blue.AutoSize = true;
            this.p1Blue.BackColor = System.Drawing.Color.Blue;
            this.p1Blue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p1Blue.ForeColor = System.Drawing.Color.White;
            this.p1Blue.Location = new System.Drawing.Point(104, 652);
            this.p1Blue.Name = "p1Blue";
            this.p1Blue.Size = new System.Drawing.Size(75, 23);
            this.p1Blue.TabIndex = 0;
            this.p1Blue.Text = "move2";
            this.p1Blue.UseVisualStyleBackColor = false;
            this.p1Blue.Click += new System.EventHandler(this.p1Blue_Click);
            // 
            // p1Yellow
            // 
            this.p1Yellow.AutoSize = true;
            this.p1Yellow.BackColor = System.Drawing.Color.Yellow;
            this.p1Yellow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p1Yellow.Location = new System.Drawing.Point(190, 623);
            this.p1Yellow.Name = "p1Yellow";
            this.p1Yellow.Size = new System.Drawing.Size(75, 23);
            this.p1Yellow.TabIndex = 1;
            this.p1Yellow.Text = "move1";
            this.p1Yellow.UseVisualStyleBackColor = false;
            this.p1Yellow.Click += new System.EventHandler(this.p1Yellow_Click);
            // 
            // p1Red
            // 
            this.p1Red.AutoSize = true;
            this.p1Red.BackColor = System.Drawing.Color.Red;
            this.p1Red.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p1Red.Location = new System.Drawing.Point(277, 652);
            this.p1Red.Name = "p1Red";
            this.p1Red.Size = new System.Drawing.Size(75, 23);
            this.p1Red.TabIndex = 2;
            this.p1Red.Text = "move3";
            this.p1Red.UseVisualStyleBackColor = false;
            this.p1Red.Click += new System.EventHandler(this.p1Red_Click);
            // 
            // p1Green
            // 
            this.p1Green.AutoSize = true;
            this.p1Green.BackColor = System.Drawing.Color.Lime;
            this.p1Green.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p1Green.Location = new System.Drawing.Point(190, 689);
            this.p1Green.Name = "p1Green";
            this.p1Green.Size = new System.Drawing.Size(75, 23);
            this.p1Green.TabIndex = 3;
            this.p1Green.Text = "move4";
            this.p1Green.UseVisualStyleBackColor = false;
            this.p1Green.Click += new System.EventHandler(this.p1Green_Click);
            // 
            // p2Green
            // 
            this.p2Green.AutoSize = true;
            this.p2Green.BackColor = System.Drawing.Color.Lime;
            this.p2Green.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p2Green.Location = new System.Drawing.Point(558, 689);
            this.p2Green.Name = "p2Green";
            this.p2Green.Size = new System.Drawing.Size(75, 23);
            this.p2Green.TabIndex = 7;
            this.p2Green.Text = "move4";
            this.p2Green.UseVisualStyleBackColor = false;
            this.p2Green.Click += new System.EventHandler(this.p2Green_Click);
            // 
            // p2Red
            // 
            this.p2Red.AutoSize = true;
            this.p2Red.BackColor = System.Drawing.Color.Red;
            this.p2Red.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p2Red.Location = new System.Drawing.Point(648, 652);
            this.p2Red.Name = "p2Red";
            this.p2Red.Size = new System.Drawing.Size(75, 23);
            this.p2Red.TabIndex = 6;
            this.p2Red.Text = "move3";
            this.p2Red.UseVisualStyleBackColor = false;
            this.p2Red.Click += new System.EventHandler(this.p2Red_Click);
            // 
            // p2Yellow
            // 
            this.p2Yellow.AutoSize = true;
            this.p2Yellow.BackColor = System.Drawing.Color.Yellow;
            this.p2Yellow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p2Yellow.Location = new System.Drawing.Point(558, 623);
            this.p2Yellow.Name = "p2Yellow";
            this.p2Yellow.Size = new System.Drawing.Size(75, 23);
            this.p2Yellow.TabIndex = 5;
            this.p2Yellow.Text = "move1";
            this.p2Yellow.UseVisualStyleBackColor = false;
            this.p2Yellow.Click += new System.EventHandler(this.p2Yellow_Click);
            // 
            // p2Blue
            // 
            this.p2Blue.AutoSize = true;
            this.p2Blue.BackColor = System.Drawing.Color.Blue;
            this.p2Blue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p2Blue.ForeColor = System.Drawing.Color.White;
            this.p2Blue.Location = new System.Drawing.Point(469, 652);
            this.p2Blue.Name = "p2Blue";
            this.p2Blue.Size = new System.Drawing.Size(75, 23);
            this.p2Blue.TabIndex = 4;
            this.p2Blue.Text = "move2";
            this.p2Blue.UseVisualStyleBackColor = false;
            this.p2Blue.Click += new System.EventHandler(this.p2Blue_Click);
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
            this.battleStatusOutput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.battleStatusOutput.AutoEllipsis = true;
            this.battleStatusOutput.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleStatusOutput.Location = new System.Drawing.Point(3, 66);
            this.battleStatusOutput.Name = "battleStatusOutput";
            this.battleStatusOutput.Size = new System.Drawing.Size(794, 32);
            this.battleStatusOutput.TabIndex = 12;
            this.battleStatusOutput.Text = "A Battle has Started!";
            this.battleStatusOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1Sprite
            // 
            this.p1Sprite.BackColor = System.Drawing.Color.Transparent;
            this.p1Sprite.Location = new System.Drawing.Point(89, 171);
            this.p1Sprite.Name = "p1Sprite";
            this.p1Sprite.Size = new System.Drawing.Size(236, 356);
            this.p1Sprite.TabIndex = 13;
            this.p1Sprite.TabStop = false;
            // 
            // p2Sprite
            // 
            this.p2Sprite.BackColor = System.Drawing.Color.Transparent;
            this.p2Sprite.Location = new System.Drawing.Point(478, 171);
            this.p2Sprite.Name = "p2Sprite";
            this.p2Sprite.Size = new System.Drawing.Size(236, 356);
            this.p2Sprite.TabIndex = 14;
            this.p2Sprite.TabStop = false;
            // 
            // moveSelectTimer
            // 
            this.moveSelectTimer.Interval = 1000;
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
            this.Controls.Add(this.p2Green);
            this.Controls.Add(this.p2Red);
            this.Controls.Add(this.p2Yellow);
            this.Controls.Add(this.p2Blue);
            this.Controls.Add(this.p1Green);
            this.Controls.Add(this.p1Red);
            this.Controls.Add(this.p1Yellow);
            this.Controls.Add(this.p1Blue);
            this.Name = "BattleArena";
            this.Size = new System.Drawing.Size(800, 800);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.BattleArena_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.p1Sprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Sprite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button p1Blue;
        private System.Windows.Forms.Button p1Yellow;
        private System.Windows.Forms.Button p1Red;
        private System.Windows.Forms.Button p1Green;
        private System.Windows.Forms.Button p2Green;
        private System.Windows.Forms.Button p2Red;
        private System.Windows.Forms.Button p2Yellow;
        private System.Windows.Forms.Button p2Blue;
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
