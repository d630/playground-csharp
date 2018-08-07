using System.Windows.Forms;

namespace Quiz.View
{
    public interface IConfigView
    {
        Presenter.ConfigPresenter Presenter { set; }
        string NickName { get; set; }
        string RoundsTotal { get; set; }
        string HighScore { get; set; }
        BindingSource GuessCategoryDictionary { get; set; }
        BindingSource HintCategoryDictionary { get; set; }
        string SelectedGuessCategory { get; }
        string SelectedHintCategory { get; }
    }
}
