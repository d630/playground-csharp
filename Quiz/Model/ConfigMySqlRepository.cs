using System.Collections.Generic;
using Quiz.Classes;

namespace Quiz.Model
{
    internal class ConfigMySqlRepository : IConfigRepository
    {
        private readonly DataBaseMySql db;

        public ConfigMySqlRepository()
        {
            this.db = new DataBaseMySql();
        }

        public IList<Player> getPlayer(string nick_name)
        {
            return this.db.selectPlayer(nick_name: nick_name);
        }

        public bool savePlayer(string nick_name)
        {
            return this.db.insertPlayer(nick_name);
        }
    }
}

