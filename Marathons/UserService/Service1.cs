using System;
using Marathons;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace UserService
{

    public class Service1 : IUserService
    {

        public User Login(string email, string password)
        {
            var userReader = Reader.GetTableReader(UserRequest.User(email, password));

            userReader.Read();
            var role = new Role(userReader["RoleId"].ToString());
            var user = new User(
                userReader["Email"].ToString(),
                userReader["Password"].ToString(),
                userReader["FirstName"].ToString(),
                userReader["LastName"].ToString(),
                role
            );

            if (role.roleId == "R")
            {
                user.runnerData = GetRunnerData(email);
            }

          
            return user;
        }

        public void EditUser(User user) {
            using (SqlConnection con = new SqlConnection(Configuration.someeServer))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = UserRequest.UpdateUser(user);
                cmd.ExecuteNonQuery();

                if (user.runnerData != null)
                {
                    SqlCommand cmdRunner = con.CreateCommand();
                    cmdRunner.CommandType = CommandType.Text;
                    var runner = user.runnerData;
                    cmdRunner.CommandText = UserRequest.UpdateRunnerData(runner, user.email);
                    cmdRunner.Parameters.AddWithValue("@DateOfBirth", Convert.ToDateTime(runner.dateOfBirth));
                    cmdRunner.ExecuteNonQuery();
                }
            }
        }

        public void RegisterAsRunner(string email, string password, string firstName, string lastName,
            string gender, string dateOfBirth, string countryCode)
        {
            using (SqlConnection con = new SqlConnection(Configuration.someeServer))
            {
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = UserRequest.RegisterUser(email, password, firstName, lastName);
                cmd.ExecuteNonQuery();

                var cmdRunner = con.CreateCommand();
                cmdRunner.CommandType = CommandType.Text;
                cmdRunner.CommandText = UserRequest.RegisterRunner(email, gender, countryCode);
                cmdRunner.Parameters.AddWithValue("@DateOfBirth", Convert.ToDateTime(dateOfBirth));
                cmdRunner.ExecuteNonQuery();
            }
        }

        public void RegisterForEvent(string email, List<string> eventIds, 
            string kitOptionId, int charityId, double registrationCost)
        {
            var runnerData = GetRunnerData(email);

            using (SqlConnection con = new SqlConnection(Configuration.someeServer))
            {
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = UserRequest.Registration(runnerData.id, kitOptionId, registrationCost, charityId);
                cmd.Parameters.AddWithValue("@Today", DateTime.Now);
                cmd.ExecuteNonQuery();

                var reader = Reader.GetTableReader(UserRequest.GetLastRegistrationId(runnerData.id));
                reader.Read();
                var registrationId = Convert.ToInt32(reader["RegistrationId"].ToString());

                eventIds.ForEach(eventId =>
                {
                    var registEvent = con.CreateCommand();
                    registEvent.CommandType = CommandType.Text;
                    registEvent.CommandText = UserRequest.RegistrationEvent(registrationId, eventId);
                    registEvent.ExecuteNonQuery();
                });
            }
        }

        private RunnerData GetRunnerData(string email) {
            var runnerReader = Reader.GetTableReader(UserRequest.RunnerData(email));
            runnerReader.Read();
            var runner = new RunnerData(
                runnerReader["RunnerId"].ToString(),
                runnerReader["Gender"].ToString(),
                runnerReader["Date"].ToString(),
                runnerReader["CountryCode"].ToString(),
                runnerReader["CountryName"].ToString()
            );
            return runner;
        }

        public List<Event> GetEvents()
        {
            var reader = Reader.GetTableReader(UserRequest.Events());
            var events = new List<Event>();
            while (reader.Read())
            {
                var localEvent = new Event(
                        reader["EventId"].ToString(),
                        reader["EventName"].ToString(),
                        reader["Cost"].ToString()
                    );
                events.Add(localEvent);
            }
            return events;
        }

        public List<KitOption> GetKitOptions()
        {
            var reader = Reader.GetTableReader(UserRequest.KitOptions());
            var kitOptions = new List<KitOption>();
            while (reader.Read())
            {
                var kitOption = new KitOption(
                        reader["RaceKitOptionId"].ToString(),
                        reader["RaceKitOption"].ToString(),
                        reader["Cost"].ToString()
                    );
                kitOptions.Add(kitOption);
            }
            return kitOptions;
        }

        public List<Charity> GetCharities()
        {
            var reader = Reader.GetTableReader(UserRequest.Charities());
            var charities = new List<Charity>();
            while (reader.Read())
            {
                var charity = new Charity(
                    reader["CharityId"].ToString(),
                    reader["CharityName"].ToString()
                );
                charities.Add(charity);
            }
            return charities;
        }
    }
}
