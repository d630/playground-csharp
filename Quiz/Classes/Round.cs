using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz.Classes
{
    // This class stores variable data. In this App, each Round is an object.

    public class Round
    {
        private Game game;
        private Random rnd;

        public Round(Game game)
        {
            this.game = game;
            this.Number = game.RoundNumber;
            this.Answers = new List<Country>();
            this.rnd = new Random();
            this.updateAnswers();
        }

        public int Number { get; set; }
        public Country correctAnswer { get; set; }
        public List<Country> Answers { get; set; }
        public bool IsValidated { get; set; }

        private void updateAnswers()
        {
            if (this.game.Records.Count == 0)
                return;

            this.Answers.Clear();
            this.correctAnswer = this.game.Records.Pop();

            this.Answers.Add(this.correctAnswer);
            for (var i = 0; i < this.game.RecordsPerRoundTotal - 1; i++)
            {
                if (this.game.Records.Count > 0)
                    this.Answers.Add(this.game.Records.Pop());
                else
                    break;
            }

            // Using Linq to randomize a List
            this.Answers = this.Answers.OrderBy(x => this.rnd.Next()).ToList();
        }

        public bool isCorrectQA(int index)
        {
            return this.Answers[index].Equals(correctAnswer);
        }

        public override string ToString()
        {
            return $"{this.correctAnswer.C_name}\n{this.correctAnswer.Capital_name}";
        }
    }
}
