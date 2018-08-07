using System.Drawing;

namespace Quiz.View
{
    public interface IPlayView
    {
        Presenter.PlayPresenter Presenter { set; }
        string NonPicGuess { get; set; }
        Image PicGuess { get; set; }
        string Answer1 { get; set; }
        string Answer2 { get; set; }
        string Answer3 { get; set; }
        string Answer4 { get; set; }
        Image Answer1Pic { get; set; }
        Image Answer2Pic { get; set; }
        Image Answer3Pic { get; set; }
        Image Answer4Pic { get; set; }
        string RoundNumberDisplay { get; set; }
        string Result { get; set; }
        Color ResultForeColor { get; set; }
        string Score { get; set; }
        Image PicResult { get; set; }
        string NextAction { get; set; }
        void exitGame();
    }
}
