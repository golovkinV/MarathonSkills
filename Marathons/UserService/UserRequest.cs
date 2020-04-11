using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService
{
    public class UserRequest
    {
        public static string User(string email, string password)
        {
            return $"SELECT * FROM [User] WHERE Email = '{email}' AND Password = '{password}'";
        }

        public static string RunnerData(string email)
        {
            return $"SELECT Runner.Gender, CONVERT(varchar, Runner.DateOfBirth, 104) as Date, Country.CountryCode, Country.CountryName " +
                $"FROM([Runner] INNER JOIN [Country] ON Runner.CountryCode = Country.CountryCode) WHERE Email = '{email}'";
        }

        public static string UpdateUser(User user)
        {
            return $"UPDATE [User] SET Password = '{user.password}', FirstName = '{user.firstName}', LastName = '{user.lastName}' " +
                $"WHERE Email = '{user.email}'";
        }

        public static string UpdateRunnerData(RunnerData runner, string email)
        {
            return $"UPDATE [Runner] SET Gender = '{runner.gender}', DateOfBirth = '{Convert.ToDateTime(runner.birthday)}', CountryCode = '{runner.countryCode}' " +
                $"WHERE Email = '{email}'";
        }
    }
}
