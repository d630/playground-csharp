using Quiz.View;
using Quiz.Model;
using Quiz.Classes;
using System.Drawing;

// TODO: Avoid hard coded dir locations (png files).
// TODO: Take MySql possible disfunctionality into account.
// TODO: Sytem.Drawing shouldn't be used here.
// TODO: Better error handling: pass exceptions and bool return values.

namespace Quiz.Presenter
{
    public class PlayPresenter
    {
        private delegate void DisplayQuestion();
        private delegate void DisplayAnswers();

        private readonly IPlayView view;
        private readonly IPlayRepository repository;

        private Game game;
        private Round currentRound;

        private DisplayQuestion displayQuestion;
        private DisplayAnswers displayAnswers;

        public PlayPresenter(IPlayView view, IPlayRepository repository, Game game)
        {
            this.view = view;
            view.Presenter = this;
            this.repository = repository;
            this.game = game;

            switch (game.CategoryGuess)
            {
                case "flag":
                    this.displayQuestion = new DisplayQuestion(displayQuestionAsFlag);
                    break;
                case "capital":
                    this.displayQuestion = new DisplayQuestion(displayQuestionAsCapital);
                    break;
                default:
                    this.displayQuestion = new DisplayQuestion(displayQuestionAsCountry);
                    break;
            }

            switch (game.CategoryHint)
            {
                case "flag":
                    this.displayAnswers = new DisplayAnswers(displayAnswersAsFlag);
                    break;
                case "capital":
                    this.displayAnswers = new DisplayAnswers(displayAnswersAsCapital);
                    break;
                default:
                    this.displayAnswers = new DisplayAnswers(displayAnswersAsCountry);
                    break;
            }
        }

        private void displayGameScore()
        {
            this.view.Score = "$" + this.game.Score.ToString();
        }

        private void displayRound()
        {
            this.displayRoundNumber();
            try
            {
                this.displayQuestion();
                this.displayAnswers();
            }
            catch
            {
            }
            this.view.Result = string.Empty;
            this.view.PicResult = null;

            if (this.game.RoundNumber == this.game.RoundsTotal)
                this.view.NextAction = "Finish";
            else
                this.view.NextAction = "Next";
        }

        private void displayRoundNumber()
        {
            this.view.RoundNumberDisplay = "#" + this.game.RoundNumber.ToString();
        }

        private void displayQuestionAsFlag()
        {
            this.view.NonPicGuess = string.Empty;
            this.view.PicGuess = Image.FromFile(@"share\pics\128x128\" +
                                                $"{this.currentRound.correctAnswer.C_code}.png");
        }

        private void displayQuestionAsCapital()
        {
            this.view.NonPicGuess = this.currentRound.correctAnswer.Capital_name;
            this.view.PicGuess = null;
        }

        private void displayQuestionAsCountry()
        {
            this.view.NonPicGuess = this.currentRound.correctAnswer.C_name;
            this.view.PicGuess = null;
        }

        private void displayAnswersAsFlag()
        {
            this.view.Answer1 = string.Empty;
            this.view.Answer2 = string.Empty;
            this.view.Answer3 = string.Empty;
            this.view.Answer4 = string.Empty;
            this.view.Answer1Pic = Image.FromFile(@"share\pics\32x32\" +
                                                  $"{this.currentRound.Answers[0].C_code}.png");
            this.view.Answer2Pic = Image.FromFile(@"share\pics\32x32\" +
                                                  $"{this.currentRound.Answers[1].C_code}.png");
            this.view.Answer3Pic = Image.FromFile(@"share\pics\32x32\" +
                                                  $"{this.currentRound.Answers[2].C_code}.png");
            this.view.Answer4Pic = Image.FromFile(@"share\pics\32x32\" +
                                                  $"{this.currentRound.Answers[3].C_code}.png");
        }

        private void displayAnswersAsCapital()
        {
            this.view.Answer1 = this.currentRound.Answers[0].Capital_name;
            this.view.Answer2 = this.currentRound.Answers[1].Capital_name;
            this.view.Answer3 = this.currentRound.Answers[2].Capital_name;
            this.view.Answer4 = this.currentRound.Answers[3].Capital_name;
            this.view.Answer1Pic = null;
            this.view.Answer2Pic = null;
            this.view.Answer3Pic = null;
            this.view.Answer4Pic = null;
        }

        private void displayAnswersAsCountry()
        {
            this.view.Answer1 = this.currentRound.Answers[0].C_name;
            this.view.Answer2 = this.currentRound.Answers[1].C_name;
            this.view.Answer3 = this.currentRound.Answers[2].C_name;
            this.view.Answer4 = this.currentRound.Answers[3].C_name;
            this.view.Answer1Pic = null;
            this.view.Answer2Pic = null;
            this.view.Answer3Pic = null;
            this.view.Answer4Pic = null;
        }

        public void onLoad()
        {
            this.game.Records = this.repository.getRandomRecords(this.game.RecordsTotal);
            if (this.game.Records.Count == 0)
                return;
            this.game.resetScore();
            this.game.resetRoundNumber();
            this.displayGameScore();

            this.currentRound = new Round(this.game);
            this.displayRound();
        }

        public void validateRound(int index)
        {
            if (index == -1 || this.currentRound.IsValidated)
                return;

            this.game.incrementRoundNumber();
            if (this.currentRound.isCorrectQA(index))
            {
                this.game.incrementScore();
                this.view.ResultForeColor = Color.Green;
            }
            else
            {
                this.view.ResultForeColor = Color.Red;
            }

            this.view.Result = this.currentRound.ToString();
            try
            {
                this.view.PicResult = Image.FromFile(@"share\pics\32x32\" +
                                                 $"{this.currentRound.correctAnswer.C_code}.png");
            }
            catch
            {
            }

            this.displayGameScore();

            this.currentRound.IsValidated = true;
        }

        public void finishRound(int index)
        {
            if (index == -1 || ! this.currentRound.IsValidated)
                return;

            if (this.game.RoundNumber > this.game.RoundsTotal)
            {
                this.finishGame();
            }
            else
            {
                this.currentRound = new Round(this.game);
                this.displayRound();
            }
        }

        private void finishGame()
        {
            this.repository.updatePlayer(this.game.Player.Id,
                                         this.game.Player.Rounds_total + this.currentRound.Number,
                                         this.game.Player.High_score + this.game.Score);

            this.view.exitGame();
        }
    }
}
