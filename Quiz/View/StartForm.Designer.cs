namespace Quiz.View
{
    partial class StartForm
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonGame = new System.Windows.Forms.Button();
            this.buttonHighScore = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonGame);
            this.groupBox.Controls.Add(this.buttonHighScore);
            this.groupBox.Location = new System.Drawing.Point(13, 13);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 90);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "What do you wanna do?";
            // 
            // buttonGame
            // 
            this.buttonGame.Location = new System.Drawing.Point(7, 49);
            this.buttonGame.Name = "buttonGame";
            this.buttonGame.Size = new System.Drawing.Size(75, 23);
            this.buttonGame.TabIndex = 1;
            this.buttonGame.Text = "Game";
            this.buttonGame.UseVisualStyleBackColor = true;
            this.buttonGame.Click += new System.EventHandler(this.buttonGame_Click);
            // 
            // buttonHighScore
            // 
            this.buttonHighScore.Location = new System.Drawing.Point(7, 20);
            this.buttonHighScore.Name = "buttonHighScore";
            this.buttonHighScore.Size = new System.Drawing.Size(75, 23);
            this.buttonHighScore.TabIndex = 0;
            this.buttonHighScore.Text = "Highscores";
            this.buttonHighScore.UseVisualStyleBackColor = true;
            this.buttonHighScore.Click += new System.EventHandler(this.buttonHighScore_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox);
            this.Name = "StartForm";
            this.Text = "Quiz: Start";
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonGame;
        private System.Windows.Forms.Button buttonHighScore;
    }
}