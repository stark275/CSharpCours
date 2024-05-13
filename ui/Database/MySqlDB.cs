using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace ui.Database
{
    internal class MySqlDB
    {

        public MySqlConnection MysqlConnection { get; }
        public MySqlDB(string serveur, string user, string mdp, string bdd) {
            string M_str_sqlcon = $"Server={serveur};Database={bdd};User={user};Password={mdp}" ;

            // try Catch
            MysqlConnection = new MySqlConnection(M_str_sqlcon);
        }

        public void testConnexion()
        {
            using (var mySqlCn = MysqlConnection)
            {
                using (var mySqlCmd = new MySqlCommand("select * from logs", mySqlCn))
                {
                    mySqlCn.Open();
                    using (MySqlDataReader mySqlReader = mySqlCmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (mySqlReader.Read())
                        {
                            if (!mySqlReader.IsDBNull(0))
                            {
                                MessageBox.Show($"{mySqlReader["nom_joueur"]}: {mySqlReader["tentatives"]}");
                            }
                        }
                    }
                }
            }
        }
    }
}
