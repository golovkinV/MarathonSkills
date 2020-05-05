using System;
using SerializationClasses;

namespace SponsorService
{
    public class SponsorRequest
    {
        public static string Runners()
        {
            return "SELECT Registration.RegistrationId, Registration.RunnerId, [User].FirstName, [User].LastName, " +
                "Country.CountryName, Registration.SponsorshipTarget, Charity.CharityId, Charity.CharityName, Charity.CharityDescription, Charity.CharityLogo " +
                "FROM(Registration INNER JOIN Runner ON Registration.RunnerId = Runner.RunnerId " +
                "INNER JOIN [User] ON Runner.Email = [User].Email " +
                "INNER JOIN Country ON Runner.CountryCode = Country.CountryCode " +
                "INNER JOIN Charity ON Registration.CharityId = Charity.CharityId)";
        }

        public static string Sponsor(string name, Runner runner, double amount)
        {
            return $"INSERT INTO [Sponsorship] (SponsorName, RegistrationId, Amount) " +
                $"VALUES('{name}', '{runner.registrationId}', '{amount}')";
        }

        public static string UpdateSponsorshipTarget(Runner runner)
        {
            return $"UPDATE [Registration] SET SponsorshipTarget = '{runner.sponsorshipTarget}' WHERE RegistrationId = '{runner.registrationId}'";
        }
    }
}
