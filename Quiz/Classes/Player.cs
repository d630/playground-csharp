namespace Quiz.Classes
{
    /*
     * This class is for storing the corresponding sql records.
    */

    public class Player
    {
        public Player(int id, string nick_name, int rounds_total, int high_score)
        {
            this.Id = id;
            this.Nick_name = nick_name;
            this.Rounds_total = rounds_total;
            this.High_score = high_score;
        }

        public int Id { get; set; }
        public string Nick_name { get; set; }
        public int Rounds_total { get; set; }
        public int High_score { get; set; }
    }
}
