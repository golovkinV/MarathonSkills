using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerializationClasses
{
    [DataContract]
    public class Marathon
    {
        [DataMember]
        public int id;

        [DataMember]
        public string name;

        [DataMember]
        public string cityName;

        [DataMember]
        public string country;

        [DataMember]
        public int year;

        public Marathon(string id, string name, string cityName, string countryCode, string year)
        {
            this.id = Convert.ToInt32(id);
            this.name = name;
            this.cityName = cityName;
            this.country = GetCountry(countryCode);
            this.year = Convert.ToInt32(year);
        }

        private string GetCountry(string code)
        {
            switch(code)
            {
                case "GBR":
                    return "United Kingdom";
                case "VIE":
                    return "Vietnam";
                case "GER":
                    return "Germany";
                case "JPN":
                    return "Japan";
                case "BRA":
                    return "Brazil";
                default:
                    return "";
            }
        }
    }
}
