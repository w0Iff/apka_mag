using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sprPolaczenia.Dane
{
    internal class polaczenie
    {
        public static MySqlConnection connMaster = new MySqlConnection();

        static string server = "34.116.216.206";
        static string database = "bazamag";
        static string Uid = "test";
        static string password = "test10";

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
