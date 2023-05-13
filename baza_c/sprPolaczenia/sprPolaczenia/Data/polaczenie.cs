using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sprPolaczenia.Data
{
    internal class polaczenie
    {
        public static MySqlConnection connMaster = new MySqlConnection();

        static string server = "XXX";
        static string database = "XXX";
        static string Uid = "XXX";
        static string password = "XXX";

        public static MySqlConnection dataSource()
        {
            connMaster = new MySqlConnection($"server={server} database={database} Uid={Uid} password={password}");
            return connMaster;
        }

        public void connOpen()
        {
            dataSource();
            connMaster.Open();

        }

        public void connClose()
        {
            dataSource();
            connMaster.Close();
        }

    }
}
