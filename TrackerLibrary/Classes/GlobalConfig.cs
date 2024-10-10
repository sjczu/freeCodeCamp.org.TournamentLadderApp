using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Interfaces;
using TrackerLibrary.Classes;
using System.Configuration;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnections(ConnectionType connectionType)
        {
            if (connectionType.Equals(ConnectionType.Sql))
            {
                // TODO - Set up proper SQL Connector.
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }

            else if (connectionType.Equals(ConnectionType.TextFile))
            {
                // TODO - Set up proper Text Connector.
                TextConnector file = new TextConnector();
                Connection = file;
            }
        }

        public static string ConnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
