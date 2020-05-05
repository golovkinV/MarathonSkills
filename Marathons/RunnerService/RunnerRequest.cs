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

        public static string Races(int runnerId) {
            return $"SELECT Runner.Gender, Runner.DateOfBirth, Country.CountryName, Marathon.YearHeld, EventType.EventTypeName, RegistrationEvent.RaceTime " +
                $"FROM(Runner INNER JOIN Registration ON Runner.RunnerId = Registration.RunnerId " +
                $"INNER JOIN RegistrationEvent ON RegistrationEvent.RegistrationId = Registration.RegistrationId " +
                $"INNER JOIN Event ON RegistrationEvent.EventId = Event.EventId " +
                $"INNER JOIN EventType ON Event.EventTypeId = EventType.EventTypeId " +
                $"INNER JOIN Marathon ON Event.MarathonId = Marathon.MarathonId " +
                $"INNER JOIN Country ON Marathon.CountryCode = Country.CountryCode) " +
                $"WHERE Runner.RunnerId = {runnerId}";
        }
    }
}
