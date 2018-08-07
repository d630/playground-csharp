using System.Data;

namespace Quiz.View
{
    public interface IHighScoreView
    {
        Presenter.HighScorePresenter Presenter { set; }
        DataTable HighScoreDataTable { get; set; }
    }
}
