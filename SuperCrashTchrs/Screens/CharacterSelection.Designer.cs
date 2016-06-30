namespace SuperCrashTchrs.Screens
{
    partial class CharacterSelection
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
            this.playerSelectStatus = new System.Windows.Forms.Label();
            this.selectTime = new System.Windows.Forms.Timer(this.components);
            this.nextBttn = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.enterBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerSelectStatus
            // 
            this.playerSelectStatus.AutoSize = true;
            this.playerSelectStatus.Location = new System.Drawing.Point(282, 614);
            this.playerSelectStatus.Name = "playerSelectStatus";
            this.playerSelectStatus.Size = new System.Drawing.Size(222, 13);
            this.playerSelectStatus.TabIndex = 12;
            this.playerSelectStatus.Text = "PLAYER ONE SELECT YOUR CHARACTER";
            // 
            // selectTime
            // 
            this.selectTime.Interval = 25;
            this.selectTime.Tick += new System.EventHandler(this.selectTime_Tick);
            // 
            // nextBttn
            // 
            this.nextBttn.Location = new System.Drawing.Point(663, 692);
            this.nextBttn.Name = "nextBttn";
            this.nextBttn.Size = new System.Drawing.Size(75, 23);
            this.nextBttn.TabIndex = 13;
            this.nextBttn.Text = "Next";
            this.nextBttn.UseVisualStyleBackColor = true;
            this.nextBttn.Click += new System.EventHandler(this.nextBttn_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(56, 692);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(75, 23);
            this.prevButton.TabIndex = 14;
            this.prevButton.Text = "Previous";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // enterBttn
            // 
            this.enterBttn.Location = new System.Drawing.Point(364, 692);
            this.enterBttn.Name = "enterBttn";
            this.enterBttn.Size = new System.Drawing.Size(75, 23);
            this.enterBttn.TabIndex = 15;
            this.enterBttn.Text = "Select";
            this.enterBttn.UseVisualStyleBackColor = true;
            this.enterBttn.Click += new System.EventHandler(this.enterBttn_Click);
            // 
            // CharacterSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.Controls.Add(this.enterBttn);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.nextBttn);
            this.Controls.Add(this.playerSelectStatus);
            this.DoubleBuffered = true;
            this.Name = "CharacterSelection";
            this.Size = new System.Drawing.Size(800, 800);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CharacterSelection_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label playerSelectStatus;
        private System.Windows.Forms.Timer selectTime;
        private System.Windows.Forms.Button nextBttn;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button enterBttn;
    }
}
