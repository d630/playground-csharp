using System;
using System.Windows.Forms;

namespace Quiz.View
{
    internal partial class StartForm : Form, IStartView
    {
        public StartForm()
        {
            InitializeComponent();
        }

        public Presenter.StartPresenter Presenter
        {
            private get;
            set;
        }

        private void buttonHighScore_Click(object sender, EventArgs e)
        {
            var repository = new Quiz.Model.HighScoreMySqlRepository();
            var view = new Quiz.View.HighScoreForm();
            var presenter = new Quiz.Presenter.HighScorePresenter(view, repository);
            this.runForm(view);
        }

        private void buttonGame_Click(object sender, EventArgs e)
        {
            var repository = new Quiz.Model.ConfigMySqlRepository();
            var view = new Quiz.View.ConfigForm();
            var presenter = new Quiz.Presenter.ConfigPresenter(view, repository);
            this.runForm(view);
        }

        private void runForm(Form f)
        {
            f.Show();
            f.Location = this.Location;
        }
    }
}
