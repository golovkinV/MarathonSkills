using System;
using System.Collections.Generic;
using Marathons;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace AdminService
{

    public class Service1 : IService1
    {

        public List<Charity> GetAllCharity()
        {
            var reader = Reader.GetTableReader(AdminRequest.Charities());
            var charities = new List<Charity>();
            while (reader.Read())
            {
                var charity = new Charity(
                        reader["CharityId"].ToString(),
                        reader["CharityName"].ToString(),
                        reader["CharityDescription"].ToString(),
                        reader["CharityLogo"].ToString()
                    );
                charities.Add(charity);
            }
            return charities;
        }

        public void EditCharity(Charity charity)
        {
            using (SqlConnection con = new SqlConnection(Configuration.someeServer))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = AdminRequest.UpdateCharity(charity);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
