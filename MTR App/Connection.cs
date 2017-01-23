using System.Data.SqlClient;

namespace MTR_App
{
    internal class Connection
    {
        public static SqlConnection InfoTableConnection = null;

        public void InfoConnection()
        {
            InfoTableConnection = new SqlConnection("Data Source=(localdb)/MSSQLLocalDB;Initial Catalog=MTRInfoTables;Integrated Security=True");

            InfoTableConnection.Open();
        }

        public void MasterTableConnection()
        {
            InfoTableConnection = new SqlConnection("Data Source=(localdb)/MSSQLLocalDB;Initial Catalog=MTRInfoTables;Integrated Security=True");

            InfoTableConnection.Open();
        }
    }
}