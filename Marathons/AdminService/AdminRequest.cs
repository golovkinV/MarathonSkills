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
    }
}
