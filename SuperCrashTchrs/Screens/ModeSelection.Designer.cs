namespace SuperCrashTchrs.Screens
{
    partial class ModeSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModeSelection));
            this.playButton = new System.Windows.Forms.Button();
            this.howToPlay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(151, 427);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(109, 40);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "PLAY!";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // howToPlay
            // 
            this.howToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToPlay.ForeColor = System.Drawing.Color.Red;
            this.howToPlay.Location = new System.Drawing.Point(39, 37);
            this.howToPlay.Name = "howToPlay";
            this.howToPlay.Size = new System.Drawing.Size(371, 285);
            this.howToPlay.TabIndex = 1;
            this.howToPlay.Text = resources.GetString("howToPlay.Text");
            // 
            // ModeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.howToPlay);
            this.Controls.Add(this.playButton);
            this.Name = "ModeSelection";
            this.Size = new System.Drawing.Size(445, 470);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label howToPlay;
    }
}
