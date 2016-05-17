namespace SuperCrashTchrs.Screens
{
    partial class MultiEndScreen
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
            this.goToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goToMain
            // 
            this.goToMain.Location = new System.Drawing.Point(13, 97);
            this.goToMain.Name = "goToMain";
            this.goToMain.Size = new System.Drawing.Size(123, 23);
            this.goToMain.TabIndex = 0;
            this.goToMain.Text = "Go To Main Screen";
            this.goToMain.UseVisualStyleBackColor = true;
            this.goToMain.Click += new System.EventHandler(this.button1_Click);
            // 
            // MultiEndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.goToMain);
            this.Name = "MultiEndScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goToMain;
    }
}
