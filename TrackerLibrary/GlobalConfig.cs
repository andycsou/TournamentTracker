using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } // net 6
        
        public static void InitializeConnections(bool database, bool textFiles)
        {
            Connections = new List<IDataConnection>(); // for net 4
            if (database)
            {
                //TODO - cai dat SQL connector
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFiles)
            {
                //TODO - tao ket noi den text file
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }

    }
}
