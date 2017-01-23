using System.Data.SqlClient;
using System.Configuration;
namespace MTR_App
{
    internal class Connection
    {
        public static string MTRInfoTablesConn = ConfigurationManager.ConnectionStrings["MTR_App.Properties.Settings.MTRInfoTablesConn"].ConnectionString;

        public static string MTRDataBaseConn = ConfigurationManager.ConnectionStrings["MTR_App.Properties.Settings.MTR_DatabaseConn"].ConnectionString;
    }
}