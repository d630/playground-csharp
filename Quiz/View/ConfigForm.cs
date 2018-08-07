using System;
using System.Windows.Forms;

namespace Quiz.View
{
    internal partial class ConfigForm : Form, IConfigView
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        // -- Poperties.

        public Presenter.ConfigPresenter Presenter
        {
            private get;
            set;
        }

        public string NickName
        {
            get { return this.textBoxNickName.Text; }
            set { this.textBoxNickName.Text = value; }
        }

        public string RoundsTotal
        {
            get { return this.textBoxRounds.Text; }
            set { this.textBoxRounds.Text = value; }
        }

        public string HighScore
        {
            get { return this.textBoxHighScore.Text; }
            set { this.textBoxHighScore.Text = value; }
        }

        public BindingSource GuessCategoryDictionary
        {
            get { return (BindingSource)this.comboBoxGuess.DataSource; }
            set { this.comboBoxGuess.DataSource = value; }
        }

        public BindingSource HintCategoryDictionary
        {
            get { return (BindingSource)this.comboBoxHint.DataSource; }
            set { this.comboBoxHint.DataSource = value; }
        }

        public string SelectedGuessCategory
        {
            get { return this.comboBoxGuess.Text; }
        }

        public string SelectedHintCategory
        {
            get { return this.comboBoxHint.Text; }
        }

        // -- Events.

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            this.Presenter.SetGuessCategoryDictionary();
        }

        private void textBoxNickName_TextChanged(object sender, EventArgs e)
        {
            this.Presenter.handleNickName();
        }

        private void comboBoxGuess_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Presenter.updateHintCategoryComboBox();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            this.Presenter.registerUser();
            this.Presenter.registerCategories();

            var repository = new Quiz.Model.PlayMySqlRepository();
            var view = new Quiz.View.PlayForm();
            var presenter = new Quiz.Presenter.PlayPresenter(view, repository, this.Presenter.Game);

            view.Show();
            view.Location = this.Location;

            this.Close();
        }
    }
}
