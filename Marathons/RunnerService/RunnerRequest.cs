using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunnerService
{
    public class RunnerRequest
    {
        public static string Sponsorship(int runnerId) {
            return $"SELECT Sponsorship.SponsorshipId, Sponsorship.SponsorName, Sponsorship.RegistrationId, Sponsorship.Amount, Registration.CharityId " +
                $"FROM (Sponsorship INNER JOIN Registration ON Sponsorship.RegistrationId = Registration.RegistrationId INNER JOIN Runner ON Runner.RunnerId = Registration.RunnerId) " +
                $"WHERE Runner.RunnerId = {runnerId}";
        }

        public static string Charity(int charityId) {
            return $"SELECT * FROM [Charity] WHERE CharityId = {charityId}";
        }
    }
}
