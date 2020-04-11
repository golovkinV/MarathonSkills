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

        public User GetUser(string email, string password)
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
            using (SqlConnection con = new SqlConnection(Configuration.localServer))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = UserRequest.UpdateUser(user);
                cmd.ExecuteNonQuery();

                if (user.runnerData != null)
                {
                    SqlCommand cmd_runner = con.CreateCommand();
                    cmd_runner.CommandType = CommandType.Text;
                    var runner = user.runnerData;
                    cmd_runner.CommandText = UserRequest.UpdateRunnerData(runner, user.email);
                    cmd_runner.ExecuteNonQuery();
                }
            }
        }
    }
}
