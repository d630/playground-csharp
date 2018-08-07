using Quiz.View;
using Quiz.Model;
using Quiz.Classes;
using System.Windows.Forms;

/*
 * TODO: BindingSource from System.Windows.Forms shouldn't be used here.
 * TODO: Use bool return values, if possible.
*/

namespace Quiz.Presenter
{
    public class ConfigPresenter
    {
        private readonly IConfigView view;
        private readonly IConfigRepository repository;
        private Game game;

        public ConfigPresenter(IConfigView view, IConfigRepository repository)
        {
            this.view = view;
            view.Presenter = this;
            this.repository = repository;
            this.game = new Game();
        }

        public Game Game
        {
            get { return game; }
        }

        public void SetGuessCategoryDictionary()
        {
            this.view.GuessCategoryDictionary = new BindingSource(this.game.Category.Categories,
                                                                  null);
        }

        private void SetHintCategoryDictionary(BindingSource bc)
        {
            this.view.HintCategoryDictionary = bc;
        }

        public void handleNickName()
        {
            this.view.RoundsTotal = "0";
            this.view.HighScore = "0";
            this.game.Player = null;

            if (string.IsNullOrEmpty(this.view.NickName))
                return;

            var list = this.repository.getPlayer(this.view.NickName);

            if (list.Count > 0)
            {
                this.game.Player = list[0];
                this.view.RoundsTotal = list[0].Rounds_total.ToString();
                this.view.HighScore = list[0].High_score.ToString();
            }
        }

        public void updateHintCategoryComboBox()
        {
            var c = new Category();
            var dict = c.Categories;

            dict.Remove(this.view.SelectedGuessCategory);

            this.SetHintCategoryDictionary(new BindingSource(dict, null));
        }

        public void registerUser()
        {
            if (this.game.Player != null || !this.repository.savePlayer(this.view.NickName))
                return;

            // if (!this.repository.savePlayer(this.view.NickName))
            //     return;

            var list = this.repository.getPlayer(this.view.NickName);
            if (list.Count > 0)
                this.game.Player = list[0];
        }

        public void registerCategories()
        {
            this.game.CategoryGuess = this.view.SelectedGuessCategory;
            this.game.CategoryHint = this.view.SelectedHintCategory;
        }
    }
}
