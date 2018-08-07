using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace Quiz.Classes
{

    /*
     * Big class for communicating with MySql. Sql commands here are serverside stored procedures.
     *
     * TODO: Implement a second class for the connection string. Dont' hard code it. Use a
     * configuration file. Also, create a regular user in MySql.
     *
     * TODO: This should be much smaller. Put special methods from here into the corresponding model
     * classes. Use inheritance.
     *
     * TODO: Find a way to pass exceptiosn from here. Consider to use an logging tool.
    */

    public class DataBaseMySql
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader rdr;
        private MySqlDataAdapter adpt;
        private string[] connArgs = {
            "persist security info = false",
            "server = 127.0.0.1",
            "database = quiz",
            "uid = root",
            "password = root",
            "encrypt = false"
        };

        public DataBaseMySql()
        {
            this.conn = new MySqlConnection(string.Join(";", this.connArgs));
        }

        private void dbOpen()
        {
            this.conn.Open();
        }

        private void dbAdapter()
        {
            this.adpt = new MySqlDataAdapter();
            this.adpt.SelectCommand = this.cmd;
        }

        private void dbAdapterFill(DataTable table)
        {
            this.adpt.Fill(table);
        }

        private void dbClose()
        {
            this.conn.Close();
        }

        private void dbCloseReader()
        {
            this.rdr.Close();
        }

        private void dbCommand(string sql)
        {
            this.cmd = new MySqlCommand(sql, this.conn);
            this.cmd.CommandType = CommandType.StoredProcedure;
        }

        private void dbCommandParameters(string para, string val)
        {
            this.cmd.Parameters.AddWithValue($"@{para}", val);
            //this.cmd.Parameters[para].Direction = ParameterDirection.Input;
        }

        private void dbCommandExecuteNonQuery()
        {
            this.cmd.ExecuteNonQuery();
        }

        private void dbExecuteReader()
        {
            this.rdr = this.cmd.ExecuteReader();
        }

        public IList<Player> selectPlayer(int id = -1, string nick_name = null)
        {
            var list = new List<Player>();

            try
            {
                this.dbOpen();

                if (!string.IsNullOrEmpty(nick_name))
                {
                    this.dbCommand("get_player_by_nick_name");
                    this.dbCommandParameters("_nick_name", nick_name);
                }
                else if (id <= -1)
                {
                    this.dbCommand("get_players_by_high_score");
                }
                else
                {
                    this.dbCommand("get_player_by_id");
                    this.dbCommandParameters("_id", id.ToString());
                }

                this.dbExecuteReader();
                while (this.rdr.Read())
                {
                    list.Add(new Player(
                                        this.rdr.GetInt32(0),
                                        this.rdr.GetString(1),
                                        this.rdr.GetInt32(2),
                                        this.rdr.GetInt32(3)));
                }
            }
            catch
            {
            }
            finally
            {
                if (this.rdr != null)
                    this.dbCloseReader();
                if (this.conn != null)
                    this.dbClose();
            }

            return list;
        }

        public DataTable adaptPlayer()
        {
            var table = new DataTable();

            try
            {
                this.dbOpen();
                this.dbCommand("get_players_by_high_score_named");
                this.dbAdapter();
                this.dbAdapterFill(table);
            }
            catch
            {
            }
            finally
            {
                if (this.conn != null)
                    this.dbClose();
            }

            return table;
        }

        public bool insertPlayer(string nick_name)
        {
            var ret = true;

            if (string.IsNullOrEmpty(nick_name) || string.IsNullOrWhiteSpace(nick_name))
                return false;

            try
            {
                this.dbOpen();
                this.dbCommand("set_player");
                this.dbCommandParameters("_nick_name", nick_name);
                this.dbCommandExecuteNonQuery();
            }
            catch
            {
                ret = false;
            }
            finally
            {
                if (this.conn != null)
                    this.dbClose();
            }

            return ret;
        }

        public bool updatePlayer(int id, int rounds_total, int high_score)
        {
            var ret = true;

            try
            {
                this.dbOpen();
                this.dbCommand("update_player");
                this.dbCommandParameters("_id", id.ToString());
                this.dbCommandParameters("_rounds_total", rounds_total.ToString());
                this.dbCommandParameters("_high_score", high_score.ToString());
                this.dbCommandExecuteNonQuery();
            }
            catch
            {
                ret = false;
            }
            finally
            {
                if (this.conn != null)
                    this.dbClose();
            }

            return ret;
        }

        public Stack<Country> selectRandomCountries(int n = 40)
        {
            var stack = new Stack<Country>();

            try
            {
                this.dbOpen();

                this.dbCommand("get_random_countries");
                this.dbCommandParameters("_n", n.ToString());

                this.dbExecuteReader();
                while (this.rdr.Read())
                {
                    stack.Push(new Country(
                                        this.rdr.GetString(0),
                                        this.rdr.GetString(1),
                                        this.rdr.GetString(2)));
                }
            }
            catch
            {
            }
            finally
            {
                if (this.rdr != null)
                    this.dbCloseReader();
                if (this.conn != null)
                    this.dbClose();
            }

            return stack;
        }
    }
}
