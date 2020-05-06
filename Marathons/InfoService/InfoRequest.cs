using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoService
{
    public class InfoRequest
    {
        public static string Races()
        {
            return "SELECT Runner.Gender, CONVERT(nvarchar, Runner.DateOfBirth, 104) as DateOfBirth, Runner.CountryCode, " +
                "Marathon.MarathonId, EventType.EventTypeId, RegistrationEvent.RaceTime, [User].FirstName, [User].LastName " +
                "FROM(Runner INNER JOIN Registration ON Runner.RunnerId = Registration.RunnerId " +
                "INNER JOIN [User] ON Runner.Email = [User].Email " +
                "INNER JOIN RegistrationEvent ON RegistrationEvent.RegistrationId = Registration.RegistrationId " +
                "INNER JOIN Event ON RegistrationEvent.EventId = Event.EventId " +
                "INNER JOIN EventType ON Event.EventTypeId = EventType.EventTypeId " +
                "INNER JOIN Marathon ON Event.MarathonId = Marathon.MarathonId) " +
                "WHERE RegistrationEvent.RaceTime IS NOT NULL";
        }

        public static string Charities()
        {
            return "SELECT * FROM Charity";
        }

        public static string EventTypes()
        {
            return "SELECT * FROM EventType";
        }

        public static string Marathons()
        {
            return "SELECT * FROM Marathon";
        }
    }
}
