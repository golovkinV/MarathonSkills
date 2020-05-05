using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SponsorService
{
    public class SponsorRequest
    {
        public static string Runners()
        {
            return "SELECT Registration.RegistrationId, Registration.RunnerId, [User].FirstName, [User].LastName, Country.CountryName, Registration.SponsorshipTarget " +
                "FROM(Registration INNER JOIN Runner ON Registration.RunnerId = Runner.RunnerId " +
                "INNER JOIN [User] ON Runner.Email = [User].Email " +
                "INNER JOIN Country ON Runner.CountryCode = Country.CountryCode)";
        }
    }
}
