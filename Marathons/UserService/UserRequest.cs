using SerializationClasses;

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
            return $"UPDATE [Runner] SET Gender = '{runner.gender}', DateOfBirth = @DateOfBirth, CountryCode = '{runner.country.code}' " +
                $"WHERE Email = '{email}'";
        }

        public static string RegisterUser(string email, string password, string firstName, string lastName) {
            return $"INSERT INTO [User] (Email, Password, FirstName, LastName, RoleId) " +
                $"VALUES('{email}', '{password}', '{firstName}', '{lastName}', 'R')";
        }

        public static string RegisterRunner(string email, string gender, string countryCode) {
            return $"INSERT INTO [Runner] (Email, Gender, DateOfBirth, CountryCode) " +
                $"VALUES('{email}', '{gender}', @DateOfBirth, '{countryCode}')";
        }

        public static string Events() 
        {
            return "SELECT EventId, EventName, Cost FROM [Event] WHERE MarathonId = 5";
        }

        public static string KitOptions()
        {
            return "SELECT * FROM [RaceKitOption]";
        }

        public static string Charities()
        {
            return "SELECT * FROM [Charity]";
        }

        public static string Registration(int runnerId, string kitOptionId, double cost, int charityId)
        {
            return $"INSERT INTO [Registration] (RunnerId, RegistrationDateTime, RaceKitOptionId, RegistrationStatusId, Cost, CharityId, SponsorshipTarget) " +
                $"VALUES('{runnerId}', @Today, '{kitOptionId}', '1', '{cost}', '{charityId}', '0')";
        }

        public static string GetLastRegistrationId(int runnerId)
        {
            return $"SELECT TOP 1 RegistrationId FROM Registration WHERE RunnerId = {runnerId} ORDER BY RegistrationId DESC";
        }

        public static string RegistrationEvent(int registrationId, string eventId)
        {
            return $"INSERT INTO [RegistrationEvent] (RegistrationId, EventId) VALUES('{registrationId}', '{eventId}')";
        }

        public static string Countries()
        {
            return "SELECT * FROM [Country]";
        }
    }
}
