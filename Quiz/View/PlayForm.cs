using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Quiz.View
{
    internal partial class PlayForm : Form, IPlayView
    {
        private int selectedRadioButtonIndex;
        private IDictionary<RadioButton, int> radioButtons;

        public PlayForm()
        {
            InitializeComponent();
            this.selectedRadioButtonIndex = -1;
            this.mapRadioButtons(new RadioButton[]
                                 { this.radioButtonAnswer1, this.radioButtonAnswer2,
                                 this.radioButtonAnswer3, this.radioButtonAnswer4 });
        }

        // -- Properties.

        public Presenter.PlayPresenter Presenter
        {
            private get;
            set;
        }

        public string RoundNumberDisplay
        {
            get { return this.labelRoundNum.Text; }
            set { this.labelRoundNum.Text = value; }
        }

        public string NonPicGuess
        {
            get { return this.labelNonPicCategory.Text; }
            set { this.labelNonPicCategory.Text = value; }
        }

        public Image PicGuess
        {
            get { return this.pictureBoxCategory.Image; }
            set { this.pictureBoxCategory.Image = value; }
        }

        public string Answer1
        {
            get { return this.radioButtonAnswer1.Text; }
            set { this.radioButtonAnswer1.Text = value; }
        }

        public string Answer2
        {
            get { return this.radioButtonAnswer2.Text; }
            set { this.radioButtonAnswer2.Text = value; }
        }

        public string Answer3
        {
            get { return this.radioButtonAnswer3.Text; }
            set { this.radioButtonAnswer3.Text = value; }
        }

        public string Answer4
        {
            get { return this.radioButtonAnswer4.Text; }
            set { this.radioButtonAnswer4.Text = value; }
        }

        public Image Answer1Pic
        {
            get { return this.radioButtonAnswer1.Image; }
            set { this.radioButtonAnswer1.Image = value; }
        }

        public Image Answer2Pic
        {
            get { return this.radioButtonAnswer2.Image; }
            set { this.radioButtonAnswer2.Image = value; }
        }

        public Image Answer3Pic
        {
            get { return this.radioButtonAnswer3.Image; }
            set { this.radioButtonAnswer3.Image = value; }
        }

        public Image Answer4Pic
        {
            get { return this.radioButtonAnswer4.Image; }
            set { this.radioButtonAnswer4.Image = value; }
        }

        public string Result
        {
            get { return this.labelResult.Text; }
            set { this.labelResult.Text = value; }
        }

        public Color ResultForeColor
        {
            get { return this.labelResult.ForeColor; }
            set { this.labelResult.ForeColor = value ; }
        }

        public string Score
        {
            get { return this.labelScore.Text; }
            set { this.labelScore.Text = value; }
        }

        public Image PicResult
        {
            get { return this.pictureBoxResult.Image; }
            set { this.pictureBoxResult.Image = value; }
        }

        public string NextAction
        {
            get { return this.buttonNext.Text; }
            set { this.buttonNext.Text = value; }
        }

        // -- Methods.

        public void exitGame()
        {
            this.Close();
        }

        // -- Events.

        private void mapRadioButtons(RadioButton[] rb)
        {
            int i = 0;
            this.radioButtons = rb.ToDictionary(key => key, value => i++);
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {
            this.Presenter.onLoad();
        }

        // TODO Use lowercase name
        private void AllRadioButtons_CheckedChanged(Object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                this.selectedRadioButtonIndex = this.radioButtons[(RadioButton)sender];
            }
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            this.Presenter.onLoad();
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            this.Presenter.validateRound(this.selectedRadioButtonIndex);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.Presenter.finishRound(this.selectedRadioButtonIndex);
        }
    }
}
