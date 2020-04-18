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

    public class Service1 : IService1
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
                var runnerReader = Reader.GetTableReader(UserRequest.RunnerData(email));
                runnerReader.Read();
                var runner = new RunnerData(
                    runnerReader["RunnerId"].ToString(),
                    runnerReader["Gender"].ToString(),
                    runnerReader["Date"].ToString(),
                    runnerReader["CountryCode"].ToString(),
                    runnerReader["CountryName"].ToString()
                );
                user.runnerData = runner;
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
                cmdRunner.CommandText = UserRequest.RegisterRunner(email, gender, dateOfBirth, countryCode);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
