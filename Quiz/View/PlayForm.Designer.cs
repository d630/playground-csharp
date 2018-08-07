namespace Quiz.View
{
    partial class PlayForm
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
            this.groupBoxGuess = new System.Windows.Forms.GroupBox();
            this.pictureBoxCategory = new System.Windows.Forms.PictureBox();
            this.labelNonPicCategory = new System.Windows.Forms.Label();
            this.groupBoxHint = new System.Windows.Forms.GroupBox();
            this.radioButtonAnswer4 = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswer3 = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswer2 = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswer1 = new System.Windows.Forms.RadioButton();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.labelRoundNum = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.groupBoxGuess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategory)).BeginInit();
            this.groupBoxHint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxGuess
            // 
            this.groupBoxGuess.Controls.Add(this.pictureBoxCategory);
            this.groupBoxGuess.Controls.Add(this.labelNonPicCategory);
            this.groupBoxGuess.Location = new System.Drawing.Point(12, 35);
            this.groupBoxGuess.Name = "groupBoxGuess";
            this.groupBoxGuess.Size = new System.Drawing.Size(354, 100);
            this.groupBoxGuess.TabIndex = 0;
            this.groupBoxGuess.TabStop = false;
            this.groupBoxGuess.Text = "Guess:";
            // 
            // pictureBoxCategory
            // 
            this.pictureBoxCategory.Location = new System.Drawing.Point(49, 36);
            this.pictureBoxCategory.Name = "pictureBoxCategory";
            this.pictureBoxCategory.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCategory.TabIndex = 1;
            this.pictureBoxCategory.TabStop = false;
            // 
            // labelNonPicCategory
            // 
            this.labelNonPicCategory.AutoSize = true;
            this.labelNonPicCategory.Location = new System.Drawing.Point(46, 20);
            this.labelNonPicCategory.Name = "labelNonPicCategory";
            this.labelNonPicCategory.Size = new System.Drawing.Size(80, 13);
            this.labelNonPicCategory.TabIndex = 0;
            this.labelNonPicCategory.Text = "Country/Capital";
            // 
            // groupBoxHint
            // 
            this.groupBoxHint.Controls.Add(this.radioButtonAnswer4);
            this.groupBoxHint.Controls.Add(this.radioButtonAnswer3);
            this.groupBoxHint.Controls.Add(this.radioButtonAnswer2);
            this.groupBoxHint.Controls.Add(this.radioButtonAnswer1);
            this.groupBoxHint.Location = new System.Drawing.Point(13, 154);
            this.groupBoxHint.Name = "groupBoxHint";
            this.groupBoxHint.Size = new System.Drawing.Size(354, 171);
            this.groupBoxHint.TabIndex = 1;
            this.groupBoxHint.TabStop = false;
            this.groupBoxHint.Text = "Answers:";
            // 
            // radioButtonAnswer4
            // 
            this.radioButtonAnswer4.AutoSize = true;
            this.radioButtonAnswer4.Location = new System.Drawing.Point(7, 132);
            this.radioButtonAnswer4.Name = "radioButtonAnswer4";
            this.radioButtonAnswer4.Size = new System.Drawing.Size(66, 17);
            this.radioButtonAnswer4.TabIndex = 3;
            this.radioButtonAnswer4.TabStop = true;
            this.radioButtonAnswer4.Text = "Answer4";
            this.radioButtonAnswer4.UseVisualStyleBackColor = true;
            this.radioButtonAnswer4.CheckedChanged += new System.EventHandler(this.AllRadioButtons_CheckedChanged);
            // 
            // radioButtonAnswer3
            // 
            this.radioButtonAnswer3.AutoSize = true;
            this.radioButtonAnswer3.Location = new System.Drawing.Point(7, 97);
            this.radioButtonAnswer3.Name = "radioButtonAnswer3";
            this.radioButtonAnswer3.Size = new System.Drawing.Size(66, 17);
            this.radioButtonAnswer3.TabIndex = 2;
            this.radioButtonAnswer3.TabStop = true;
            this.radioButtonAnswer3.Text = "Answer3";
            this.radioButtonAnswer3.UseVisualStyleBackColor = true;
            this.radioButtonAnswer3.CheckedChanged += new System.EventHandler(this.AllRadioButtons_CheckedChanged);
            // 
            // radioButtonAnswer2
            // 
            this.radioButtonAnswer2.AutoSize = true;
            this.radioButtonAnswer2.Location = new System.Drawing.Point(7, 60);
            this.radioButtonAnswer2.Name = "radioButtonAnswer2";
            this.radioButtonAnswer2.Size = new System.Drawing.Size(66, 17);
            this.radioButtonAnswer2.TabIndex = 1;
            this.radioButtonAnswer2.TabStop = true;
            this.radioButtonAnswer2.Text = "Answer2";
            this.radioButtonAnswer2.UseVisualStyleBackColor = true;
            this.radioButtonAnswer2.CheckedChanged += new System.EventHandler(this.AllRadioButtons_CheckedChanged);
            // 
            // radioButtonAnswer1
            // 
            this.radioButtonAnswer1.AutoSize = true;
            this.radioButtonAnswer1.Location = new System.Drawing.Point(7, 20);
            this.radioButtonAnswer1.Name = "radioButtonAnswer1";
            this.radioButtonAnswer1.Size = new System.Drawing.Size(66, 17);
            this.radioButtonAnswer1.TabIndex = 0;
            this.radioButtonAnswer1.TabStop = true;
            this.radioButtonAnswer1.Text = "Answer1";
            this.radioButtonAnswer1.UseVisualStyleBackColor = true;
            this.radioButtonAnswer1.CheckedChanged += new System.EventHandler(this.AllRadioButtons_CheckedChanged);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 337);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(40, 13);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "Result:";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(291, 401);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(129, 401);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(75, 23);
            this.buttonRestart.TabIndex = 4;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // labelRoundNum
            // 
            this.labelRoundNum.AutoSize = true;
            this.labelRoundNum.Location = new System.Drawing.Point(347, 9);
            this.labelRoundNum.Name = "labelRoundNum";
            this.labelRoundNum.Size = new System.Drawing.Size(20, 13);
            this.labelRoundNum.TabIndex = 5;
            this.labelRoundNum.Text = "#n";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(12, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(19, 13);
            this.labelScore.TabIndex = 6;
            this.labelScore.Text = "$n";
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Location = new System.Drawing.Point(12, 374);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResult.TabIndex = 2;
            this.pictureBoxResult.TabStop = false;
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(210, 401);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(75, 23);
            this.buttonValidate.TabIndex = 7;
            this.buttonValidate.Text = "Validate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 449);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelRoundNum);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.groupBoxHint);
            this.Controls.Add(this.groupBoxGuess);
            this.Name = "PlayForm";
            this.Text = "Quiz: Play";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            this.groupBoxGuess.ResumeLayout(false);
            this.groupBoxGuess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategory)).EndInit();
            this.groupBoxHint.ResumeLayout(false);
            this.groupBoxHint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGuess;
        private System.Windows.Forms.PictureBox pictureBoxCategory;
        private System.Windows.Forms.Label labelNonPicCategory;
        private System.Windows.Forms.GroupBox groupBoxHint;
        private System.Windows.Forms.RadioButton radioButtonAnswer4;
        private System.Windows.Forms.RadioButton radioButtonAnswer3;
        private System.Windows.Forms.RadioButton radioButtonAnswer2;
        private System.Windows.Forms.RadioButton radioButtonAnswer1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label labelRoundNum;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Button buttonValidate;
    }
}