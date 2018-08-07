using System.Data;
using Quiz.Classes;

namespace Quiz.Model
{
    internal class HighScoreMySqlRepository : IHighScoreRepository
    {
        private readonly DataBaseMySql db;

        public HighScoreMySqlRepository()
        {
            this.db = new DataBaseMySql();
        }

        public DataTable getAllPlayers()
        {
            return this.db.adaptPlayer();
        }
    }
}