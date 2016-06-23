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
            this.SuspendLayout();
            // 
            // playerSelectStatus
            // 
            this.playerSelectStatus.AutoSize = true;
            this.playerSelectStatus.Location = new System.Drawing.Point(298, 611);
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
            // CharacterSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.Controls.Add(this.playerSelectStatus);
            this.DoubleBuffered = true;
            this.Name = "CharacterSelection";
            this.Size = new System.Drawing.Size(800, 800);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CharacterSelection_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CharacterSelection_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CharacterSelection_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label playerSelectStatus;
        private System.Windows.Forms.Timer selectTime;
    }
}
