namespace Quiz.View
{
    partial class ConfigForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.textBoxHighScore = new System.Windows.Forms.TextBox();
            this.textBoxRounds = new System.Windows.Forms.TextBox();
            this.textBoxNickName = new System.Windows.Forms.TextBox();
            this.labelHighScore = new System.Windows.Forms.Label();
            this.labelRounds = new System.Windows.Forms.Label();
            this.labelNickName = new System.Windows.Forms.Label();
            this.groupBoxModus = new System.Windows.Forms.GroupBox();
            this.comboBoxHint = new System.Windows.Forms.ComboBox();
            this.comboBoxGuess = new System.Windows.Forms.ComboBox();
            this.labelHint = new System.Windows.Forms.Label();
            this.labelGuess = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.groupBoxUser.SuspendLayout();
            this.groupBoxModus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.textBoxHighScore);
            this.groupBoxUser.Controls.Add(this.textBoxRounds);
            this.groupBoxUser.Controls.Add(this.textBoxNickName);
            this.groupBoxUser.Controls.Add(this.labelHighScore);
            this.groupBoxUser.Controls.Add(this.labelRounds);
            this.groupBoxUser.Controls.Add(this.labelNickName);
            this.groupBoxUser.Location = new System.Drawing.Point(17, 18);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(267, 101);
            this.groupBoxUser.TabIndex = 0;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "User";
            // 
            // textBoxHighScore
            // 
            this.textBoxHighScore.Location = new System.Drawing.Point(71, 72);
            this.textBoxHighScore.Name = "textBoxHighScore";
            this.textBoxHighScore.ReadOnly = true;
            this.textBoxHighScore.Size = new System.Drawing.Size(177, 20);
            this.textBoxHighScore.TabIndex = 5;
            // 
            // textBoxRounds
            // 
            this.textBoxRounds.Location = new System.Drawing.Point(72, 46);
            this.textBoxRounds.Name = "textBoxRounds";
            this.textBoxRounds.ReadOnly = true;
            this.textBoxRounds.Size = new System.Drawing.Size(177, 20);
            this.textBoxRounds.TabIndex = 4;
            // 
            // textBoxNickName
            // 
            this.textBoxNickName.Location = new System.Drawing.Point(72, 20);
            this.textBoxNickName.Name = "textBoxNickName";
            this.textBoxNickName.Size = new System.Drawing.Size(177, 20);
            this.textBoxNickName.TabIndex = 3;
            this.textBoxNickName.TextChanged += new System.EventHandler(this.textBoxNickName_TextChanged);
            // 
            // labelHighScore
            // 
            this.labelHighScore.AutoSize = true;
            this.labelHighScore.Location = new System.Drawing.Point(7, 72);
            this.labelHighScore.Name = "labelHighScore";
            this.labelHighScore.Size = new System.Drawing.Size(58, 13);
            this.labelHighScore.TabIndex = 2;
            this.labelHighScore.Text = "Highscore:";
            // 
            // labelRounds
            // 
            this.labelRounds.AutoSize = true;
            this.labelRounds.Location = new System.Drawing.Point(7, 46);
            this.labelRounds.Name = "labelRounds";
            this.labelRounds.Size = new System.Drawing.Size(47, 13);
            this.labelRounds.TabIndex = 1;
            this.labelRounds.Text = "Rounds:";
            // 
            // labelNickName
            // 
            this.labelNickName.AutoSize = true;
            this.labelNickName.Location = new System.Drawing.Point(6, 20);
            this.labelNickName.Name = "labelNickName";
            this.labelNickName.Size = new System.Drawing.Size(58, 13);
            this.labelNickName.TabIndex = 0;
            this.labelNickName.Text = "Nickname:";
            // 
            // groupBoxModus
            // 
            this.groupBoxModus.Controls.Add(this.comboBoxHint);
            this.groupBoxModus.Controls.Add(this.comboBoxGuess);
            this.groupBoxModus.Controls.Add(this.labelHint);
            this.groupBoxModus.Controls.Add(this.labelGuess);
            this.groupBoxModus.Location = new System.Drawing.Point(17, 138);
            this.groupBoxModus.Name = "groupBoxModus";
            this.groupBoxModus.Size = new System.Drawing.Size(267, 100);
            this.groupBoxModus.TabIndex = 1;
            this.groupBoxModus.TabStop = false;
            this.groupBoxModus.Text = "Modus";
            // 
            // comboBoxHint
            // 
            this.comboBoxHint.DisplayMember = "Key";
            this.comboBoxHint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHint.FormattingEnabled = true;
            this.comboBoxHint.Location = new System.Drawing.Point(71, 52);
            this.comboBoxHint.Name = "comboBoxHint";
            this.comboBoxHint.Size = new System.Drawing.Size(177, 21);
            this.comboBoxHint.TabIndex = 3;
            this.comboBoxHint.ValueMember = "Value";
            // 
            // comboBoxGuess
            // 
            this.comboBoxGuess.DisplayMember = "Key";
            this.comboBoxGuess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGuess.FormattingEnabled = true;
            this.comboBoxGuess.Location = new System.Drawing.Point(71, 22);
            this.comboBoxGuess.Name = "comboBoxGuess";
            this.comboBoxGuess.Size = new System.Drawing.Size(177, 21);
            this.comboBoxGuess.TabIndex = 2;
            this.comboBoxGuess.ValueMember = "Value";
            this.comboBoxGuess.SelectedIndexChanged += new System.EventHandler(this.comboBoxGuess_SelectedIndexChanged);
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.Location = new System.Drawing.Point(7, 52);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(29, 13);
            this.labelHint.TabIndex = 1;
            this.labelHint.Text = "Hint:";
            // 
            // labelGuess
            // 
            this.labelGuess.AutoSize = true;
            this.labelGuess.Location = new System.Drawing.Point(7, 25);
            this.labelGuess.Name = "labelGuess";
            this.labelGuess.Size = new System.Drawing.Size(40, 13);
            this.labelGuess.TabIndex = 0;
            this.labelGuess.Text = "Guess:";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(191, 258);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 293);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.groupBoxModus);
            this.Controls.Add(this.groupBoxUser);
            this.Name = "ConfigForm";
            this.Text = "Quiz: Configuration";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.groupBoxModus.ResumeLayout(false);
            this.groupBoxModus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Label labelHighScore;
        private System.Windows.Forms.Label labelRounds;
        private System.Windows.Forms.Label labelNickName;
        private System.Windows.Forms.TextBox textBoxHighScore;
        private System.Windows.Forms.TextBox textBoxRounds;
        private System.Windows.Forms.TextBox textBoxNickName;
        private System.Windows.Forms.GroupBox groupBoxModus;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.Label labelGuess;
        private System.Windows.Forms.ComboBox comboBoxHint;
        private System.Windows.Forms.ComboBox comboBoxGuess;
        private System.Windows.Forms.Button buttonPlay;
    }
}