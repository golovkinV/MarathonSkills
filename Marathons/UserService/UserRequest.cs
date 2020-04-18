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
            return $"SELECT Runner.RunnerId, Runner.Gender, CONVERT(varchar, Runner.DateOfBirth, 104) as Date, Country.CountryCode, Country.CountryName " +
                $"FROM([Runner] INNER JOIN [Country] ON Runner.CountryCode = Country.CountryCode) WHERE Email = '{email}'";
        }

        public static string UpdateUser(User user)
        {
            return $"UPDATE [User] SET Password = '{user.password}', FirstName = '{user.firstName}', LastName = '{user.lastName}' " +
                $"WHERE Email = '{user.email}'";
        }

        public static string UpdateRunnerData(RunnerData runner, string email)
        {
            return $"UPDATE [Runner] SET Gender = '{runner.gender}', DateOfBirth = '{Convert.ToDateTime(runner.dateOfBirth)}', CountryCode = '{runner.countryCode}' " +
                $"WHERE Email = '{email}'";
        }

        public static string RegisterUser(string email, string password, string firstName, string lastName) {
            return $"INSERT INTO [User] (Email, Password, FirstName, LastName, RoleId) " +
                $"VALUES('{email}', '{password}', '{firstName}', '{lastName}', 'R')";
        }

        public static string RegisterRunner(string email, string gender, string dateOfBirth, string countryCode) {
            return $"INSERT INTO [Runner] (Email, Gender, DateOfBirth, CountryCode) " +
                $"VALUES('{email}', '{gender}', '{Convert.ToDateTime(dateOfBirth)}', '{countryCode}')";
        }
    }
}
