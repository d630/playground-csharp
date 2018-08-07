using System;
using System.Data;
using System.Windows.Forms;

// TODO: Also: show highscore per user (select user, then show score).

namespace Quiz.View
{
    internal partial class HighScoreForm : Form, IHighScoreView
    {
        public HighScoreForm()
        {
            InitializeComponent();
        }

        public Presenter.HighScorePresenter Presenter
        {
            private get;
            set;
        }

        public DataTable HighScoreDataTable
        {
            get { return (DataTable)this.dataGridView.DataSource; }
            set { this.dataGridView.DataSource = value; }
        }

        private void HighScoreForm_Load(object sender, EventArgs e)
        {
            this.Presenter.updateHighScoreDataTable();
        }
    }
}
