using System.Collections.Generic;
using Quiz.Classes;

namespace Quiz.Model
{
    public interface IPlayRepository
    {
        Stack<Country> getRandomRecords(int num);
        bool updatePlayer(int id, int rounds_total, int high_score);
    }
}
