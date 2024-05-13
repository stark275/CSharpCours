using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ui.Database;

namespace ui.Models
{
    internal class Log
    {

       /* private MySqlDB DbCnx { get; }*/
        public Log() {
           /* this.DbCnx = DbCnx;*/
        }

        public int CreateLog(string joueurName, int tentatives)
        {

            
            using (var connection = new MySqlDB("127.0.0.1", "root", "", "jeu").MysqlConnection)
            {
                connection.Open();
                var query = "INSERT INTO logs (nom_joueur, tentatives) VALUES (@joueurName, @tentatives)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@joueurName", joueurName);
                    command.Parameters.AddWithValue("@tentatives", tentatives);
                    return command.ExecuteNonQuery();
                }
            }
        }

        public int UpdateLog(int logId, string joueurName, int tentatives)
        {
            using (var connection = new MySqlDB("127.0.0.1", "root", "", "jeu").MysqlConnection)
            {
                connection.Open();
                var query = "UPDATE logs SET nom_joueur = @joueurName, tentatives = @tentatives WHERE id = @logId";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@logId", logId);
                    command.Parameters.AddWithValue("@joueurName", joueurName);
                    command.Parameters.AddWithValue("@tentatives", tentatives);
                    return command.ExecuteNonQuery();
                }
            }
        }

        public int DeleteLog(int logId)
        {
            using (var connection = new MySqlDB("127.0.0.1", "root", "", "jeu").MysqlConnection)
            {
                connection.Open();
                var query = "DELETE FROM logs WHERE id = @logId";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@logId", logId);
                    return command.ExecuteNonQuery();
                }
            }
        }

        public List<string> GetLogs()
        {
            List<string> logs = new List<string>();

            using (var mySqlCn = new MySqlDB("127.0.0.1", "root", "", "jeu").MysqlConnection)
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
                                //Console.WriteLine($"{mySqlReader["id"]}. {mySqlReader["nom_joueur"]}: {mySqlReader["tentatives"]} Tentatives");

                                logs.Add($"{mySqlReader["id"]}. {mySqlReader["nom_joueur"]}: {mySqlReader["tentatives"]} Tentatives");
                            }
                        }

                        return logs;
                    }
                }
            }
        }

    }
}
