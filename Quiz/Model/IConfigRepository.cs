using System.Collections.Generic;
using Quiz.Classes;

namespace Quiz.Model
{
    public interface IConfigRepository
    {
        IList<Player> getPlayer(string nick_name);
        bool savePlayer(string nick_name);
    }
}
