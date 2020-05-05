using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinatorService
{
    public class CoordinatorRequest
    {
        public static string Runners()
        {
            return $"SELECT [User].Email, Password, FirstName, LastName, RoleId, " +
                $"Runner.RunnerId, Gender, CONVERT(varchar, DateOfBirth, 104) as Date, Country.CountryCode, CountryName, " +
                $"RegistrationStatus.RegistrationStatusId, RegistrationStatus " +
                $"FROM([User] INNER JOIN Runner ON [User].Email = Runner.Email " +
                $"INNER JOIN Country ON Runner.CountryCode = Country.CountryCode " +
                $"INNER JOIN Registration ON Registration.RunnerId = Runner.RunnerId " +
                $"INNER JOIN RegistrationStatus ON Registration.RegistrationStatusId = RegistrationStatus.RegistrationStatusId) " +
                $"WHERE RoleId = 'R'";
        }
    }
}
