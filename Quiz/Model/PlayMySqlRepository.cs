using System.Collections.Generic;
using Quiz.Classes;

namespace Quiz.Model
{
    internal class PlayMySqlRepository : IPlayRepository
    {
        private readonly DataBaseMySql db;

        public PlayMySqlRepository()
        {
            this.db = new DataBaseMySql();
        }

        public Stack<Country> getRandomRecords(int num)
        {
            return this.db.selectRandomCountries(num);
        }

        public bool updatePlayer(int id, int rounds_total, int high_score)
        {
            return this.db.updatePlayer(id, rounds_total, high_score);
        }
    }
}
