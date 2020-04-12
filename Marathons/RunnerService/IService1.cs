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
