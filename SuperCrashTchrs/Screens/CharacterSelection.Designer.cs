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
            this.playerSelectStatus = new System.Windows.Forms.Label();
            this.bondSelect = new System.Windows.Forms.RadioButton();
            this.bradSelect = new System.Windows.Forms.RadioButton();
            this.leitchSelect = new System.Windows.Forms.RadioButton();
            this.cutchSelect = new System.Windows.Forms.RadioButton();
            this.ortelliSelect = new System.Windows.Forms.RadioButton();
            this.steelSelect = new System.Windows.Forms.RadioButton();
            this.teachSelect = new System.Windows.Forms.GroupBox();
            this.teachSelect.SuspendLayout();
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
            // bondSelect
            // 
            this.bondSelect.AutoSize = true;
            this.bondSelect.Checked = true;
            this.bondSelect.Location = new System.Drawing.Point(30, 18);
            this.bondSelect.Name = "bondSelect";
            this.bondSelect.Size = new System.Drawing.Size(49, 17);
            this.bondSelect.TabIndex = 13;
            this.bondSelect.TabStop = true;
            this.bondSelect.Text = "bond";
            this.bondSelect.UseVisualStyleBackColor = true;
            // 
            // bradSelect
            // 
            this.bradSelect.AutoSize = true;
            this.bradSelect.Location = new System.Drawing.Point(349, 18);
            this.bradSelect.Name = "bradSelect";
            this.bradSelect.Size = new System.Drawing.Size(46, 17);
            this.bradSelect.TabIndex = 14;
            this.bradSelect.Text = "brad";
            this.bradSelect.UseVisualStyleBackColor = true;
            // 
            // leitchSelect
            // 
            this.leitchSelect.AutoSize = true;
            this.leitchSelect.Location = new System.Drawing.Point(637, 18);
            this.leitchSelect.Name = "leitchSelect";
            this.leitchSelect.Size = new System.Drawing.Size(50, 17);
            this.leitchSelect.TabIndex = 15;
            this.leitchSelect.Text = "leitch";
            this.leitchSelect.UseVisualStyleBackColor = true;
            // 
            // cutchSelect
            // 
            this.cutchSelect.AutoSize = true;
            this.cutchSelect.Location = new System.Drawing.Point(30, 353);
            this.cutchSelect.Name = "cutchSelect";
            this.cutchSelect.Size = new System.Drawing.Size(52, 17);
            this.cutchSelect.TabIndex = 16;
            this.cutchSelect.Text = "cutch";
            this.cutchSelect.UseVisualStyleBackColor = true;
            // 
            // ortelliSelect
            // 
            this.ortelliSelect.AutoSize = true;
            this.ortelliSelect.Location = new System.Drawing.Point(349, 353);
            this.ortelliSelect.Name = "ortelliSelect";
            this.ortelliSelect.Size = new System.Drawing.Size(49, 17);
            this.ortelliSelect.TabIndex = 17;
            this.ortelliSelect.Text = "ortelli";
            this.ortelliSelect.UseVisualStyleBackColor = true;
            // 
            // steelSelect
            // 
            this.steelSelect.AutoSize = true;
            this.steelSelect.Location = new System.Drawing.Point(637, 353);
            this.steelSelect.Name = "steelSelect";
            this.steelSelect.Size = new System.Drawing.Size(47, 17);
            this.steelSelect.TabIndex = 18;
            this.steelSelect.Text = "steel";
            this.steelSelect.UseVisualStyleBackColor = true;
            // 
            // teachSelect
            // 
            this.teachSelect.Controls.Add(this.steelSelect);
            this.teachSelect.Controls.Add(this.ortelliSelect);
            this.teachSelect.Controls.Add(this.cutchSelect);
            this.teachSelect.Controls.Add(this.leitchSelect);
            this.teachSelect.Controls.Add(this.bradSelect);
            this.teachSelect.Controls.Add(this.bondSelect);
            this.teachSelect.Location = new System.Drawing.Point(21, 87);
            this.teachSelect.Name = "teachSelect";
            this.teachSelect.Size = new System.Drawing.Size(742, 385);
            this.teachSelect.TabIndex = 19;
            this.teachSelect.TabStop = false;
            // 
            // CharacterSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.teachSelect);
            this.Controls.Add(this.playerSelectStatus);
            this.Name = "CharacterSelection";
            this.Size = new System.Drawing.Size(800, 800);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CharacterSelection_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CharacterSelection_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CharacterSelection_PreviewKeyDown);
            this.teachSelect.ResumeLayout(false);
            this.teachSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label playerSelectStatus;
        private System.Windows.Forms.RadioButton bondSelect;
        private System.Windows.Forms.RadioButton bradSelect;
        private System.Windows.Forms.RadioButton leitchSelect;
        private System.Windows.Forms.RadioButton cutchSelect;
        private System.Windows.Forms.RadioButton ortelliSelect;
        private System.Windows.Forms.RadioButton steelSelect;
        private System.Windows.Forms.GroupBox teachSelect;
    }
}
