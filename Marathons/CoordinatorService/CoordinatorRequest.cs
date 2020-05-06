using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerializationClasses;

namespace CoordinatorService
{
    public class CoordinatorRequest
    {
        public static string Runners()
        {
            return $"SELECT [User].Email, Password, FirstName, LastName, RoleId, " +
                $"Runner.RunnerId, Gender, CONVERT(varchar, DateOfBirth, 104) as Date, Country.CountryCode, CountryName, " +
                $"RegistrationStatus.RegistrationStatusId, RegistrationStatus, RegistrationId, " +
                $"Charity.CharityId, CharityName, RaceKitOption.RaceKitOptionId, RaceKitOption, Registration.Cost " +
                $"FROM([User] INNER JOIN Runner ON [User].Email = Runner.Email " +
                $"INNER JOIN Country ON Runner.CountryCode = Country.CountryCode " +
                $"INNER JOIN Registration ON Registration.RunnerId = Runner.RunnerId " +
                $"INNER JOIN RegistrationStatus ON Registration.RegistrationStatusId = RegistrationStatus.RegistrationStatusId " +
                $"INNER JOIN Charity ON Registration.CharityId = Charity.CharityId " +
                $"INNER JOIN RaceKitOption ON Registration.RaceKitOptionId = RaceKitOption.RaceKitOptionId) " +
                $"WHERE RoleId = 'R'";
        }

        public static string Charities()
        {
            return "SELECT Charity.CharityId, Charity.CharityName, SUM(Registration.SponsorshipTarget) Total, Charity.CharityLogo " +
                "FROM Charity " +
                "LEFT JOIN Registration ON Registration.CharityId = Charity.CharityId " +
                "GROUP BY Charity.CharityId, Charity.CharityName, Charity.CharityLogo";
        }

        public static string Events(int registrationId)
        {
            return $"SELECT e.EventId, e.EventName " +
                $"FROM Event e " +
                $"LEFT JOIN RegistrationEvent re ON re.EventId = e.EventId " +
                $"WHERE re.RegistrationId = {registrationId} AND e.MarathonId = 5";
        }

        public static string UpdateUser(User user)
        {
            return $"UPDATE [User] SET Password = '{user.password}', FirstName = '{user.firstName}', LastName = '{user.lastName}' " +
                $"WHERE Email = '{user.email}'";
        }

        public static string UpdateRunner(RunnerData runner, string email)
        {
            return $"UPDATE [Runner] SET Gender = '{runner.gender}', DateOfBirth = @DateOfBirth, CountryCode = '{runner.country.code}' " +
                $"WHERE Email = '{email}'";
        }

        public static string UpdateRegistrationStatus(RegistrationStatus status)
        {
            return $"UPDATE [Registration] SET RegistrationStatusId = {status.id} WHERE RegistrationId = {status.registrationId}";
        }

        public static string Countries()
        {
            return "SELECT * FROM Country";
        }

        public static string Statuses()
        {
            return "SELECT * FROM RegistrationStatus";
        }
    }
}
