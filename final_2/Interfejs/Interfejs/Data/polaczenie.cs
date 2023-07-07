using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Interfejs.Data
{
    internal class polaczenie
    {
        public static MySqlConnection connMaster = new MySqlConnection();

        static string server = "mysql1.small.pl;";
        static string database = "m1344_test;";
        static string Uid = "m1344_root;";
        static string password = "Test123;";

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
