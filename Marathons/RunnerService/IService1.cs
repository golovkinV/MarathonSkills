using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RunnerService
{

    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Sponsor> GetSponsorship(int runnerId);

        [OperationContract]
        Charity GetCharity(int charityId);

        [OperationContract]
        List<RaceInfo> GetRaces(int runnerId);
    }

    [DataContract]
    public class RaceInfo {
        [DataMember]
        public string country;

        [DataMember]
        public string eventName;

        [DataMember]
        public int year;

        [DataMember]
        public long time;

        [DataMember]
        public string gender;

        [DataMember]
        public DateTime userDateOfBirth;

        public RaceInfo(string gender, string userDateOfBirth,
            string time, string country, string eventName, string year) {
            this.gender = gender;
            this.userDateOfBirth = Convert.ToDateTime(userDateOfBirth);
            this.time = !string.IsNullOrEmpty(time) ? Convert.ToInt64(time): 0;
            this.country = country;
            this.eventName = eventName;
            this.year = Convert.ToInt32(year);
        }
    }

    [DataContract]
    public class Sponsor
    {

        [DataMember]
        public int id;

        [DataMember]
        public int registrationId;

        [DataMember]
        public string name;

        [DataMember]
        public double amount;

        [DataMember]
        public int charityId;

        public Sponsor(string id, string name, string registrationId, string amount, string charityId) {
            this.id = Convert.ToInt32(id);
            this.name = name;
            this.registrationId = Convert.ToInt32(registrationId);
            this.amount = Convert.ToDouble(amount);
            this.charityId = Convert.ToInt32(charityId);
        }
    }

    [DataContract]
    public class Charity {

        [DataMember]
        public int id;

        [DataMember]
        public string name;

        [DataMember]
        public string desc;

        [DataMember]
        public string logo;

        public Charity(string id, string name, string desc, string logo) {
            this.id = Convert.ToInt32(id);
            this.name = name;
            this.desc = desc;
            this.logo = logo;
        }
    }
}
