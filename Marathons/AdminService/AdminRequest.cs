using SerializationClasses;

namespace AdminService
{
    public class AdminRequest
    {
        public static string Charities()
        {
            return "SELECT * FROM [Charity]";
        }

        public static string UpdateCharity(Charity charity)
        {
            return $"UPDATE [Charity] SET CharityName = '{charity.name}', CharityDescription = '{charity.desc}', CharityLogo = '{charity.logo}' " +
                   $"WHERE CharityId = '{charity.id}'";
        }

        public static string NewCharity(string name, string desc, string logo)
        {
            return $"INSERT INTO [Charity] (CharityName, CharityDescription, CharityLogo) " +
                $"VALUES('{name}', '{desc}', '{logo}')";
        }

        public static string NewVolunteer(Volunteer volunteer) 
        {
            return $"INSERT INTO [Volunteer] (FirstName, LastName, CountryCode, Gender) " +
                $"VALUES('{volunteer.firstName}', '{volunteer.lastName}', '{volunteer.countryCode}', '{volunteer.gender}')";
        }

        public static string Users()
        {
            return "SELECT * FROM [User]";
        }

        public static string UpdateUser(User user) 
        {
            return $"UPDATE [User] SET Password = '{user.password}', FirstName = '{user.firstName}', LastName = '{user.lastName}', RoleId = '{user.role.roleId}' " +
                $"WHERE Email = '{user.email}'";
        }

        public static string NewUser(string email, string password, string firstName, string lastName, string roleId) {
            return $"INSERT INTO [User] (Email, Password, FirstName, LastName, RoleId) " +
                $"VALUES('{email}', '{password}', '{firstName}', '{lastName}', '{roleId}')";
        }
    }
}
