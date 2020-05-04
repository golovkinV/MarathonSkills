using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
