using Quiz.View;
using Quiz.Model;

namespace Quiz.Presenter
{
    public class StartPresenter
    {
        private readonly IStartView view;
        private readonly IStartRepository repository;

        public StartPresenter(IStartView view, IStartRepository repository)
        {
            this.view = view;
            view.Presenter = this;
            this.repository = repository;
        }
    }
}
