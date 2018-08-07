using System;
using System.Windows.Forms;

namespace Quiz
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var repository = new Quiz.Model.StartMySqlRepository();
            var view = new Quiz.View.StartForm();
            var presenter = new Quiz.Presenter.StartPresenter(view, repository);

            Application.Run(view);
        }
    }
}
