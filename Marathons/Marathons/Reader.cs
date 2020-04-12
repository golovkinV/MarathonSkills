
using System.Data;
using System.Data.SqlClient;


namespace Marathons
{
    public struct Reader
    {
        public static DataTableReader GetTableReader(string query)
        {
            var dt = new DataTable();
            var connection = Configuration.someeServer;

            using (SqlConnection con = new SqlConnection(connection))
            {
                var da = new SqlDataAdapter(query, con);
                da.Fill(dt);
            }

            var reader = dt.CreateDataReader();

            return reader;
        }
    }
}
