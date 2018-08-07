using Quiz.View;
using Quiz.Model;

namespace Quiz.Presenter
{
    public class HighScorePresenter
    {
        private readonly IHighScoreView view;
        private readonly IHighScoreRepository repository;

        public HighScorePresenter(IHighScoreView view, IHighScoreRepository repository)
        {
            this.view = view;
            view.Presenter = this;
            this.repository = repository;
        }

        public void updateHighScoreDataTable()
        {
            this.view.HighScoreDataTable = this.repository.getAllPlayers();
        }
    }
}
