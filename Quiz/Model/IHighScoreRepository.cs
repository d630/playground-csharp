using System.Data;

namespace Quiz.Model
{
    public interface IHighScoreRepository
    {
        DataTable getAllPlayers();
    }
}
