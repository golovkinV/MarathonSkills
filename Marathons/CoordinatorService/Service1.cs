using System;
using System.Collections.Generic;
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
                    reader["RegistrationStatus"].ToString()
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
                users.Add(user);
            }
            return users;
        }
    }
}
