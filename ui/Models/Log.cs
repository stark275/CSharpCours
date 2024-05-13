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

        private MySqlDB DbCnx { get; }
        public Log(MySqlDB DbCnx) {
            this.DbCnx = DbCnx;
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
            using (var connection = DbCnx.MysqlConnection)
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
            using (var connection = DbCnx.MysqlConnection)
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

    }
}
