using System.Collections.Generic;

namespace Quiz.Classes
{
    // This class provides important information about the game and stores also variable data.
    // TODO: Consider to initialize RoundNumber with 0.

    public class Game
    {
        private Category category;

        public Game()
        {
            this.category = new Category();
            this.RecordsTotal = 40;
            this.RecordsPerRoundTotal = 4;
            this.RoundNumber = 1;
            this.RoundsTotal = this.RecordsTotal / this.RecordsPerRoundTotal;
            this.Score = 0;
        }

        public Player Player { get; set; }
        public string CategoryHint { get; set; }
        public string CategoryGuess { get; set; }
        public int Score { get; set; }
        public Stack<Country> Records { get; set; }
        public int RecordsTotal { get; }
        public int RecordsPerRoundTotal { get; }
        public int RoundNumber { get; set; }
        public int RoundsTotal { get; set; }

        public Category Category
        {
            get { return category; }
        }

        public void incrementRoundNumber()
        {
            this.RoundNumber += 1;
        }

        public void incrementScore()
        {
            this.Score += 100;
        }

        public void resetScore()
        {
            this.Score = 0;
        }

        public void resetRoundNumber()
        {
            this.RoundNumber = 1;
        }
    }
}
