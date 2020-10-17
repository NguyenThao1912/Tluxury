using StoreLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public  static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
        /// <summary>
        /// Nếu muốn thêm kết nối thì thêm vào đây
        /// </summary>
        public static void InitializeConnections()
        {
            SQLConnectors sql = new SQLConnectors();
            Connection = sql;
        }
        public static string ConnectionString(string nameConnection)
        {
            return ConfigurationManager.ConnectionStrings[nameConnection].ConnectionString;
        }
    }
}
