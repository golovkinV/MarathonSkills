using System;
using System.Collections.Generic;
using Marathons;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RunnerService
{

    public class Service1 : IRunnerService
    {
        public Charity GetCharity(int charityId)
        {
            var reader = Reader.GetTableReader(RunnerRequest.Charity(charityId));
            reader.Read();
            return new Charity(
                reader["CharityId"].ToString(),
                reader["CharityName"].ToString(),
                reader["CharityDescription"].ToString(),
                reader["CharityLogo"].ToString()
            );
        }

        public List<RaceInfo> GetRaces(int runnerId)
        {
            var reader = Reader.GetTableReader(RunnerRequest.Races(runnerId));
            var races = new List<RaceInfo>();
            while (reader.Read()) {
                var race = new RaceInfo(
                        reader["Gender"].ToString(),
                        reader["DateOfBirth"].ToString(),
                        reader["RaceTime"].ToString(),
                        reader["CountryName"].ToString(),
                        reader["EventTypeName"].ToString(),
                        reader["YearHeld"].ToString()
                    );
                races.Add(race);
            }
            return races;
        }

        public List<Sponsor> GetSponsorship(int runnerId)
        {
            var reader = Reader.GetTableReader(RunnerRequest.Sponsorship(runnerId));
            var sponsors = new List<Sponsor>();

            while (reader.Read()) {
                var sponsor = new Sponsor(
                        reader["SponsorshipId"].ToString(),
                        reader["SponsorName"].ToString(),
                        reader["RegistrationId"].ToString(),
                        reader["Amount"].ToString(),
                        reader["CharityId"].ToString()
                    );
                sponsors.Add(sponsor);
            }
            return sponsors;
        }
    }
}
