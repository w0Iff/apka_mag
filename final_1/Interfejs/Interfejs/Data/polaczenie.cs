using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace Interfejs.Data
{
   
    
    
        internal class polaczenie
        {
            public static MySqlConnection connMaster = new MySqlConnection();
            private static IConfigurationRoot configuration;

            public static MySqlConnection dataSource()
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");

                configuration = builder.Build();

                string server = configuration["ConnectionStrings:Server"];
                string database = configuration["ConnectionStrings:Database"];
                string uid = configuration["ConnectionStrings:Uid"];
                string password = configuration["ConnectionStrings:Password"];

                string connectionString = $"server={server}; database={database}; Uid={uid}; password={password}";
                connMaster = new MySqlConnection(connectionString);
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
