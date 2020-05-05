using System;
using System.Collections.Generic;
using Marathons;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SponsorService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service1 : ISponsorService
    {
        public List<Runner> GetRunners()
        {
            var reader = Reader.GetTableReader(SponsorRequest.Runners());
            var runners = new List<Runner>();
            while (reader.Read())
            {
                var runner = new Runner(
                        reader["RegistrationId"].ToString(),
                        reader["RunnerId"].ToString(),
                        reader["FirstName"].ToString(),
                        reader["LastName"].ToString(),
                        reader["CountryName"].ToString(),
                        reader["SponsorshipTarget"].ToString()
                    );
                runners.Add(runner);
            }
            return runners;
        }
    }
}
