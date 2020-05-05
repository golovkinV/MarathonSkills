using System;
using System.Collections.Generic;
using Marathons;
using SerializationClasses;
using System.Data.SqlClient;
using System.Data;

namespace SponsorService
{
    public class Service1 : ISponsorService
    {
        public List<Runner> GetRunners()
        {
            var reader = Reader.GetTableReader(SponsorRequest.Runners());
            var runners = new List<Runner>();
            while (reader.Read())
            {
                var charity = new Charity(
                    reader["CharityId"].ToString(),
                    reader["CharityName"].ToString(),
                    reader["CharityDescription"].ToString(),
                    reader["CharityLogo"].ToString()
                );
                var runner = new Runner(
                        reader["RunnerId"].ToString(),
                        reader["RegistrationId"].ToString(),
                        reader["FirstName"].ToString(),
                        reader["LastName"].ToString(),
                        reader["CountryName"].ToString(),
                        reader["SponsorshipTarget"].ToString(),
                        charity
                    );
                runners.Add(runner);
            }
            return runners;
        }

        public void SponsorRunner(string name, Runner runner, double amount)
        {
            using (SqlConnection con = new SqlConnection(Configuration.someeServer))
            {
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = SponsorRequest.Sponsor(name, runner, amount);
                cmd.ExecuteNonQuery();

                runner.sponsorshipTarget += amount;
                var cmdUpdate = con.CreateCommand();
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = SponsorRequest.UpdateSponsorshipTarget(runner);
                cmdUpdate.ExecuteNonQuery();
            }
        }
    }
}
