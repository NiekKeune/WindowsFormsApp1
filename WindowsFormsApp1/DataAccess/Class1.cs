using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;

namespace WindowsFormsApp1.DataAccess
{
    class DataCommander
    {
        public event Action ContainersReady;

        private readonly SQLiteConnection conn;
        private string connString = ConfigurationManager.ConnectionStrings["ContainerDB"].ToString();

        public DataCommander()
        {
            conn = new SQLiteConnection(connString);
        }


        public List<string> GetAllContainers()
        {
            List<string> list = new List<string>();

            string sql = "SELECT * FROM Container";

            SQLiteCommand command = new SQLiteCommand(conn);
            command.CommandText = sql;

            conn.Open();

            SQLiteDataReader datareader;

            using(datareader = command.ExecuteReader())
            {
                while (datareader.Read())
                {
                    string result = String.Format("Container: {0}, {1}, {2}, {3}",
                        datareader.GetString(1),
                        datareader.GetInt32(2),
                        datareader.GetInt32(3),
                        datareader.GetInt32(0));

                    list.Add(result);
                        
                }
            }
            conn.Close();
            if (ContainersReady != null)
            {
                ContainersReady.Invoke();
            }
            return list;
        }
    }
}
