using SerializationClasses;
using System;
using System.Collections.Generic;
using Marathons;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace InfoService
{

    public class Service1 : IInfoService
    {
        public List<Charity> GetCharities()
        {
            var reader = Reader.GetTableReader(InfoRequest.Charities());
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

        public List<EventType> GetEventTypes()
        {
            var reader = Reader.GetTableReader(InfoRequest.EventTypes());
            var types = new List<EventType>();
            while (reader.Read())
            {
                var type = new EventType(
                    reader["EventTypeId"].ToString(),
                    reader["EventTypeName"].ToString()
                );
                types.Add(type);
            }
            return types;
        }

        public List<Marathon> GetMarathons()
        {
            var reader = Reader.GetTableReader(InfoRequest.Marathons());
            var marathons = new List<Marathon>();
            while (reader.Read())
            {
                var marathon = new Marathon(
                    reader["MarathonId"].ToString(),
                    reader["MarathonName"].ToString(),
                    reader["CityName"].ToString(),
                    reader["CountryCode"].ToString(),
                    reader["YearHeld"].ToString()
                );
                marathons.Add(marathon);
            }
            return marathons;
        }

        public List<RaceResult> GetRaces()
        {
            var reader = Reader.GetTableReader(InfoRequest.Races());
            var races = new List<RaceResult>();
            while (reader.Read())
            {
                var race = new RaceResult(
                        reader["FirstName"].ToString(),
                        reader["LastName"].ToString(),
                        reader["CountryCode"].ToString(),
                        reader["RaceTime"].ToString(),
                        reader["Gender"].ToString(),
                        reader["MarathonId"].ToString(),
                        reader["EventTypeId"].ToString(),
                        reader["DateOfBirth"].ToString()
                    );
                races.Add(race);
            }
            return races;
        }
    }
}
