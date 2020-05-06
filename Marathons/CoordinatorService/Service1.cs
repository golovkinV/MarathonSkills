using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Marathons;
using SerializationClasses;

namespace CoordinatorService
{
    public class Service1 : ICoordinatorService
    {
        public void EditUser(User user)
        {
            using (SqlConnection con = new SqlConnection(Configuration.someeServer))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = CoordinatorRequest.UpdateUser(user);
                cmd.ExecuteNonQuery();

                SqlCommand cmdRunner = con.CreateCommand();
                cmdRunner.CommandType = CommandType.Text;
                var runner = user.runnerData;
                cmdRunner.CommandText = CoordinatorRequest.UpdateRunner(runner, user.email);
                cmdRunner.Parameters.AddWithValue("@DateOfBirth", Convert.ToDateTime(runner.dateOfBirth));
                cmdRunner.ExecuteNonQuery();

                SqlCommand cmdStatus = con.CreateCommand();
                cmdStatus.CommandType = CommandType.Text;
                cmdStatus.CommandText = CoordinatorRequest.UpdateRegistrationStatus(user.registrationStatus);
                cmdStatus.ExecuteNonQuery();
            }
        }

        public List<User> GetAllRunners()
        {
            var reader = Reader.GetTableReader(CoordinatorRequest.Runners());
            var users = new List<User>();
            while (reader.Read())
            {
                var role = new Role(reader["RoleId"].ToString());
                var user = new User(
                        reader["Email"].ToString(),
                        reader["Password"].ToString(),
                        reader["FirstName"].ToString(),
                        reader["LastName"].ToString(),
                        role
                    );
                user.registrationStatus = new RegistrationStatus(
                    reader["RegistrationStatusId"].ToString(),
                    reader["RegistrationStatus"].ToString(),
                    reader["RegistrationId"].ToString()
                );
                var country = new Country(
                    reader["CountryCode"].ToString(),
                    reader["CountryName"].ToString()
                );
                user.runnerData = new RunnerData(
                    reader["RunnerId"].ToString(),
                    reader["Gender"].ToString(),
                    reader["Date"].ToString(),
                    country
                );
                user.runnerData.charity = new Charity(
                    reader["CharityId"].ToString(),
                    reader["CharityName"].ToString()
                );
                user.runnerData.kitOption = new KitOption(
                    reader["RaceKitOptionId"].ToString(),
                    reader["RaceKitOption"].ToString()
                );
                user.runnerData.target = Convert.ToDouble(reader["Cost"].ToString());
                users.Add(user);
            }
            SetRunnersEvent(users);
            return users;
        }

        private void SetRunnersEvent(List<User> users)
        {
            for (var i = 0; i < users.Count; i++)
            {
                var user = users[i];
                user.runnerData.events = GetEvents(user.registrationStatus.registrationId);
            }
        }

        private List<Event> GetEvents(int registrationId)
        {
            var reader = Reader.GetTableReader(CoordinatorRequest.Events(registrationId));
            var events = new List<Event>();
            while (reader.Read())
            {
                var localEvent = new Event(
                    reader["EventId"].ToString(),
                    reader["EventName"].ToString()
                );
                events.Add(localEvent);
            }
            return events;
        }

        public List<Country> GetCountries()
        {
            var reader = Reader.GetTableReader(CoordinatorRequest.Countries());
            var countries = new List<Country>();
            while (reader.Read())
            {
                var country = new Country(
                    reader["CountryCode"].ToString(),
                    reader["CountryName"].ToString()
                );
                countries.Add(country);
            }
            return countries;
        }

        public List<RegistrationStatus> GetRegistrationStatuses()
        {
            var reader = Reader.GetTableReader(CoordinatorRequest.Statuses());
            var statuses = new List<RegistrationStatus>();
            while (reader.Read())
            {
                var status = new RegistrationStatus(
                    reader["RegistrationStatusId"].ToString(),
                    reader["RegistrationStatus"].ToString()
                );
                statuses.Add(status);
            }
            return statuses;
        }

        public List<Charity> GetCharities()
        {
            var reader = Reader.GetTableReader(CoordinatorRequest.Charities());
            var charities = new List<Charity>();
            while (reader.Read())
            {
                var totalAmount = Convert.ToDouble(reader["Total"].ToString());
                var charity = new Charity(
                    reader["CharityId"].ToString(),
                    reader["CharityName"].ToString(),
                    totalAmount,
                    reader["CharityLogo"].ToString()
                );
                charities.Add(charity);
            }
            return charities;
        }
    }
}
